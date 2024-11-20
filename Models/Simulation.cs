public class Simulation {
    private Random random = new Random();
    private Report report = new Report();

    public void RunSimulation(Criminal criminal, CognifyMemory memory) {
        Console.WriteLine($"\nSimulando rehabilitación para {criminal.Name}...");
        Console.WriteLine($"Recuerdo implantado: {memory.Content}");
        Console.WriteLine($"Emoción inducida: {memory.Emotion}");

        int empathyScore = random.Next(50, 100);
        Console.WriteLine($"\nNivel de arrepentimiento generado: {empathyScore}%");

        if (empathyScore > 75) {
            Console.WriteLine($"{criminal.Name} está listo para reintegrarse a la sociedad.");
        } else {
            Console.WriteLine($"{criminal.Name} necesita más sesiones de rehabilitación.");
        }
        report.GenerateReport(criminal, memory, empathyScore);
    }
}
