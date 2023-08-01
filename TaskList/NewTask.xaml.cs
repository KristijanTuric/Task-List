using System;
using System.IO;
using System.Text;
using System.Windows;

namespace TaskList
{
    /// <summary>
    /// Interaction logic for NewTask.xaml
    /// </summary>
    public partial class NewTask : Window
    {
        public NewTask()
        {
            InitializeComponent();
        }

        private void Button_Click_AddTask(object sender, RoutedEventArgs e)
        {
            TaskItem myItem = new TaskItem();
            myItem.Title = Title.Text;
            myItem.Description = Description.Text;
            myItem.Priority = Convert.ToInt16(Priority.Text);

            StreamWriter sw = new StreamWriter("currentTasks.txt", true, Encoding.ASCII);
            sw.WriteLine(myItem.ToString());
            sw.Close();


            this.Close();
        }
    }
}
