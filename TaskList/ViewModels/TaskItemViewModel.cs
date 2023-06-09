namespace TaskList
{
    public class TaskItemViewModel : BaseViewModel
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }

        public TaskItemViewModel(string _title, string _description, int _priority) 
        {
            Title = _title;
            Description = _description;
            Priority = _priority;
        }

    }
}
