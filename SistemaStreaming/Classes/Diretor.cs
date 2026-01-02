namespace SistemaStreaming.Classes;
public class Diretor(string nome)
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string Nome { get; init; } = nome;
}
