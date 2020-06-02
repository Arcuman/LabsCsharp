using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows;
using System.Xml.Serialization;
using WPFLocalizeExtension.Engine;

namespace ToDo_List
{
    public class MainViewModel : ViewModelBase
    {
        #region Private Members
        /// <summary>
        /// Выбранная задача
        /// </summary>
        private TaskViewModel selectedTask;
        /// <summary>
        /// Выбранная задача
        /// </summary>
        private ObservableCollection<TaskViewModel> tasksList;

        /// <summary>
        /// Задача для отмены
        /// </summary>
        private TaskViewModel recoveryTask;


        /// <summary>
        ///Задачи для Undo
        /// </summary>
        private ObservableCollection<TaskViewModel> undoTasks;


        /// <summary>
        /// Задачи для Redo
        /// </summary>
        private ObservableCollection<TaskViewModel> redoTasks;

        /// <summary>
        /// Флаг Нажата ли кнопка добавить
        /// </summary>
        private bool isAddPressed;

        /// <summary>
        /// Флаг Нажата ли кнопка изменить
        /// </summary>
        private bool isEditPressed;

        /// <summary>
        /// Доступен ли контейнер
        /// </summary>
        private bool isEnabled;

        #endregion

        #region Public Properties
        /// <summary>
        /// Коллекция задач
        /// </summary>
        public ObservableCollection<TaskViewModel> TasksList
        {
            get => this.tasksList;
            set
            {
                this.tasksList = value;
                this.OnPropertyChanged("TasksList");
            }
        }

        /// <summary>
        /// Свойство выбраной задачи
        /// </summary>
        public TaskViewModel SelectedTask
        {
            get => this.selectedTask;
            set
            {
                this.selectedTask = value;
                this.OnPropertyChanged("SelectedTask");
            }
        }

        /// <summary>
        /// Свойство выбраной задачи
        /// </summary>
        public bool IsEnabled
        {
            get { return isEnabled; }
            set
            {
                this.isEnabled = value;
                this.OnPropertyChanged("IsEnabled");
            }
        }
        #endregion

        #region Constructor

        public MainViewModel(List<Task> books)
        {
            this.isAddPressed = false;
            this.isEditPressed = false;
            this.IsEnabled = true;
            undoTasks = null;
            redoTasks = null;
            this.TasksList = new ObservableCollection<TaskViewModel>(books.Select(b => new TaskViewModel(b)));
        }

        #endregion

        #region Commands

        /// <summary>
        /// Команда добавить
        /// </summary>
        private RelayCommand addCommand;
        public RelayCommand AddCommand => addCommand ??
                    (this.addCommand = new RelayCommand(
                        //Создаем новую задачу,добавляем ее в список 
                        //Устанавливаем необходимые флаги
                        obj =>
                    {
                        this.redoTasks = null;
                        this.undoTasks = new ObservableCollection<TaskViewModel>(this.TasksList);
                        this.IsEnabled = false;
                        this.isAddPressed = true;
                        this.isEditPressed = false;
                        var task = new TaskViewModel(new Task());
                        this.SelectedTask = task;
                        this.TasksList.Insert(0, task);
                        this.SelectedTask.IsEnabled = true;
                    },
                        //Если не нажаты кнопки (добавить или изменить)
                        x => !this.isAddPressed && !this.isEditPressed
                    ));
        /// <summary>
        /// Команда сохранить
        /// </summary>
        private RelayCommand saveCommand;
        /// <summary>
        /// Свойство для команда сохранить
        /// </summary>
        public RelayCommand SaveCommand => this.saveCommand ??
                    (this.saveCommand = new RelayCommand(obj =>
                    {

                        var results = new List<ValidationResult>();
                        var context = new ValidationContext(this.SelectedTask);
                        if (!Validator.TryValidateObject(this.SelectedTask, context, results, true))
                        {
                            foreach (var error in results)
                            {
                                var strWithErrroe = error.ErrorMessage;
                            }
                            return;
                        }
                        var tasks = new List<Task>();
                        var formatter = new XmlSerializer(typeof(List<Task>));
                        foreach (var item in this.TasksList)
                        {
                            tasks.Add(item.Task);
                        }

                        using (var fs = new FileStream("../../DataBase/TasksStorage.xml", FileMode.Open))
                        {
                            formatter.Serialize(fs, tasks);
                        }

                        this.IsEnabled = true;
                        this.isAddPressed = this.isEditPressed = this.SelectedTask.IsEnabled = false;
                        this.recoveryTask = null;
                    },
                    //Если  нажаты кнопки (добавить или изменить)
                    x =>  (this.isAddPressed || this.isEditPressed ) && (this.SelectedTask == null ? false : this.SelectedTask.IsValid)
                    ));
        /// <summary>
        /// Команда удалить
        /// </summary>
        private RelayCommand deleteCommand;
        /// <summary>
        /// Свойство для команда удалить
        /// </summary>
        public RelayCommand DeleteCommand => this.deleteCommand ??
                    (this.deleteCommand = new RelayCommand(obj => {
                        this.redoTasks = null;
                        this.undoTasks = new ObservableCollection<TaskViewModel>(this.TasksList);
                        this.TasksList.Remove(this.SelectedTask);
                        var tasks = new List<Task>();
                        var formatter = new XmlSerializer(typeof(List<Task>));
                        foreach (var item in this.TasksList)
                        {
                            tasks.Add(item.Task);
                        }

                        using (var fs = new FileStream("../../DataBase/TasksStorage.xml", FileMode.Truncate))
                        {
                            formatter.Serialize(fs, tasks);
                        }
                    },
                    //Если выбрана задача и не нажаты добавить или изменить
                    x => this.SelectedTask != null && !this.isAddPressed && !this.isEditPressed
                    ));
        /// <summary>
        /// Команда изменить
        /// </summary>
        private RelayCommand editCommand;
        /// <summary>
        /// Свойство для команда изменить
        /// </summary>
        public RelayCommand EditCommand =>
                //Разрешает изменять свойства выбранной задачи
                //Изменяет флаги 
                this.editCommand ??
                    (this.editCommand = new RelayCommand(obj =>
                    {
                        this.redoTasks = null;
                        this.undoTasks = new ObservableCollection<TaskViewModel>(this.TasksList);
                        this.isEditPressed = true;
                        this.IsEnabled = false;
                        this.recoveryTask = new TaskViewModel(this.SelectedTask);
                        this.SelectedTask.IsEnabled = true;
                    },
                    //Если выбрана задача и не нажата кнопка добавить
                    x => this.SelectedTask != null && !this.isAddPressed && !this.isEditPressed
                    ));
        /// <summary>
        /// Команда отменить
        /// </summary>
        private RelayCommand cancelCommand;

        /// <summary>
        /// Свойство для команда отмены
        /// </summary>
        public RelayCommand CancelCommand => this.cancelCommand ??
                    (this.cancelCommand = new RelayCommand(obj =>
                    {
                        this.undoTasks = null;
                        //если нажата кнопка изменить вернуть к исходному 
                        if (this.isEditPressed)
                        {
                            this.SelectedTask.Change(this.recoveryTask.Task);
                        }

                        //если нажата кнопка добавить отменить добавление
                        if (this.isAddPressed)
                        {
                            this.TasksList.Remove(this.SelectedTask);
                        }

                        this.isAddPressed = false;
                        this.isEditPressed = false;
                        this.IsEnabled = true;

                        if (this.SelectedTask != null)
                        {
                            this.SelectedTask.IsEnabled = false;
                        }
                    },
                    //Если нажата кнопка добавить или изменить
                    x => this.isAddPressed || this.isEditPressed
                    ));

        /// <summary>
        /// Команда сортировки по приоритету
        /// </summary>
        private RelayCommand priorityCommand;
        /// <summary>
        /// Свойство для команды сортировки по приоритету
        /// </summary>
        public RelayCommand PriorityCommand => this.priorityCommand ??
                    (this.priorityCommand = new RelayCommand(obj => {
                        TasksList =  new ObservableCollection<TaskViewModel>(this.TasksList.OrderBy(x => x.Priority));

                    },
                    //Если нажата кнопка добавить или изменить
                    x => !this.isAddPressed && !this.isEditPressed
                    ));     /// <summary>
        /// Команда сортировки по приоритету
        /// </summary>
        /// 
        private RelayCommand statusCommand;
        /// <summary>
        /// Свойство для команды сортировки по приоритету
        /// </summary>
        public RelayCommand StatusCommand => this.statusCommand ??
                    (this.statusCommand = new RelayCommand(obj => {
                        TasksList =  new ObservableCollection<TaskViewModel>(this.TasksList.OrderBy(x => x.Status));

                    },
                    //Если нажата кнопка добавить или изменить
                    x => !this.isAddPressed && !this.isEditPressed
                    ));

        private RelayCommand languageCommand;
        /// <summary>
        /// Свойство для команды сортировки по приоритету
        /// </summary>
        public RelayCommand LanguageCommand => this.languageCommand ??
                    (this.languageCommand = new RelayCommand(obj => {
                        if (LocalizeDictionary.CurrentCulture.Name == "")
                        {
                            LocalizeDictionary.Instance.SetCurrentThreadCulture = true;
                            LocalizeDictionary.Instance.Culture = new CultureInfo("ru-RU");
                        }
                        else
                        {
                            LocalizeDictionary.Instance.SetCurrentThreadCulture = true;
                            LocalizeDictionary.Instance.Culture = new CultureInfo("");

                        }

                    },
                    //Если нажата кнопка добавить или изменить
                    x => !this.isAddPressed && !this.isEditPressed
                    ));

        private RelayCommand undoCommand;
        /// <summary>
        /// Свойство для команды сортировки по приоритету
        /// </summary>
        public RelayCommand UndoCommand => this.undoCommand ??
                    (this.undoCommand = new RelayCommand(obj => {
                        //если нажата кнопка изменить вернуть к исходному
                        this.redoTasks = new ObservableCollection<TaskViewModel>(this.TasksList);
                        this.TasksList = new ObservableCollection<TaskViewModel>(this.undoTasks);
                        var tasks = new List<Task>();
                        var formatter = new XmlSerializer(typeof(List<Task>));
                        foreach (var item in this.TasksList)
                        {
                            tasks.Add(item.Task);
                        }

                        using (var fs = new FileStream("../../DataBase/TasksStorage.xml", FileMode.Open))
                        {
                            formatter.Serialize(fs, tasks);
                        }
                        this.undoTasks = null;

                    },
                    //Если нажата кнопка добавить или изменить
                    x => this.undoTasks != null
                    ));
        private RelayCommand redoCommand;
        /// <summary>
        /// Свойство для команды сортировки по приоритету
        /// </summary>
        public RelayCommand RedoCommand => this.redoCommand ??
                    (this.redoCommand = new RelayCommand(obj => {
                        this.undoTasks = new ObservableCollection<TaskViewModel>(this.redoTasks);
                        this.TasksList = new ObservableCollection<TaskViewModel>(this.redoTasks);
                        var tasks = new List<Task>();
                        var formatter = new XmlSerializer(typeof(List<Task>));
                        foreach (var item in this.TasksList)
                        {
                            tasks.Add(item.Task);
                        }
                        using (var fs = new FileStream("../../DataBase/TasksStorage.xml", FileMode.Open))
                        {
                            formatter.Serialize(fs, tasks);
                        }
                        this.redoTasks = null;
                    },
                    //Если есть что изменить
                    x => this.redoTasks != null
                    ));
        #endregion

    }
}
