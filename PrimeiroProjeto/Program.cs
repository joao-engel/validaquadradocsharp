using System;

namespace PrimeiroProjeto {
internal class Program {
        static void Main(string[] args) {
            Retangulo ret = new Retangulo();
            Console.WriteLine("Informe o tamanho dos lados do quadrado");
            string[] vet = Console.ReadLine().Split(' ');

            ret.LadoEsq = int.Parse(vet[0]);
            ret.LadoSup = int.Parse(vet[1]);
            ret.LadoInf = int.Parse(vet[2]);
            ret.LadoDir = int.Parse(vet[3]);

            if (ret.Validador()) {
                if (ret.Comparador()) {
                    Console.WriteLine("Retangulo!");
                }
                else {
                    Console.WriteLine("Quadrado!");
                }
            }
            else {
                Console.WriteLine("Não é quadrado e nem retangulo!!");
            }
        }
    }
}