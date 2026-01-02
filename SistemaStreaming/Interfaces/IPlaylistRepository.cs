using SistemaStreaming.Classes;

namespace SistemaStreaming.Interfaces;

public interface IPlaylistRepository
{
    public void AdicionarItemNaPlaylist(Conteudo conteudo);
    public void RemoverItemDaPlaylist(Guid idConteudo);
    public void ListarItensDaPlaylist();
}
