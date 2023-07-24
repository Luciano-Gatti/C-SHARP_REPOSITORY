using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUDO_V3._0
{
    public class Jugador
    {
        //Atributos de cada Jugador
        private string color_jugador;
        private string tipo;
        private List<Fichas> listFichas;
        private bool ganador;
        private int contFichas;

        //coordenadas de las posiciones iniciales de las fichas de acuerdo al color
        private int[,] posInicial_Azules = {{54, 58}, {140, 58}, {55, 145}, {140, 145}};
        private int[,] posInicial_Rojas = {{432, 59}, {518, 58}, {433, 145}, {518, 145}};
        private int[,] posInicial_Verdes = {{432, 453}, {518, 453}, {433, 540}, {518, 540}};
        private int[,] posInicial_Amarillas = {{54, 453}, {140, 453}, {54, 540}, {140, 540}};

       
        //Arreglos con las coordenadas de movimientos de cada color
        int[,] movimientosAzul = {{253,43},{253,86},{253,129},{253,172},{253,220},{211,263},{169,263},{126,263},
            {84,263},{42,263},{0,263},{0,307},{0,350},{42,350},{84,350},{126,350},{167,350},
            {211,350},{253,395},{253,439},{253,481},{253,527},{253,570},{253,614},{295,614},{337,614},
            {337,569},{337,525},{337,482},{337,439},{337,395},{380,350},{422,350},{464,350},{506,350},
            {549,350},{590,350},{590,307},{590,263},{548,263},{506,263},{465,263},{423,263},{380,263},
            {337,219},{337,175},{337,131},{337,87},{337,44},{337,0},{294,0},{294,44},{294,87},{294,131},
            {294,175},{294,219},{294,267}};

        int[,] movimientosRojo = {{548,263},{506,263},{465,263},{423,263},{380,263},
            {337,219},{337,175},{337,131},{337,87},{337,44},{337,0},{294,0},{253,0},{253,43},{253,86},{253,129},{253,172},
            {253,220},{211,263},{169,263},{126,263},{84,263},{42,263},{0,263},{0,307},{0,350},{42,350},{84,350},
            {126,350},{167,350},{211,350},{253,395}, {253,439},{253,481},{253,527},{253,570},{253,614},{295,614},
            {337,614},{337,569},{337,525},{337,482},{337,439},{337,395},{380,350},{422,350},{464,350},{506,350},
            {549,350},{590,350},{590,307},{549,307},{507,307},{464,307},{422,307},{380,307},{335,307}};

        int[,] movimientosAmarillo = {{42,350},{84,350},
            {126,350},{167,350},{211,350},{253,395}, {253,439},{253,481},{253,527},{253,570},{253,614},{295,614},
            {337,614},{337,569},{337,525},{337,482},{337,439},{337,395},{380,350},{422,350},{464,350},{506,350},
            {549,350},{590,350},{590,307},{548,263},{506,263},{465,263},{423,263},{380,263},{337,219},{337,175},
            {337,131},{337,87},{337,44},{337,0},{294,0},{253,0},{253,43},{253,86},{253,129},{253,172},{253,220},{211,263},
            {169,263},{126,263},{84,263},{42,263},{0,263},{0,307},{41,307},{84,307},{126,307},{169,307},{211,307},{255,307}};

        int[,] movimientosVerde = {{337,569},{337,525},{337,482},{337,439},{337,395},{380,350},{422,350},{464,350},{506,350},
            {549,350},{590,350},{590,307},{590,263},{548,263},{506,263},{465,263},{423,263},{380,263},{337,219},{337,175},
            {337,131},{337,87},{337,44},{337,0},{294,0},{253,0},{253,43},{253,86},{253,129},{253,172},{253,220},{211,263},
            {169,263},{126,263},{84,263},{42,263},{0,263},{0,307},{0,350},{42,350},{84,350},{126,350},{167,350},{211,350},
            {253,395}, {253,439},{253,481},{253,527},{253,570},{253,614},{295,614},{295,569},{295,525},{295,481},{295,439},
            {295,395},{295,349}};

        //Constructor de la clase Jugador
        public Jugador(string color, string tipo)
        {
            this.color_jugador = color;
            this.tipo = tipo;
            this.listFichas = new List<Fichas>();
            this.ganador = false;
            this.contFichas = 0;
        }

        //Getters y Setters
        public string Color_jugador { get => color_jugador; set => color_jugador = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public bool Ganador { get => ganador; set => ganador = value; }
        internal List<Fichas> ListFichas { get => listFichas; set => listFichas = value; }
        public int[,] PosInicial_Verdes { get => posInicial_Verdes; set => posInicial_Verdes = value; }
        public int[,] PosInicial_Azules { get => posInicial_Azules; set => posInicial_Azules = value; }
        public int[,] PosInicial_Amarillas { get => posInicial_Amarillas; set => posInicial_Amarillas = value; }
        public int[,] PosInicial_Rojas { get => posInicial_Rojas; set => posInicial_Rojas = value; }
    }
}
