using SistemaStreaming.Classes;
using SistemaStreaming.Enums;
using SistemaStreaming.Interfaces;

namespace SistemaStreaming.Repositories;

public class RelatoriosRepository(PlayListItem playListItem) : IRelatoriosRepository
{
    public void ListarConteudosPorGenero(GeneroEnum genero)
    {
        var conteudosPorGenero = playListItem.ListaDeItens.OfType<Filme>()
        .Where(filme => filme.Genero == genero).ToList();
        
        conteudosPorGenero.ForEach(conteudosGenero => Console.WriteLine(conteudosPorGenero.ToString()));
    }

    public void ListarConteudosOrdenadosPorAnoRecente()
    {
        var listarPorAno = playListItem.ListaDeItens
        .OrderByDescending(conteudo => conteudo.Ano).ToList();

        listarPorAno.ForEach(conteudo => conteudo.ToString());
    }

    public void GerarProjecaoConteudoNomeAno()
    {
        var projecaoNomeAno = playListItem.ListaDeItens.GroupBy(conteudo => conteudo.Ano).ToList();

        foreach (var ano in projecaoNomeAno)
        {
            Console.WriteLine($"info: {ano.Key}");
            foreach (var conteudo in ano)
                Console.WriteLine($"{conteudo.Titulo}");
        }
    }

    public IEnumerable<IGrouping<int, Conteudo>> AgruparConteudosPorAnoLancamento()
    {
        var agruparConteudosPorAnoLancamento = playListItem.ListaDeItens.GroupBy(conteudo => conteudo.Ano)
        .OrderByDescending(grupoConteudo => grupoConteudo.Key);

        foreach (var grupoConteudo in agruparConteudosPorAnoLancamento)
        {
            Console.WriteLine($"Ano: {grupoConteudo.Key}");
            foreach (var conteudo in grupoConteudo)
                Console.WriteLine($"{conteudo.ToString}");
        }
        return agruparConteudosPorAnoLancamento;
    }
}
