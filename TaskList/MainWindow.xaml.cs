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
            this.DataContext = new TaskStructureViewModel();
        }

        private void Button_Click_NewTask(object sender, RoutedEventArgs e)
        {            
            NewTask newTask = new();
            newTask.ShowDialog();

            this.DataContext = new TaskStructureViewModel();
        }

        private void Button_Click_Finished(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Remove(object sender, RoutedEventArgs e)
        {

        }
    }
}
