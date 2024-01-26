using NerdStore.Core.Domainobject;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;

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
    public Dimemsoes Dimemsoes { get; private set; }
    public Categoria? Categoria { get; set; }

    public Producto(string nome, string descricao, bool ativo, decimal valor,Guid categoriaId, DateTime dataCadastro, string imagem, Dimemsoes dimemsoes )
    {
        CategoriaId = categoriaId;
        Nome = nome;
        Descricao = descricao;
        Ativo = ativo;
        Valor = valor;
        DataCadastro = dataCadastro;
        Imagem = imagem;
        Dimemsoes = dimemsoes;

        Validar();
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
        Validacioes.ValidarSeVazio(valor: descricao, mensagem: "Este campo não deve estar vazio");
        Descricao = descricao;
    }

    public void DebitarEstoque(int quantidade)
    {
        if (quantidade < 0) quantidade *= -1;
        if (!PossuiEstoque(quantidade)) 
            throw new DomainException(message:"Estoque insuficiente");
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
        Validacioes.ValidarSeVazio(valor: Nome, mensagem: "Este campo não deve estar vazio");
        Validacioes.ValidarSeVazio(valor: Descricao, mensagem: "Este campo não deve estar vazio");
        Validacioes.ValidarSeDiferente(object1: CategoriaId, object2: Guid.Empty, mensagem: "O campo  categoria do producto não deve estar vazio");
        Validacioes.ValidarSeMenorIgualMinimo(Valor, minimo:0, mensagem: "Este campo, o seu valor nao deve ser menor ou igual a 0");
        Validacioes.ValidarSeVazio(valor: Imagem, mensagem: "Este campo não deve estar vazio");
    }
}


