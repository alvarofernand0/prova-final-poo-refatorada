using SistemaStreaming.Enums;

namespace SistemaStreaming.Interfaces;

public interface INotificacao
{
    public void AdicionarNotificacao(string mensagem, TipoNotificacaoEnum tipoNotificacao);

    public void ExibirNotificacao();

    public void ExibirTodasNotificacoes();
    
    public bool ExisteNotificacao();

    public void LimparNotificacoes();
}
