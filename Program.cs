using System;
using POO;


namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno p1 = new Aluno();

            Console.WriteLine("Nome do Aluno");
            p1.nome = Console.ReadLine();
            Console.WriteLine("Nota");
            p1.Nota = int.Parse(Console.ReadLine());


        //    //valores validos
        //    Retangulo r = new Retangulo();
        //    r.DefinirMedidas(30, 30);
        //    Console.WriteLine($"àrea: {r.ObterArea()}");

        //    //valores Invalidos
        //    Retangulo r2 = new Retangulo();
        //    r.DefinirMedidas(0, 0);
        //    Console.WriteLine($"àrea: {r2.ObterArea()}");
        //
        }
    }
}
