namespace TaskTracker;



static class Program
{
   public class Task
    {
        public string Title { get; set; }
        public Task(string title)
        {
            Title = title;
        }
    }

    public class TaskCreation
    {
        public static Task CreateTask()
        {
            //prompt the user to enter a title
            Console.WriteLine("Enter a title for the task.");

            //read user input
            string title = Console.ReadLine();
            //create a new task object with the entered title
            Task task = new Task(title);

            return task;
        }
    }
    [STAThread]

    
    static void Main()
        {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());

        {
            List<Task> taskList = new List<Task>();

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Display tasks");
                Console.WriteLine("2. Add a new task");
                Console.WriteLine("3. Delete a task");
                Console.WriteLine("4. Exit");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Current Tasks\n");
                    foreach (Task task in taskList)
                    {
                        Console.WriteLine(task.Title);
                    }
                }
                else if (choice == 2)
                {
                    //create a new task
                    Task newTask = TaskCreation.CreateTask();
                    taskList.Add(newTask);

                    //update task list after new task made
                    Console.WriteLine("\nUpdated Tasks: ");
                    foreach (Task task in taskList)
                    {
                        Console.WriteLine(task.Title);
                    }

                }
               /* I DO NOT LIKE USING AN IDEX TO FIND TASK, add search feature so it can delete by name?
                
                */
                else if (choice == 3)
                {
                    // Delete a task
                    Console.WriteLine("Enter the index of the task to delete:");
                    int index = int.Parse(Console.ReadLine());

                    if (index >= 0 && index < taskList.Count)
                    {
                        taskList.RemoveAt(index);
                        Console.WriteLine("Task deleted successfully!\n");
                    }
                    else
                    {
                        Console.WriteLine("Invalid index. Please try again.\n");
                    }
                }
                else if (choice == 4)
                {
                    // Exit the program
                    break;
                }
            }
            
            
        
        
        }
    }    
}