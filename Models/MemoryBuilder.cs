public class MemoryBuilder {
    private CognifyMemory memory = new CognifyMemory();

    public MemoryBuilder AddContent(string content) {
        memory.Content = content;
        return this;
    }

    public MemoryBuilder AddEmotion(string emotion) {
        memory.Emotion = emotion;
        return this;
    }

    public MemoryBuilder AddDuration(int duration) {
        memory.Content += $" (Duración percibida: {duration} años)";
        return this;
    }

    public CognifyMemory Build() {
        return memory;
    }
}
