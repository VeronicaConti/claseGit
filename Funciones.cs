using System;

namespace MiPrimerPrograma
{
    public class Funciones
    {
        public int Cuadrado(int numero)
        {
            return numero * numero;
        }

        public void Imprimir(int a, int b)
        {
            Console.WriteLine("El valor de a es: " + a);
            Console.WriteLine("El valor de b es: " + b);
        }

        public void Intercambio(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public int Mayor(int x, int y)
        {
            return (x > y) ? x : y;
        }

        public void AumentarDiezPorCiento(ref double sueldo)
        {
            sueldo = sueldo + (sueldo * 0.10);
        }
    }
}
