using SistemaStreaming.Classes;
using SistemaStreaming.Interfaces;

namespace SistemaStreaming.Repositories;

public class PlayListRepository(PlayListItem playListItem) : IPlaylistRepository
{
    public void AdicionarItemNaPlaylist(Conteudo conteudo)
    {
        if( conteudo != null)
        {
            playListItem.ListaDeItens.Add(conteudo);
        }
        Console.WriteLine($"{conteudo} Inválido! Adicao não efetuada");
        return;
    }

    public void RemoverItemDaPlaylist(Guid idItem)
    {
        var buscarItemPorId = playListItem.ListaDeItens.FirstOrDefault(item => item.Id == idItem);
        if(buscarItemPorId == null)
        {
            Console.WriteLine("Item não Encontrado! Remocao não efetuada");
            return;
        }
        playListItem.ListaDeItens.Remove(buscarItemPorId);
        Console.WriteLine($"{buscarItemPorId.TipoConteudo} - {buscarItemPorId.Titulo} Removido com sucesso!");
    }

    public void ListarItensDaPlaylist()
    {
        if( playListItem.ListaDeItens == null)
        {
            Console.WriteLine($"Playlist {playListItem.Nome} Vazia, Adicione intens para poder exibir!");
        }
        playListItem.ListaDeItens.ForEach(item => Console.WriteLine(item.ToString()));
    }
}
