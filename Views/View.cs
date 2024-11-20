public class View {
    public void DisplayMenu() {
    Console.WriteLine("\n--- Menú Principal ---");
    Console.WriteLine("1. Sentencia Tradicional");
    Console.WriteLine("2. Rehabilitación Acelerada (Cognify)");
    Console.WriteLine("3. Ver Historial de Criminales");
    Console.WriteLine("4. Salir");
    Console.WriteLine("----------------------");
}

    public int GetUserChoice() {
        Console.Write("Seleccione una opción: ");
        return int.Parse(Console.ReadLine());
    }

    public Criminal GetCriminalData() {
    Console.Write("Ingrese el nombre del criminal: ");
    string name = Console.ReadLine();

    Console.WriteLine("Seleccione el tipo de crimen:");
    Console.WriteLine("1. Violento");
    Console.WriteLine("2. Financiero");
    Console.WriteLine("3. De Odio");
    int crimeChoice = int.Parse(Console.ReadLine());
    CrimeType crime = (CrimeType)(crimeChoice - 1);

    Console.WriteLine("Seleccione el nivel de peligrosidad:");
    Console.WriteLine("1. Bajo");
    Console.WriteLine("2. Medio");
    Console.WriteLine("3. Alto");
    string dangerLevel = Console.ReadLine() switch {
        "1" => "Bajo",
        "2" => "Medio",
        "3" => "Alto",
        _ => "Desconocido"
    };

    Console.WriteLine("Seleccione la motivación del crimen:");
    Console.WriteLine("1. Económica");
    Console.WriteLine("2. Emocional");
    Console.WriteLine("3. Ideológica");
    string motivation = Console.ReadLine() switch {
        "1" => "Económica",
        "2" => "Emocional",
        "3" => "Ideológica",
        _ => "Desconocida"
    };

    return new Criminal {
        Name = name,
        Crime = crime,
        DangerLevel = dangerLevel,
        Motivation = motivation
    };
}
}
