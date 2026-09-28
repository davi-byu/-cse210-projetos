using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Aprendendo C#", "Davi Victor", 300);

        Comentario comentario1 = new Comentario("João", "Gostei muito do vídeo!");
        video1.AdicionarComentario(comentario1);

        Comentario comentario2 = new Comentario("davi", "O video explica muito bem");
        video1.AdicionarComentario(comentario2);

        Comentario comentario3 = new Comentario("Cicera", "Maravilhoso, amei!");
        video1.AdicionarComentario(comentario3);

        Comentario comentario4 = new Comentario("David", "Muito bom!!! Espero ver novos videos como esse!");
        video1.AdicionarComentario(comentario4);




        Video video2 = new Video("Aprendendo abstração", "Davi Victor", 250);

        Comentario comentario5 = new Comentario("D.santos", "Muito bom!");
        video2.AdicionarComentario(comentario5);

        Comentario comentario6 = new Comentario("Andeza", "Gostei do video, bem ilustrativo");
        video2.AdicionarComentario(comentario6);

        Comentario comentario7 = new Comentario("Felipe", "Poderia só melhorar a qualidade do video.");
        video2.AdicionarComentario(comentario7);

        Comentario comentario8 = new Comentario("Pedro", "Gostei, poderia fazer novos videos");
        video2.AdicionarComentario(comentario8);



        Video video3 = new Video("Aprendendo encapsulamento", "Davi Victor", 485);

        Comentario comentario9 = new Comentario("Francisco", "Boa explicação!");
        video3.AdicionarComentario(comentario9);

        Comentario comentario10 = new Comentario("Leyd", "Gostei muito, espero ver novos videos como esse!");
        video3.AdicionarComentario(comentario10);

        Comentario comentario11 = new Comentario("Miguel", "Vou compartilhar esse video");
        video3.AdicionarComentario(comentario11);

        Comentario comentario12 = new Comentario("Liliane", "Que maravilhoso poder assistir essa aula!");
        video3.AdicionarComentario(comentario12);

        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {

            Console.WriteLine("=============================================");


            Console.WriteLine($"Título: {video.ObterTitulo()}");
            Console.WriteLine($"Autor: {video.ObterAutor()}");
            Console.WriteLine($"Duração: {video.ObterDuracao()} segundos");
            Console.WriteLine($"Quantidade de Comentários: {video.ObterQuantidadeComentarios()}");


            foreach (Comentario comentario in video.ObterComentarios())
            {

                Console.WriteLine($"Nome: {comentario.ObterNome()}");
                Console.WriteLine($"Texto: {comentario.ObterTexto()}");
            }
            Console.WriteLine();
        }

    }



}