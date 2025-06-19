using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3.Models
{
    internal class Lote

    {
        private int numero;
        private double[] medidas;
        private int cantidad;

        public Lote()
        {
            medidas = new double[100];
            cantidad = 0;
        }

        public double VerMedida(int idx)
        {
            return medidas[idx];
        }
        public void RegistrarMedida(double medida)
        {
            medidas[cantidad] = medida;
            cantidad++;
        }

        public int VerCantidad() { return cantidad; }
        public int VerNumeroLote() { return numero; }

        public void AsignarNumeroLote(int nlote) { numero = nlote; }

    }
}
