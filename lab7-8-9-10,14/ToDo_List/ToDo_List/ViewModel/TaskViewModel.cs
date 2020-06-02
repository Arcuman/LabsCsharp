using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ToDo_List
{
    public class TaskViewModel : ViewModelBase, IDataErrorInfo
    {
        #region Privite Members

        private bool isEnabled;

        #endregion

        #region Public Properties
        /// <summary>
        /// Задача
        /// </summary>


        /// <summary>
        /// Заголовок задачи
        /// </summary>
        [Required(ErrorMessage = "Title is required")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Недопустимая длина заголовка")]
        public string Title
        {
            get => this.Task.Title;
            set
            {
                this.Task.Title = value;
                this.OnPropertyChanged(nameof(this.Title));
            }
        }

        /// <summary>
        /// Описание задачи
        /// </summary>
        public string MainInfo
        {
            get => this.Task.MainInfo;
            set
            {
                this.Task.MainInfo = value;
                this.OnPropertyChanged(nameof(this.MainInfo));
            }
        }
        /// <summary>
        /// Дата начала
        /// </summary>
        public string StartDate
        {
            get => this.Task.StartDate;
            set
            {
                this.Task.StartDate = value;
                this.OnPropertyChanged(nameof(this.StartDate));
            }
        }
        /// <summary>
        /// Приоритет задачи
        /// </summary>
        public int Priority
        {
            get => this.Task.Priority;
            set
            {
                this.Task.Priority = value;
                this.OnPropertyChanged(nameof(this.Priority));
            }
        }
        /// <summary>
        /// Категория задачи
        /// </summary>
        public string Category
        {
            get => this.Task.Category;
            set
            {
                if (value == "" || value == null)
                {
                    throw new ArgumentException("Выберите категорию");
                }
                else
                {
                    this.Task.Category = value;
                    OnPropertyChanged(nameof(this.Category));
                }
            }
        }
        /// <summary>
        /// Статус задачи
        /// </summary>
        public int Status
        {
            get => this.Task.Status;
            set
            {
                if ( value == null)
                    throw new ArgumentException("Выберите статус");
                else
                {
                    Task.Status = value;
                    OnPropertyChanged(nameof(this.Status));
                }
            }
        }
        /// <summary>
        /// Свойство отвечающие за возможность доступа к textBox
        /// </summary>
        public bool IsEnabled
        {
            get => this.isEnabled;
            set
            {
                this.isEnabled = value;
                this.OnPropertyChanged(nameof(this.IsEnabled));
            }
        }

        public bool IsValid { get; set; }
        /// <summary>
        /// Возможные приоритеты
        /// </summary>
        public ObservableCollection<PriorityContainer> PriorityList { get; set; }

        /// <summary>
        /// Возможные состояния
        /// </summary>
        public ObservableCollection<PriorityContainer> StatusList { get; set; }

        public Task Task { get; set; }


        #endregion

        #region Constructors
        public TaskViewModel(Task task)
        {
            this.IsEnabled = false;
            this.Task = task;
            this.PriorityList = new ObservableCollection<PriorityContainer>()
        {
             new PriorityContainer(){ Id = 1,Name="Высокий"}
            ,new PriorityContainer(){ Id = 2,Name="Средний"}
            ,new PriorityContainer(){ Id = 3, Name="Низкий"}
        };
            this.StatusList = new ObservableCollection<PriorityContainer>()
        {
             new PriorityContainer(){Id = 3, Name= "Выполнена"}
            ,new PriorityContainer(){Id = 2, Name= "Отложена"}
            ,new PriorityContainer(){Id = 1, Name= "Невыполнена"}
        };

        }
        public TaskViewModel(TaskViewModel taskView)
        {
            this.IsEnabled = false;
            this.Task = new Task(task: taskView.Task);
        }

        #endregion

        #region Validation

        public string Error => null;

        public string this[string name]
        {
            get
            {
                string result = null;

                switch (name)
                {
                    case ("Title"):
                    {
                        if (this.Title == "" || this.Title == null)
                        {
                            result = "Заголовок должен быть заполнен";
                        }
                        break;
                    }
                    case ("Category"):
                    {
                        if (this.Category == "" || this.Category == null)
                        {
                            result = "Категория должна быть заполнена";
                        }
                        break;
                    }
                    case ("StartDate"):
                    {
                        if (this.StartDate == null || this.StartDate == "")
                        {
                            result = "Дата должна быть выбрана";
                        }
                        break;
                    }
                    case ("Priority"):
                    {
                        if (this.Priority == 0)
                        {
                            result = "Приоритет должен быть выбран";
                        }
                        break;
                    }
                    case ("Status"):
                    {
                        if ( this.Status == 0)
                        {
                            result = "Статус должен быть выбран";
                        }
                        break;
                    }
                    case ("MainInfo"):
                    {
                        if (this.MainInfo == null || this.MainInfo == "")
                        {
                            result = "Статус должен быть выбран";
                        }
                        break;
                    }
                }
                if (result != null)
                {
                    this.IsValid = false;
                }
                else
                {
                    this.IsValid = true;
                }

                return result;
            }
        }

        #endregion

        #region Helpers
        /// <summary>
        /// Изменить значения task копирование свойств
        /// </summary>
        /// <param name="task"></param>
        public void Change(Task task)
        {
            this.Title = task.Title;
            this.Category = task.Category;
            this.MainInfo = task.MainInfo;
            this.StartDate = task.StartDate;
            this.Priority = task.Priority;
            this.Status = task.Status;
        }

        /// <summary>
        /// Представление задачи 
        /// </summary>
        /// <returns></returns>
        public override string ToString() => this.Title;
        #endregion
    }
}
