namespace TaskList
{
    /// <summary>
    /// Information about the task
    /// </summary>
    public class TaskItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }

        public TaskItem() { }

        public TaskItem(string title, string description, int priority)
        {
            Title = title;
            Description = description;
            Priority = priority;
        }

        public override string ToString()
        {
            return $"{Title}>{Description}>{Priority}";
        }
    }

    
}
