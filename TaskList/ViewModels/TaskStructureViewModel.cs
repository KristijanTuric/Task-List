using System.Collections.ObjectModel;
using System.Linq;

namespace TaskList
{
    public class TaskStructureViewModel : BaseViewModel
    {
        #region Public Properties

        public ObservableCollection<TaskItemViewModel> Tasks { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public TaskStructureViewModel()
        {
            this.Tasks = new ObservableCollection<TaskItemViewModel>(TaskStructure.GetSavedTasks().Select(task => new TaskItemViewModel(
                task.Title, task.Description, task.Priority)));
        }

        #endregion

        public void RefreshTasks()
        {
            this.Tasks = new ObservableCollection<TaskItemViewModel>(TaskStructure.GetSavedTasks().Select(task => new TaskItemViewModel(
                task.Title, task.Description, task.Priority)));
        }
    }
}
