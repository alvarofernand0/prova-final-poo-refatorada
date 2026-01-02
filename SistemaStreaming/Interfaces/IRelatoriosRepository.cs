using SistemaStreaming.Classes;
using SistemaStreaming.Enums;

namespace SistemaStreaming.Interfaces;
public interface IRelatoriosRepository
{
    public void ListarConteudosPorGenero(GeneroEnum genero);

    public void ListarConteudosOrdenadosPorAnoRecente();

    public void GerarProjecaoConteudoNomeAno();

    public IEnumerable<IGrouping<int, Conteudo>> AgruparConteudosPorAnoLancamento();
}
