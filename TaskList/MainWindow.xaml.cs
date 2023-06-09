using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
        }

        private void Button_Click_NewTask(object sender, RoutedEventArgs e)
        {
            //currentTasks.Items.Add(new MyItem { Title = "Test", Description = "Not here", Priority = 3 });
            NewTask newTask = new NewTask();
            newTask.ShowDialog();
        }

        private void Button_Click_Finished(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Remove(object sender, RoutedEventArgs e)
        {

        }
    }
}
