
namespace cursoCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Finalizar = false;
            List<string> Tasks = new List<string>();
            while (Finalizar)
            { 
                for (int i = 0; i < taskCount; i++)
                {
                    Console.Write($"Ingresa la tarea {i + 1}: ");
                    Tasks[i] = Console.ReadLine();
                }

                Console.Write("\n");
                Console.Write("\n");
                Console.Write("\n");
                if (Tasks.Count > 0)
                {
                    foreach (string task in Tasks)
                    {
                        Console.WriteLine($"Tarea: {task}");
                    }

                }
                else
                {
                    Console.WriteLine("No hay tareas");
                }
                var tecla = Console.ReadKey(true).Key;
                if (tecla == ConsoleKey.Escape)
                {
                    Finalizar = false;
                }

            }
            Console.WriteLine("Fin del programa");
        }


    }
}
