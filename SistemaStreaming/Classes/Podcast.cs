using SistemaStreaming.Enums;

namespace SistemaStreaming.Classes;

public class Podcast : Conteudo
{
    public Podcast(string titulo, DateTime ano, decimal avaliacao, TimeSpan duracao, ClassificacaoEnum classificacao, Host host, int numeroEpisodio) : base(titulo, ano, avaliacao, duracao, classificacao)
    {
        TipoConteudo = TipoConteudoEnum.Podcast;
        Host = host;
        NumeroEpisodio = numeroEpisodio;
    }

    public Host Host { get; }
    public int NumeroEpisodio { get; private protected set; }

    public override void ReproduzirConteudo()
    {
        Console.WriteLine(Host.Nome);
    }

    public override string ToString() =>
        $"{TipoConteudo} | Ano: {Ano} | Avaliacao: {Avaliacao:f2} | Duracao: {Duracao} | Classificacao: {Classificacao} | Host: {Host.Nome} | {NumeroEpisodio}";
}
