using NerdStore.Core.Domainobject;

namespace NerdStore.Catalogo.Domain;

public class Dimemsoes
{

    public decimal Altura { get; private set; }
    public decimal Largura { get; private set; }
    public decimal Profundidade { get; private set; }

    public Dimemsoes(decimal altura, decimal largura, decimal profundidade)
    {
        Validacioes.ValidarSeMenorIgualMinimo(valor: altura, minimo:1, mensagem: $"A altura não deve ser menor ou igual a 0");
        Validacioes.ValidarSeMenorIgualMinimo(valor: largura, minimo:1, mensagem: $"A largura não deve ser menor ou igual a 0");
        Validacioes.ValidarSeMenorIgualMinimo(valor: profundidade, minimo:1, mensagem: $"A profundidade não deve ser menor ou igual a 0");

        Altura = altura;
        Largura = largura;
        Profundidade = profundidade;
    }

    public string DescricaoFormatada()
    {
        return $"LxAxP {Largura} x {Altura} x {Profundidade}";
    }

    public override string ToString()
    {
        return DescricaoFormatada();
    }
}
