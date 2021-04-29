using System;
using System.Collections.Generic;
using System.Text;

namespace Tarefa___Herança_e_Encapsulamento
{
    public class Figura
    {
        protected double _area; 
        protected double _perimetro; 

        public double Area 
        {
            get { return this._area; }
        }

        public double Perimetro 
        {
            get { return this._perimetro; }
        }

        public static List<Figura> AddFigura()
        {
            List<Figura> listaFiguras = new List<Figura>();

            listaFiguras.AddRange(new List<Figura>
            {
                 new Circulo(10),
                 new Circulo(25),
                 new Circulo(50),
                 new Circulo(100),
                 new Retangulo(10, 15),
                 new Retangulo(25, 40),
                 new Retangulo(50, 65),
                 new Retangulo(100, 115),
            });

            return listaFiguras;
            
        }
    }
}
