
namespace cursoCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Tasks;
            Console.Write("¿Cuántas tareas deseas ingresar? ");

            int taskCount = int.Parse(Console.ReadLine());
            Tasks = new string[taskCount];
            for (int i = 0; i < taskCount; i++)
            {
                Console.Write($"Ingresa la tarea {i + 1}: ");
                Tasks[i] = Console.ReadLine();
            }

            Console.Write("\n");
            Console.Write("\n");
            Console.Write("\n");
            foreach (string task in Tasks)
            {
                Console.WriteLine($"Tarea: {task}");
            }
            Console.WriteLine("Presiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}
