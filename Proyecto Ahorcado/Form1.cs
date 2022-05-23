using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Ahorcado
{
    public partial class Form1 : Form
    {
        String[] unDiccionario = new string[] { "raiz", "arca", "barco", "lapiz", "nariz", "gordo", "friki" };
        char[] unAlfabeto = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ".ToCharArray();
        Diccionario diccionario;
        Partida nueva_partida;
        int[] posicionOcurrencias;
        int index_imagen = 0;

        Administrador administrador;


        public Form1()
        {
            NewMethod();
        }

        private void NewMethod()
        {
            InitializeComponent();
            diccionario = new Diccionario(unDiccionario, unAlfabeto);
            administrador = new Administrador("admin", "1234");
            ll_1.Text = "X";
            ll_2.Text = "X";
            ll_3.Text = "X";
            ll_4.Text = "X";
            ll_5.Text = "X";
            ll_6.Text = "X";
            TextBoxLetraIntroducida.Text = " ";
            TextBoxErrores.Text = null;
            ll_1.Enabled = false;
            ll_2.Enabled = false;
            ll_3.Enabled = false;
            ll_4.Enabled = false;
            ll_5.Enabled = false;
            ll_6.Enabled = false;
            ll_1.Visible = false;
            ll_2.Visible = false;
            ll_3.Visible = false;
            ll_4.Visible = false;
            ll_5.Visible = false;
            ll_6.Visible = false;
            TextBoxLetraIntroducida.Enabled = false;
            TextBoxErrores.Enabled = false;
            bt_ProbarLetra.Enabled = false;
            TextBoxErrores.ReadOnly = true;
            textBox1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ll_6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void bt_IniciarPartida_Click(object sender, EventArgs e)
        {
            reiniciarCampos();
            
            TextBoxLetraIntroducida.Enabled = true;
            bt_ProbarLetra.Enabled = true;
            tb_usuario.Enabled = false;
            tb_password.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            textBox1.Enabled = false;
            checkedListBox1.Enabled = false;

            nueva_partida = new Partida();
            Random random = new Random();
            int indicePalabraSeleccionada = random.Next(0, diccionario.getDiccionario().Length);
            nueva_partida.IniciarPartida(diccionario.getWord(indicePalabraSeleccionada));
            posicionOcurrencias = new int[nueva_partida.getPalabraAdivinable().Length];
            index_imagen = 0;
            pictureBox1.Image = Image.FromFile("C:/Users/PC/Desktop/DI proyecto final/Proyecto Ahorcado/img/default.jpg");
            ll_fallos.Text = "6";

            for (int i = 0; i < posicionOcurrencias.Length; i++)
                posicionOcurrencias[i] = 0;

            if (nueva_partida.getPalabraAdivinable().Length == 3)
            {
                ll_1.Enabled = true;
                ll_2.Enabled = true;
                ll_3.Enabled = true;
                ll_1.Visible = true;
                ll_2.Visible = true;
                ll_3.Visible = true;
            }
            else if(nueva_partida.getPalabraAdivinable().Length == 4)
            {
                ll_1.Enabled = true;
                ll_2.Enabled = true;
                ll_3.Enabled = true;
                ll_4.Enabled = true;
                ll_1.Visible = true;
                ll_2.Visible = true;
                ll_3.Visible = true;
                ll_4.Visible = true;
            }
            else if(nueva_partida.getPalabraAdivinable().Length == 5)
            {
                ll_1.Enabled = true;
                ll_2.Enabled = true;
                ll_3.Enabled = true;
                ll_4.Enabled = true;
                ll_5.Enabled = true;
                ll_1.Visible = true;
                ll_2.Visible = true;
                ll_3.Visible = true;
                ll_4.Visible = true;
                ll_5.Visible = true;
            }
            else if(nueva_partida.getPalabraAdivinable().Length == 6)
            {
                ll_1.Enabled = true;
                ll_2.Enabled = true;
                ll_3.Enabled = true;
                ll_4.Enabled = true;
                ll_5.Enabled = true;
                ll_6.Enabled = true;
                ll_1.Visible = true;
                ll_2.Visible = true;
                ll_3.Visible = true;
                ll_4.Visible = true;
                ll_5.Visible = true;
                ll_6.Visible = true;
            }
              
            String dificultad = "";

            for (int x = 0; x < checkedListBox1.CheckedItems.Count; x++)
            {
                dificultad = checkedListBox1.CheckedItems[x].ToString();
            }

            if (dificultad.Equals("Básico"))
            {
                Random random1 = new Random();
                Random random2 = new Random();
                int indiceAyuda1 = random1.Next(0, nueva_partida.getPalabraAdivinable().Length);
                int indiceAyuda2 = random2.Next(0, nueva_partida.getPalabraAdivinable().Length);
                while (indiceAyuda1 == indiceAyuda2)
                    indiceAyuda2 = random2.Next(0, nueva_partida.getPalabraAdivinable().Length);

                if (ll_1.Enabled == true && indiceAyuda1 == 0)
                {
                    ll_1.Text = nueva_partida.getPalabraAdivinable()[0].ToString().ToUpper();
                    posicionOcurrencias[0] = 1;
                }
                if (ll_2.Enabled == true && indiceAyuda1 == 1)
                {
                    ll_2.Text = nueva_partida.getPalabraAdivinable()[1].ToString().ToUpper();
                    posicionOcurrencias[1] = 1;
                }
                if (ll_3.Enabled == true && indiceAyuda1 == 2)
                {
                    ll_3.Text = nueva_partida.getPalabraAdivinable()[2].ToString().ToUpper();
                    posicionOcurrencias[2] = 1;
                }
                if (ll_4.Enabled == true && indiceAyuda1 == 3)
                {
                    ll_4.Text = nueva_partida.getPalabraAdivinable()[3].ToString().ToUpper();
                    posicionOcurrencias[3] = 1;
                }
                if (ll_5.Enabled == true && indiceAyuda1 == 4)
                {
                    ll_5.Text = nueva_partida.getPalabraAdivinable()[4].ToString().ToUpper();
                    posicionOcurrencias[4] = 1;
                }
                if (ll_6.Enabled == true && indiceAyuda1 == 5)
                {
                    ll_6.Text = nueva_partida.getPalabraAdivinable()[5].ToString().ToUpper();
                    posicionOcurrencias[5] = 1;
                }

                if (ll_1.Enabled == true && indiceAyuda2 == 0)
                {
                    ll_1.Text = nueva_partida.getPalabraAdivinable()[0].ToString().ToUpper();
                    posicionOcurrencias[0] = 1;
                }
                if (ll_2.Enabled == true && indiceAyuda2 == 1)
                {
                    ll_2.Text = nueva_partida.getPalabraAdivinable()[1].ToString().ToUpper();
                    posicionOcurrencias[1] = 1;
                }
                if (ll_3.Enabled == true && indiceAyuda2 == 2)
                {
                    ll_3.Text = nueva_partida.getPalabraAdivinable()[2].ToString().ToUpper();
                    posicionOcurrencias[2] = 1;
                }
                if (ll_4.Enabled == true && indiceAyuda2 == 3)
                {
                    ll_4.Text = nueva_partida.getPalabraAdivinable()[3].ToString().ToUpper();
                    posicionOcurrencias[3] = 1;
                }
                if (ll_5.Enabled == true && indiceAyuda2 == 4)
                {
                    ll_5.Text = nueva_partida.getPalabraAdivinable()[4].ToString().ToUpper();
                    posicionOcurrencias[4] = 1;
                }
                if (ll_6.Enabled == true && indiceAyuda2 == 5)
                {
                    ll_6.Text = nueva_partida.getPalabraAdivinable()[5].ToString().ToUpper();
                    posicionOcurrencias[5] = 1;
                }
            }

            else if (dificultad.Equals("Intermedio"))
            {
                Random random1 = new Random();
                int indiceAyuda1 = random1.Next(0, nueva_partida.getPalabraAdivinable().Length);
                if (ll_1.Enabled == true && indiceAyuda1 == 0)
                {
                    ll_1.Text = nueva_partida.getPalabraAdivinable()[0].ToString().ToUpper();
                    posicionOcurrencias[0] = 1;
                }
                if (ll_2.Enabled == true && indiceAyuda1 == 1)
                {
                    ll_2.Text = nueva_partida.getPalabraAdivinable()[1].ToString().ToUpper();
                    posicionOcurrencias[1] = 1;
                }
                if (ll_3.Enabled == true && indiceAyuda1 == 2)
                {
                    ll_3.Text = nueva_partida.getPalabraAdivinable()[2].ToString().ToUpper();
                    posicionOcurrencias[2] = 1;
                }
                if (ll_4.Enabled == true && indiceAyuda1 == 3)
                {
                    ll_4.Text = nueva_partida.getPalabraAdivinable()[3].ToString().ToUpper();
                    posicionOcurrencias[3] = 1;
                }
                if (ll_5.Enabled == true && indiceAyuda1 == 4)
                {
                    ll_5.Text = nueva_partida.getPalabraAdivinable()[4].ToString().ToUpper();
                    posicionOcurrencias[4] = 1;
                }
                if (ll_6.Enabled == true && indiceAyuda1 == 5)
                {
                    ll_6.Text = nueva_partida.getPalabraAdivinable()[5].ToString().ToUpper();
                    posicionOcurrencias[4] = 1;
                }

            }

            else if (dificultad.Equals("Avanzado"))
            {
                MessageBox.Show("Buena suerte... No obtendrás pistas en esta dificultad. \n\n\n ---------- NIVEL AVANZADO ----------");
            }

            bt_IniciarPartida.Enabled = false;

        }

        public void reiniciarCampos()
        {
            ll_1.Text = "X";
            ll_2.Text = "X";
            ll_3.Text = "X";
            ll_4.Text = "X";
            ll_5.Text = "X";
            ll_6.Text = "X";
            TextBoxLetraIntroducida.Text = null;
            TextBoxErrores.Text = null;
        }

        private void bt_ProbarLetra_Click(object sender, EventArgs e)
        {
            char letra_introducida = TextBoxLetraIntroducida.Text[0];
            bool letraIntroducida = false;
            TextBoxLetraIntroducida.Text = null;
            for (int i = 0; i < nueva_partida.getLetrasIntroducidas().Length; i++)
            {
                if(nueva_partida.getLetrasIntroducidas()[i] == letra_introducida)
                {
                    MessageBox.Show("La letra '" + letra_introducida + "' ya ha sido introducida previamente");
                    letraIntroducida = true;
                    break;
                }                
            }

            if (letraIntroducida == false)
            {
                bool errorCometido = true;
                bool gameOver = false;

                nueva_partida.setLetraEnVector(letra_introducida);
                for(int i = 0; i < nueva_partida.getPalabraAdivinable().Length; i++)
                {
                    if(letra_introducida == nueva_partida.getPalabraAdivinable()[i])
                    {
                        posicionOcurrencias[i] = 1;
                        errorCometido = false;
                    }
                }

                if (errorCometido)
                {
                    nueva_partida.setNumIntentos(nueva_partida.getNumIntentos() - 1);
                    ll_fallos.Text = nueva_partida.getNumIntentos().ToString();
                    index_imagen++;
                    pictureBox1.Image = Image.FromFile("C:/Users/PC/Desktop/DI proyecto final/Proyecto Ahorcado/img/"+index_imagen+".JPG");
                    TextBoxErrores.Text = TextBoxErrores.Text + letra_introducida.ToString() + " ";
                    if (nueva_partida.getNumIntentos() == 0)
                    {
                        gameOver = true;
                    }

                    if (gameOver)
                    {
                        MessageBox.Show("¡ Vaya.... Lo sentimos, has matado a tu amigo ! \n\n\n ---------- GAME OVER ---------- ");
                        if (ll_1.Enabled == true )
                        {
                            ll_1.Text = nueva_partida.getPalabraAdivinable()[0].ToString().ToUpper();
                        }
                        if (ll_2.Enabled == true )
                        {
                            ll_2.Text = nueva_partida.getPalabraAdivinable()[1].ToString().ToUpper();
                        }
                        if (ll_3.Enabled == true )
                        {
                            ll_3.Text = nueva_partida.getPalabraAdivinable()[2].ToString().ToUpper();
                        }
                        if (ll_4.Enabled == true )
                        {
                            ll_4.Text = nueva_partida.getPalabraAdivinable()[3].ToString().ToUpper();
                        }
                        if (ll_5.Enabled == true )
                        {
                            ll_5.Text = nueva_partida.getPalabraAdivinable()[4].ToString().ToUpper();
                        }
                        if (ll_6.Enabled == true )
                        {
                            ll_6.Text = nueva_partida.getPalabraAdivinable()[5].ToString().ToUpper();
                        }

                        tb_usuario.Enabled = true;
                        tb_password.Enabled = true;
                        button2.Enabled = true;
                        bt_IniciarPartida.Enabled = true;
                        checkedListBox1.Enabled = true;
                        bt_ProbarLetra.Enabled = false;
                        TextBoxLetraIntroducida.Enabled = false;
                    }
                }

                if (!gameOver)
                {
                    bool gameWon = true;

                    if (ll_1.Enabled == true && posicionOcurrencias[0] == 1)
                    {
                        ll_1.Text = nueva_partida.getPalabraAdivinable()[0].ToString().ToUpper();
                    }
                    if (ll_2.Enabled == true && posicionOcurrencias[1] == 1)
                    {
                        ll_2.Text = nueva_partida.getPalabraAdivinable()[1].ToString().ToUpper();
                    }
                    if (ll_3.Enabled == true && posicionOcurrencias[2] == 1)
                    {
                        ll_3.Text = nueva_partida.getPalabraAdivinable()[2].ToString().ToUpper();
                    }
                    if (ll_4.Enabled == true && posicionOcurrencias[3] == 1)
                    {
                        ll_4.Text = nueva_partida.getPalabraAdivinable()[3].ToString().ToUpper();
                    }
                    if (ll_5.Enabled == true && posicionOcurrencias[4] == 1)
                    {
                        ll_5.Text = nueva_partida.getPalabraAdivinable()[4].ToString().ToUpper();
                    }
                    if (ll_6.Enabled == true && posicionOcurrencias[5] == 1)
                    {
                        ll_6.Text = nueva_partida.getPalabraAdivinable()[5].ToString().ToUpper();
                    }

                    for(int i = 0; i < posicionOcurrencias.Length; i++)
                    {
                        if (posicionOcurrencias[i] == 0)
                            gameWon = false;
                    }

                    if (gameWon)
                    {
                        MessageBox.Show("¡ Enhorabuena, has salvado a tu amigo ! \n\n\n ---------- GAME WON ---------- ");
                        tb_usuario.Enabled = true;
                        tb_password.Enabled = true;
                        button2.Enabled = true;
                        bt_IniciarPartida.Enabled = true;
                        checkedListBox1.Enabled = true;
                        bt_ProbarLetra.Enabled = false;
                        TextBoxLetraIntroducida.Enabled = false;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkedListBox1_ItemCheck_1(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox1.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox1.SetItemChecked(ix, false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String usuario = tb_usuario.Text;
            String password = tb_password.Text;

            if (administrador.upchecking(usuario, password))
            {
                MessageBox.Show("Login realizado.\n\n\n ---------- SUCCESSFUL ----------");
                administrador.setSesionActive(true);
                textBox1.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                tb_usuario.Enabled = false;
                tb_password.Enabled = false;
                button2.Enabled = false;

                //desactivamos toda la zona de juego
                checkedListBox1.Enabled = false;
                bt_IniciarPartida.Enabled = false;
                TextBoxLetraIntroducida.Enabled = false;
                bt_ProbarLetra.Enabled = false;
            }
            else {
                MessageBox.Show("Credenciales incorrectas. \n\n\n ---------- REJECTED ----------");
                administrador.setSesionActive(false);
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (diccionario.getDiccionario().Length == 10)
            { 
                MessageBox.Show("El diccionario está completo.");
            }
            else if(textBox1.Text.Length > 6)
            {
                MessageBox.Show("Introduzca una palabra de longitud no superior a 6 letras. ");
            }
            else
            {
                String nueva_palabra = textBox1.Text;
                diccionario.addWord(nueva_palabra);
                textBox1.Text = null;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            administrador.setSesionActive(false);
            textBox1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            tb_usuario.Enabled = true;
            tb_usuario.Text = null;
            tb_password.Enabled = true;
            tb_password.Text = null;
            button2.Enabled = true;
            checkedListBox1.Enabled = true;
            bt_IniciarPartida.Enabled = true;
        }
    }
}
