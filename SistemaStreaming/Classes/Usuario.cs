namespace SistemaStreaming.Classes;
public class Usuario(string nome, int idade)
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Nome { get; } = nome;
    public int Idade { get; init; } = idade;
}
