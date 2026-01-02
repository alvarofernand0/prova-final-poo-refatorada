using SistemaStreaming.Enums;
using SistemaStreaming.Interfaces;
using SistemaStreaming.Helpers;

namespace SistemaStreaming.Classes;
public class PlayListItem(Conteudo conteudo, Guid idConteudo, Usuario usuario, Guid idUsuario, string nome) : IPlaylist
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Nome { get; private protected set; } = nome;
    public Conteudo Conteudo { get; } = conteudo;
    public Guid IdConteudo { get; } = idConteudo;
    public Usuario Usuario { get; } = usuario;
    public Guid IdUsuario { get;} = idUsuario;
    public List<Conteudo> ListaDeItens = new();
    public EstadoReproducaoEnum EstadoReproducao { get; private protected set; } = EstadoReproducaoEnum.Inativo;

    public bool CalcularIdade() =>
        Usuario.Idade >= ((int)Conteudo.Classificacao);

    public virtual void ReproduzirConteudo(EstadoReproducaoEnum estadoReproducao, Notificacao notificacao)
    {
        if(EstadoReproducao == EstadoReproducaoEnum.Reproduzir)
        {
            if (!CalcularIdade())
            {
                notificacao.AdicionarNotificacao($"{Conteudo.TipoConteudo} - {Conteudo.Titulo} Não pode ser reproduzido, Usuario {Usuario.Nome} Não possui idade sufuciente", TipoNotificacaoEnum.Erro);
                notificacao.Notificar();
            }
            notificacao.AdicionarNotificacao($"{Conteudo.TipoConteudo} - {Conteudo.Titulo} Pode ser reproduzido", TipoNotificacaoEnum.Sucesso);
            Conteudo.ReproduzirConteudo();
        }

        if(estadoReproducao == EstadoReproducaoEnum.Pausar)
        {
            notificacao.AdicionarNotificacao("", TipoNotificacaoEnum.Sucesso);
            notificacao.Notificar();
            EstadoReproducao = EstadoReproducaoEnum.Pausar;
        }
    }
}
