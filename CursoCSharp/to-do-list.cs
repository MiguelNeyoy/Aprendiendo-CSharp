using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp
{
    internal class ToDoList
    {
        public static void ListTask()
        {
            List<string> tasks = new List<string>();
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("To-Do List");
                Console.WriteLine("1. Agregar tarea");
                Console.WriteLine("2. Listar tareas");
                Console.WriteLine("3. Eliminar tarea");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                string? option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Ingrese la nueva tarea: ");
                        string? newTask = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(newTask))
                            tasks.Add(newTask);
                        break;
                    case "2":
                        Console.WriteLine("\nTareas:");
                        if (tasks.Count == 0)
                            Console.WriteLine("No hay tareas.");
                        else
                            for (int i = 0; i < tasks.Count; i++)
                                Console.WriteLine($"{i + 1}. {tasks[i]}");
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("\nTareas:");
                        for (int i = 0; i < tasks.Count; i++)
                            Console.WriteLine($"{i + 1}. {tasks[i]}");
                        Console.Write("Ingrese el número de la tarea a eliminar: ");
                        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
                            tasks.RemoveAt(index - 1);
                        else
                            Console.WriteLine("Número inválido.");
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        Console.ReadKey();
                        break;
                }
            }
            Console.WriteLine("Fin del programa.");
        }
    }
    
}
