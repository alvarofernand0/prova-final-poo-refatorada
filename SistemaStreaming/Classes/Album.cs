namespace SistemaStreaming.Classes;
public class Album(string nome)
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Nome { get; } = nome;
    public List<Musica> Musicas { get; private protected set; }

    public void AdicionarMusica(Musica musica)
    {
        Musicas.Add(musica);
    }
}
