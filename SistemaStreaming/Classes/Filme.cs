using SistemaStreaming.Enums;

namespace SistemaStreaming.Classes;

public class Filme : Conteudo
{
    public Filme(string titulo, DateTime ano, decimal avaliacao, TimeSpan duracao, ClassificacaoEnum classificacao, Diretor diretor, GeneroEnum genero) : base(titulo, ano, avaliacao, duracao, classificacao)
    {
        TipoConteudo = TipoConteudoEnum.Filme;
        Diretor = diretor;
        Genero = genero;
    }
    
    public Diretor Diretor { get; }
    public GeneroEnum Genero { get; }

    public override void ReproduzirConteudo()
    {
        Console.WriteLine(Diretor.Nome);
    }

    public override string ToString() =>
        $"{TipoConteudo} | Ano: {Ano} | Avaliacao: {Avaliacao:f2} | Duracao: {Duracao} | Classificacao: {Classificacao} | Diretor: {Diretor} Genero: {Genero}";
}
