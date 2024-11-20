public class Controller {
    private readonly View view = new View();
    private readonly Simulation simulation = new Simulation();

    // Lista global para el historial de criminales
    public static List<Criminal> CriminalRegistry = new List<Criminal>();

    public void Start() {
        bool keepRunning = true;

        while (keepRunning) {
            view.DisplayMenu();
            int choice = view.GetUserChoice();

            if (choice == 2) {
                // Proceso de rehabilitación
                Criminal criminal = view.GetCriminalData();
                CognifyMemory memory = MemoryFactory.CreateMemory(criminal.Crime);
                simulation.RunSimulation(criminal, memory);

                // Registrar criminal en el historial
                CriminalRegistry.Add(criminal);
            } else if (choice == 1) {
                // Sentencia tradicional
                Criminal criminal = view.GetCriminalData();
                criminal.ChosenMethod = "Sentencia Tradicional";
                CriminalRegistry.Add(criminal);

                Console.WriteLine($"{criminal.Name} cumplirá una sentencia tradicional.");
            } else if (choice == 3) {
                // Mostrar historial
                if (CriminalRegistry.Count == 0) {
                    Console.WriteLine("No se han registrado criminales aún.");
                } else {
                    Console.WriteLine("\nHistorial de criminales registrados:");
                    foreach (var c in CriminalRegistry) {
                        Console.WriteLine($"Nombre: {c.Name}, Crimen: {c.Crime}, Método: {c.ChosenMethod}, Peligrosidad: {c.DangerLevel}, Motivación: {c.Motivation}");
                    }
                }
            } else if (choice == 4) {
                // Salir del programa
                keepRunning = false;
                Console.WriteLine("Gracias por usar Cognify. ¡Hasta luego!");
            } else {
                Console.WriteLine("Opción no válida. Intente nuevamente.");
            }

            if (keepRunning) {
                Console.WriteLine("\n¿Desea realizar otra acción? (s/n): ");
                string userResponse = Console.ReadLine()?.ToLower();
                keepRunning = userResponse == "s";
            }
        }
    }
}
