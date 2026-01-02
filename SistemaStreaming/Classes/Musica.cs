using SistemaStreaming.Enums;

namespace SistemaStreaming.Classes;

public class Musica : Conteudo
{
    public Musica(string titulo, DateTime ano, decimal avaliacao, TimeSpan duracao, ClassificacaoEnum classificacao, Artista artista, Album album) : base(titulo, ano, avaliacao, duracao, classificacao)
    {
        TipoConteudo = TipoConteudoEnum.Musica;
        Artista = artista;
        Album = album;
    }

    public Artista Artista { get; }
    public Album Album { get; }

    public override void ReproduzirConteudo()
    {
        Console.WriteLine(Artista.Nome);
    }

    public override string ToString() =>
        $"{TipoConteudo} | Ano: {Ano} | Avaliacao: {Avaliacao:f2} | Duracao: {Duracao} | Classificacao: {Classificacao} | Artista: {Artista.Nome} | Album: {Album.Nome}";
}
