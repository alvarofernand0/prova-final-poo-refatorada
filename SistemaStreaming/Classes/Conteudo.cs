using SistemaStreaming.Enums;

namespace SistemaStreaming.Classes;
public abstract class Conteudo(string titulo, DateTime ano, decimal avaliacao, TimeSpan duracao, ClassificacaoEnum classificacao)
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Titulo { get; private protected set; } = titulo;
    public int Ano { get; init; } = ano.Year;
    public decimal Avaliacao { get; private protected set; } = avaliacao;
    public TimeSpan Duracao { get; init; } = duracao;
    public ClassificacaoEnum Classificacao { get; private protected set; } = classificacao;
    public TipoConteudoEnum TipoConteudo { get; private protected set; }

    public abstract void ReproduzirConteudo();
    public abstract override string ToString();
}
