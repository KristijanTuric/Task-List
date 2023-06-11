using System.Collections.ObjectModel;
using System.Linq;

namespace TaskList
{
    public class TaskStructureViewModel : BaseViewModel
    {
        #region Public Properties

        public ObservableCollection<TaskItemViewModel> Tasks { get; set; }
        public ObservableCollection<TaskItemViewModel> FinishedTasks { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public TaskStructureViewModel()
        {
            this.Tasks = new ObservableCollection<TaskItemViewModel>(TaskStructure.GetSavedTasks().Select(task => new TaskItemViewModel(
                task.Title, task.Description, task.Priority)));

            this.FinishedTasks = new ObservableCollection<TaskItemViewModel>(TaskStructure.GetFinishedTasks().Select(task => new TaskItemViewModel(
                task.Title, task.Description, task.Priority)));
        }

        #endregion
    }
}
