using SistemaStreaming.Classes;
using SistemaStreaming.Enums;
using SistemaStreaming.Helpers;

namespace SistemaStreaming.Interfaces;
public interface IPlaylist
{
    public void ReproduzirConteudo(EstadoReproducaoEnum estadoReproducao, Notificacao notificacao);
    public bool CalcularIdade();
}
