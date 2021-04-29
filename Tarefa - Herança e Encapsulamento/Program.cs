using System;
using System.Collections.Generic;

namespace Tarefa___Herança_e_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Figura> listaFiguras = Figura.AddFigura();
            int numeroRetangulo = 1;
            int numeroCirculo = 1;
            foreach (var figura in listaFiguras)
            {
                if(figura is Circulo)
                {
                    Console.WriteLine("A área do circulo {0} é {1} e o perimetro é {2}", numeroCirculo, figura.Area, figura.Perimetro);
                    numeroCirculo++;
                }
                else
                {                    
                    Console.WriteLine("A área do retângulo {0} é {1} e o perimetro é {2}", numeroRetangulo, figura.Area, figura.Perimetro);
                    numeroRetangulo++;
                }
                
            }
        }
    }
}
