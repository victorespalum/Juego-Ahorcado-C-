using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Ahorcado
{
    class Diccionario
    {
        String[] diccionario = new string[10];
        char[] alfabeto = new char[27];

        public Diccionario()
        {

        }

        public Diccionario(String[] diccionario, char[] alfabeto)
        {
            this.diccionario = diccionario;
            this.alfabeto = alfabeto;
        }

        public void addWord(String palabra)
        {
            try {

                this.diccionario.SetValue(palabra, diccionario.Length - 1);
            }
            catch (OverflowException)
            {
                Console.WriteLine("El diccionario ha alcanzado su maxima capacidad");
            }
        }
        public String getWord(int pos)
        {
            return this.diccionario.GetValue(pos).ToString();
        }

        public Char[] getAlfabeto() {
            return this.alfabeto;
        }

        public String[] getDiccionario()
        {
            return this.diccionario;
        }
    }
}
