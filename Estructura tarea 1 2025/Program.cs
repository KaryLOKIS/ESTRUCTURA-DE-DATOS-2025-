
using System;

namespace FigurasGeometricas
{
    // Clase que representa un Círculo
    public class Circulo
    {
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    // Clase que representa un Rectángulo
    public class Rectangulo
    {
        private double baseRect;
        private double altura;

        public Rectangulo(double baseRect, double altura)
        {
            this.baseRect = baseRect;
            this.altura = altura;
        }

        public double CalcularArea()
        {
            return baseRect * altura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (baseRect + altura);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo = new Circulo(5);
            Console.WriteLine("Círculo:");
            Console.WriteLine("Área: " + miCirculo.CalcularArea());
            Console.WriteLine("Perímetro: " + miCirculo.CalcularPerimetro());

            Rectangulo miRectangulo = new Rectangulo(4, 3);
            Console.WriteLine("\nRectángulo:");
            Console.WriteLine("Área: " + miRectangulo.CalcularArea());
            Console.WriteLine("Perímetro: " + miRectangulo.CalcularPerimetro());
        }
    }
}
