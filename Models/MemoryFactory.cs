public static class MemoryFactory {
    public static CognifyMemory CreateMemory(CrimeType crimeType) {
        var builder = new MemoryBuilder();

        return crimeType switch {
            CrimeType.Violent => builder
                .AddContent("Recuerdo de sufrimiento de la víctima")
                .AddEmotion("Empatía")
                .AddDuration(10)
                .Build(),
            CrimeType.Financial => builder
                .AddContent("Consecuencias económicas negativas")
                .AddEmotion("Remordimiento")
                .AddDuration(5)
                .Build(),
            CrimeType.Hate => builder
                .AddContent("Entendimiento y respeto por la diversidad")
                .AddEmotion("Respeto")
                .AddDuration(7)
                .Build(),
            _ => throw new ArgumentException("Tipo de crimen no válido"),
        };
    }
}
