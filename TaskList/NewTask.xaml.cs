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
using System.Windows.Shapes;

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
            MyItem myItem = new MyItem();
            myItem.Title = Title.Text;
            myItem.Description = Description.Text;
            myItem.Priority = (int)Priority.SelectedItem;


            this.Close();
        }
    }
}
