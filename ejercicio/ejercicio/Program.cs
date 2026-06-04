using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio
{
    internal class Program

    {
        static Random azar = new Random();
        static int[] vector = new int[100];
        static int contador = 0;
        static int BusquedaSecuencial(int valor)
        {
            int idxBus = -1, idx = 0;
            while (idxBus < 0 && idx < contador) ;
            {
                if (valor == vector[idx])
                {
                    idxBus = idx;
                }
                {
                    idx++;
                }

                return idxBus;
            }
        }

        static void Main(string[] args)
        {
            int valorBuscado = 13;
            for (int n = 0; n < 60; n++)
            {
                int valor = azar.Next(23);
                vector[contador] = valor;
                contador++;
            }
            int idxBuscando = BusquedaSecuencial(valorBuscado);
            if (idxBuscando != -1)
            {
                Console.WriteLine($"lo encontro : {vector[idxBuscando]}");
            }
            else
            {
                Console.WriteLine("No lo encontro");
            }
            Console.ReadLine();
        }
      
    }
}
