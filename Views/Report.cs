public class Report {
    public void GenerateReport(Criminal criminal, CognifyMemory memory, int empathyScore) {
        Console.WriteLine("\n--- Reporte Final ---");
        Console.WriteLine($"Nombre: {criminal.Name}");
        Console.WriteLine($"Crimen: {criminal.Crime}");
        Console.WriteLine($"Nivel de peligrosidad: {criminal.DangerLevel}");
        Console.WriteLine($"Motivación: {criminal.Motivation}");
        Console.WriteLine($"Método elegido: {criminal.ChosenMethod}");
        Console.WriteLine($"Recuerdo implantado: {memory.Content}");
        Console.WriteLine($"Emoción inducida: {memory.Emotion}");
        Console.WriteLine($"Nivel de arrepentimiento: {empathyScore}%");
        Console.WriteLine("---------------------\n");
    }
}
