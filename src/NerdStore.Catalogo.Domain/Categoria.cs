using NerdStore.Core.Domainobject;

namespace NerdStore.Catalogo.Domain;

public class Categoria : Entity
{
    public string Nome { get; private set; } = string.Empty;
    public int Codigo { get; private set; }

  public Categoria(string nome, int codigo)
    {
        Nome = nome;
        Codigo = codigo;

        Validar();
    }

    public override string ToString()
    {
        return $"{Nome} - {Codigo}"; 
    }

    public void Validar()
    {
        Validacioes.ValidarSeVazio(valor: Nome, mensagem: "Este campo não deve estar vazio");
        Validacioes.ValidarSeIgual(object1: Codigo, object2: 0, mensagem: "Este campo, o seu valor não deve ser 0");
    }
}


