using System;
using System.Collections.Generic;
using System.IO;

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

            StreamReader sr = new StreamReader("C:\\Users\\Kiki\\Desktop\\Code\\c# projects\\TaskList\\TaskList\\currentTasks.txt");
            var line = sr.ReadLine();
            
            while (line != null)
            {
                taskItems.Add(new TaskItem(line.Split(">")[0], line.Split(">")[1], Convert.ToInt16(line.Split(">")[2])));
                line = sr.ReadLine();
            }
            sr.Close();

            return taskItems;

        }

        public static void RefreshTasks(TaskStructureViewModel taskData)
        {
            taskData.RefreshTasks();
        }
    }
}
