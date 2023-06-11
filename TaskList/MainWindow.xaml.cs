using System.Windows;

namespace TaskList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            refreshDataContext();

        }

        private TaskStructureViewModel? _dataContext;

        private void Button_Click_NewTask(object sender, RoutedEventArgs e)
        {            
            NewTask newTask = new();
            newTask.ShowDialog();

            refreshDataContext();
        }

        private void refreshDataContext()
        {
            _dataContext = new TaskStructureViewModel();
            this.DataContext = _dataContext;
        }

        private void Button_Click_Finished(object sender, RoutedEventArgs e)
        {
            TaskStructure.FinishTask(currentTasks.SelectedItem.ToString(), "C:\\Users\\Kiki\\Desktop\\Code\\c# projects\\TaskList\\TaskList\\currentTasks.txt");

            refreshDataContext();
        }

        private void Button_Click_Remove(object sender, RoutedEventArgs e)
        {

            TaskStructure.RemoveTask(finishedTasks.SelectedItem.ToString(), "C:\\Users\\Kiki\\Desktop\\Code\\c# projects\\TaskList\\TaskList\\finishedTasks.txt");

            refreshDataContext();
        }
    }
}
