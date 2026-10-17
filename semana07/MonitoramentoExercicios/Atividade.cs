using System;

public abstract class Atividade
{
    private DateTime _Data;
    private int _duracao;

    public Atividade(DateTime data, int duracao)
    {
        _Data = data;
        _duracao = duracao;
    }

    public abstract double ObterDistancia();
    public abstract double ObterVelocidade();
    public abstract double ObterRitmo();

    public string ObterResumo()
    {
        return $"{_Data:dd MMM yyyy} ({_duracao} min) - " +
                $"Distância {ObterDistancia():F1} km, " +
                $"Velocidade {ObterVelocidade():F1} km/h, " +
                $"Ritmo {ObterRitmo():F1} min por km";
    }

    public int ObterDuracao()
    {
        return _duracao;
    }
}