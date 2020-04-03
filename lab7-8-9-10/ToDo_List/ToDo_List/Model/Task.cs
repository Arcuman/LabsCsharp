using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_List
{
    [Serializable]
    public class Task
    {
        #region Public Properties
        /// <summary>
        /// Загаловок
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Описание задачи
        /// </summary>
        public string MainInfo { get; set; }

        /// <summary>
        /// Дата начала
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// Приоритет
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// Категория
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// Категория
        /// </summary>
        public int Status { get; set; }

        #endregion

        #region Constructor
        public Task() {
            this.Title = "";
            this.Category = "";
            this.MainInfo = "";
            this.StartDate = "";
            this.Priority = 0;
            this.Status = 0;
        }
        public Task(string title, string category, string mainInfo, string startDate, int priority,int status)
        {
            this.Title = title;
            this.Category = category;
            this.MainInfo = mainInfo;
            this.StartDate = startDate;
            this.Priority = priority;
            this.Status = status;
        }
        public Task(Task task)
        {
            if (task != null)
            {
                this.Title = task.Title;
                this.Category = task.Category;
                this.MainInfo = task.MainInfo;
                this.StartDate = task.StartDate;
                this.Priority = task.Priority;
                this.Status = task.Status;
            }
        }

        #endregion
    }
}
