using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Ahorcado
{
    class Partida
    {
        String palabraAdivinable;
        int num_intentos;
        char letra_introducida;
        bool palabra_adivinada;
        char[] letras_introducidas;
        int index;

        public Partida()
        {
            this.palabraAdivinable = null;
            this.num_intentos = 0;
            this.letra_introducida = '\0';
            this.palabra_adivinada = false;

        }

        public Partida(String palabraAdivinable, int num_intentos, char letra_introducida, bool palabra_adivinada)
        {
            this.palabraAdivinable = palabraAdivinable;
            this.num_intentos = num_intentos;
            this.letra_introducida = letra_introducida;
            this.palabra_adivinada = palabra_adivinada;
        }

        public void IniciarPartida(String palabraAdivinable)
        {
            this.palabraAdivinable = palabraAdivinable;
            this.num_intentos = 6;
            this.letra_introducida = '\0';
            this.palabra_adivinada = false;
            this.letras_introducidas = new char[27];
            this.index = 0;

        }
        public char[] getLetrasIntroducidas()
        {
            return this.letras_introducidas;
        }

        public void setLetrasIntroducidas(char[] letras)
        {
            this.letras_introducidas = letras;
        }

        public int getNumIntentos()
        {
            return this.num_intentos;
        }

        public String getPalabraAdivinable()
        {
            return this.palabraAdivinable;
        }

        public bool isGameWon()
        {
            return this.palabra_adivinada;
        }

        public char getLetraIntroducida()
        {
            return this.letra_introducida;
        }

        public void setNumIntentos(int num)
        {
            this.num_intentos = num;
        }

        public void setLetraIntroducida(char letra)
        {
            this.letra_introducida = letra;
        }

        public void setPalabraAdivinable(String palabra)
        {
            this.palabraAdivinable = palabra;
        }

        public void setPalabraAdivinada(bool isGameWon)
        {
            this.palabra_adivinada = isGameWon;
        }

        public void setLetraEnVector(char letra)
        {
            this.letras_introducidas.SetValue(letra, index);
            index++;
        }
    }
}
