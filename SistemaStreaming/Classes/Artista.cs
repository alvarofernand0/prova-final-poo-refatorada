namespace SistemaStreaming.Classes;
public class Artista(string nome)
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Nome { get; init;} = nome;
}
