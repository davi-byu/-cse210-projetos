using System;
using System.Collections.Generic;

public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavras;

    public Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;
        _palavras = new List<Palavra>();

        string[] palavras = texto.Split(' ');

        foreach (string palavra in palavras)
        {
            _palavras.Add(new Palavra(palavra));
        }
    }

    public string ObterExibirTexto()
    {
        string texto = _referencia.ObterTexto() + " ";

        foreach (Palavra palavra in _palavras)
        {
            texto += palavra.ObterExibirTexto() + " ";
        }

        return texto.Trim();
    }

    public void EsconderPalavrasAleatorias()
    {
        Random random = new Random();

        List<Palavra> disponiveis = new List<Palavra>();

        foreach (Palavra palavra in _palavras)
        {
            if (!palavra.EstaOculta())
            {
                disponiveis.Add(palavra);
            }
        }

        if (disponiveis.Count > 0)
        {
            int indice = random.Next(disponiveis.Count);
            disponiveis[indice].Esconder();
        }
    }

    public bool TodasPalavrasOcultas()
    {
        foreach (Palavra palavra in _palavras)
        {
            if (!palavra.EstaOculta())
            {
                return false;
            }
        }

        return true;
    }
}