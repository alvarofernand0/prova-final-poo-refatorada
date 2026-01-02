using SistemaStreaming.Enums;
using SistemaStreaming.Interfaces;

namespace SistemaStreaming.Helpers;

public class Notificacao(string mensagem, TipoNotificacaoEnum tipoNotificacao) : INotificacao
{
    public string Mensagem { get ; } = mensagem;
    public TipoNotificacaoEnum TipoNotificacao { get; } = tipoNotificacao;
    public List<Notificacao> ListaNotificacoes = [];

    public void AdicionarNotificacao(string mensagem, TipoNotificacaoEnum tipoNotificacao)
    {
        Notificacao notificacao = new(mensagem, tipoNotificacao);
        ListaNotificacoes.Add(notificacao);
    }

    public void ExibirNotificacao()
    {
        if(ListaNotificacoes.Count > 0)
            Console.WriteLine(ListaNotificacoes.LastOrDefault());
    }

    public void ExibirTodasNotificacoes()
    {
        if(ListaNotificacoes.Count > 0)
        {
            ListaNotificacoes.ForEach(notificacao =>
            Console.WriteLine($"{notificacao.TipoNotificacao} - {notificacao.Mensagem}"));
        }
    }

    public bool ExisteNotificacao() =>
        ListaNotificacoes != null;

    public void LimparNotificacoes() =>
        ListaNotificacoes.Clear();

    public void Notificar()
    {
        if (ExisteNotificacao())
        {
            ExibirNotificacao();
            ExibirTodasNotificacoes();
            LimparNotificacoes();
        }
    }
}
