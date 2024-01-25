using NerdStore.Core.Domainobject;

namespace NerdStore.Catalogo.Domain;

public class Producto : Entity, IAggregateRoot
{
    public Guid CategoriaId { get; private set; }
    public string Nome { get; private set; } = string.Empty;
    public string Descricao { get; private set; } = string.Empty;
    public bool Ativo { get; private set; }
    public decimal Valor { get; private set; }
    public DateTime DataCadastro { get; private set; }
    public string Imagem { get; private set; } = string.Empty;
    public int Estoque { get; private set; }
    public Categoria? Categoria { get; set; }

    public Producto(string nome, string descricao, bool ativo, decimal valor,Guid categoriaId, DateTime dataCadastro, string imagem)
    {
        CategoriaId = categoriaId;
        Nome = nome;
        Descricao = descricao;
        Ativo = ativo;
        Valor = valor;
        DataCadastro = dataCadastro;
        Imagem = imagem;
    } 
    
    private void Ativar() => Ativo = true;

    private void Desativar() => Ativo = false;

    public void AlterarCategoria(Categoria categoria)
    {
       Categoria = categoria;
       CategoriaId = categoria.Id;
    }

    public void AlterarDescricao(string descricao)
    {
        Descricao = descricao;
    }

    public void DebitarEstoque(int quantidade)
    {
        if (quantidade < 0) quantidade *= -1;
        Estoque -= quantidade;
    }

    public void ReporEstoque(int quantidade)
    {
        Estoque += quantidade;
    }

    public bool PossuiEstoque(int quantidade)
    {
        return Estoque >= quantidade;
    }

    public void Validar()
    {

    }
}

public class Categoria : Entity
{
    public string Nome { get; private set; } = string.Empty;
    public int Codigo { get; private set; }

  public Categoria(string nome, int codigo)
    {
        Nome = nome;
        Codigo = codigo;
    }

    public override string ToString()
    {
        return $"{Nome} - {Codigo}"; 
    }
}


