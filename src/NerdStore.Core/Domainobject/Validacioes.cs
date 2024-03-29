﻿using System.Text.RegularExpressions;
namespace NerdStore.Core.Domainobject;

public class Validacioes
{
    public static void ValidarSeIgual(object object1, object object2, string mensagem)
    {
        if (!object1.Equals(object2))
        {
            throw new DomainException(mensagem);
        }
    }

    public static void ValidarSeDiferente(object object1, object object2, string mensagem)
    {
        if (object1.Equals(object2))
        {
            throw new DomainException(mensagem);
        }
    }

    public static void ValidarCaracteres(string valor, int maximo, string mensagem)
    {
        var length = valor.Trim().Length;
        if (length > maximo)
        {
            throw new DomainException(mensagem);
        }
    }

    public static void ValidarCaracteres(string valor, int maximo, int minimo, string mensagem)
    {
        var length = valor.Trim().Length;
        if (length < maximo || length > maximo)
        {
            throw new DomainException(mensagem);
        }
    }

    public static void ValidarExpressao(string pattern, string valor, string mensagem)
    {
        var ragex = new Regex(pattern);
        if (ragex.IsMatch(valor))
        {
            throw new DomainException(mensagem);
        }
    }

    public static void ValidarSeVazio(string valor, string mensagem)
    {
        if (valor == null || valor.Trim().Length == 0)
        {
            throw new DomainException(mensagem);
        }
    }

    public static void ValidarSeNullo(string valor, string mensagem)
    {
        if (valor == null)
        {
            throw new DomainException(mensagem);
        }
    }

    public static void ValidarMinimoMaximo(double valor, double minimo, double maximo, string mensagem)
    {
        if (valor < minimo || valor > maximo)
        {
            throw new DomainException(mensagem);
        }
    }

    public static void ValidarMinimoMaximo(float valor, float minimo, float maximo, string mensagem)
    {
        if (valor < minimo || valor > maximo)
        {
            throw new DomainException(mensagem);
        }
    }

    public static void ValidarMinimoMaximo(int valor, int minimo, int maximo, string mensagem)
    {
        if (valor < minimo || valor > maximo)
        {
            throw new DomainException(mensagem);
        }
    }

    public static void ValidarMinimoMaximo(long valor, long minimo, long maximo, string mensagem)
    {
        if (valor < minimo || valor > maximo)
        {
            throw new DomainException(mensagem);
        }
    }

    public static void ValidarSeMenorIgualMinimo(long valor, long minimo, string mensagem)
    {
        if (valor <= minimo)
        {
            throw new DomainException(mensagem);
        }
    }

    public static void ValidarSeMenorIgualMinimo(decimal valor, decimal minimo, string mensagem)
    {
        if (valor <= minimo)
        {
            throw new DomainException(mensagem);
        }
    }

    public static void ValidarSeMenorIgualMinimo(int valor, int minimo, string mensagem)
    {
        if (valor <= minimo)
        {
            throw new DomainException(mensagem);
        }
    }

    public static void ValidarSeMenorIgualMinimo(float valor, float minimo, string mensagem)
    {
        if (valor <= minimo)
        {
            throw new DomainException(mensagem);
        }
    }

    public static void ValidarSeFalso(bool boolvalor, string mensagem)
    {
        if (boolvalor)
        {
            throw new DomainException(mensagem);
        }
    }

    public static void ValidarSeVerdadeiro(bool boolvalor, string mensagem)
    {
        if (!boolvalor)
        {
            throw new DomainException(mensagem);
        }
    }

}
