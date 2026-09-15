using System;

class Program
{
    static void Main(string[] args)
    {
        Emprego emprego1 = new Emprego();

        emprego1._empresa = "empresa";

        emprego1._cargo = "Cargo";

        emprego1._anoInicio = 2022;

        emprego1._anoFim = 2026;





        Emprego emprego2 = new Emprego();

        emprego2._empresa = "empresa";

        emprego2._cargo = "cargo";

        emprego2._anoInicio = 2022;

        emprego2._anoFim = 2026;





        Curriculo meuCurriculo = new Curriculo();

        meuCurriculo._empregos.Add(emprego1);

        meuCurriculo._empregos.Add(emprego2);



        meuCurriculo._nome = "Davi Victor";

        meuCurriculo.Exibir();

    }
}

