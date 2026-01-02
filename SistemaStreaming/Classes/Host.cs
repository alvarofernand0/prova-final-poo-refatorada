namespace SistemaStreaming.Classes;
public class Host(string nome)
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Nome { get; } = nome;
}
