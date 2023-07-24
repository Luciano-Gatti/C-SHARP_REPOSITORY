using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    public class Jugador
    {
        string nombre;
        int numeroCarton;
        List<int> listaNumJugador = new List<int>();
        List <int> numerosAcertados = new List<int>();
        List <int> listaNumGenerados = new List<int>();
        bool[] botones = new bool[16];
        List <int> numerosSorteados = new List<int>();

        public Jugador(string nombre, int numeroCarton)
        {
            this.nombre = nombre;
            this.numeroCarton = numeroCarton;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int NumeroCarton { get => numeroCarton; set => numeroCarton = value; }
        public List<int> ListaNumeros { get => listaNumJugador; set => listaNumJugador = value; }
        public List<int> NumerosAcertados { get => numerosAcertados; set => numerosAcertados = value; }
        public List<int> ListaNumGenerados { get => listaNumGenerados; set => listaNumGenerados = value; }
        public bool[] Botones { get => botones; set => botones = value; }
        public List<int> NumerosSorteados { get => numerosSorteados; set => numerosSorteados = value; }
    }
}
