using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;

namespace TaskList
{
    /// <summary>
    /// Helper function for working with tasks
    /// </summary>
    public static class TaskStructure
    {
        /// <summary>
        /// Function to get saved tasks from a local file
        /// </summary>
        /// <returns></returns>
        public static List<TaskItem> GetSavedTasks()
        {

            List<TaskItem> taskItems = new List<TaskItem>();

            StreamReader sr = new StreamReader("currentTasks.txt");
            var line = sr.ReadLine();
            
            while (line != null)
            {
                taskItems.Add(new TaskItem(line.Split(">")[0], line.Split(">")[1], Convert.ToInt16(line.Split(">")[2])));
                line = sr.ReadLine();
            }
            sr.Close();

            return taskItems;
        }

        public static List<TaskItem> GetFinishedTasks()
        {
            List<TaskItem> taskItems = new List<TaskItem>();

            StreamReader sr = new StreamReader("finishedTasks.txt");
            var line = sr.ReadLine();

            while (line != null)
            {
                taskItems.Add(new TaskItem(line.Split(">")[0], line.Split(">")[1], Convert.ToInt16(line.Split(">")[2])));
                line = sr.ReadLine();
            }
            sr.Close();

            return taskItems;

        }

        public static void FinishTask(string taskToRemove, string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("finishedTasks.txt", true, Encoding.ASCII))
                {
                    sw.WriteLine(taskToRemove);
                };

                StreamReader sr = new StreamReader(path);
                var line = sr.ReadLine();
                var tasks = new List<string>();
                while (line != null)
                {
                    tasks.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();

                using (StreamWriter sw = new StreamWriter(path))
                {
                    foreach (var task in tasks)
                    {
                        if (!(taskToRemove == task))
                        {
                            sw.WriteLine(task);
                        }
                    }
                };

            }
            catch (Exception)
            {
                MessageBox.Show("You didn't select a task to finish");
            }
        }

        public static void RemoveTask(string taskToRemove, string path)
        {
            try
            {
                StreamReader sr = new StreamReader(path);
                var line = sr.ReadLine();
                var tasks = new List<string>();
                while (line != null)
                {
                    tasks.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();

                using (StreamWriter sw = new StreamWriter(path))
                {
                    foreach (var task in tasks)
                    {
                        if (!(taskToRemove == task))
                        {
                            sw.WriteLine(task);
                        }
                    }
                };

            }
            catch (Exception)
            {
                MessageBox.Show("You didn't select a task to remove");
            }
        }
    }
}
