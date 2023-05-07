using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonteroJustin_Puzzle15
{
    public partial class Form1 : Form
    {
        int[] vectorFichas = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        string[,] matrizTablero = new string[4, 4];
        int itera = 0, hI = 0, hJ = 0, bI = 0, bJ = 0;
        int auxHI = 0, auxHJ = 0, num = 0, count = 0;


        //Funcion para mover fichas
        public void moverFicha()
        {
            //Compruebo si la ficha se puede mover al hueco
            if (bI + 1 == hI && bJ == hJ ||
                bI - 1 == hI && bJ == hJ ||
                bI == hI && bJ + 1 == hJ ||
                bI == hI && bJ - 1 == hJ)
            {
                //contador de los movimientos realizados
                count++;
                txtCount.Text = count.ToString();
                //Guardo las pocisiones de donde va a estar el hueco en auxiliares
                //para poder seguir comparando
                auxHI = bI;
                auxHJ = bJ;
                //averiguar donde estaba el hueco para saber
                //en cual posicion va a estar la ficha
                if (bI + 1 == hI && bJ == hJ)
                {
                    bI = bI + 1;
                }
                else if (bI - 1 == hI && bJ == hJ)
                {
                    bI = bI - 1;
                }
                else if (bI == hI && bJ + 1 == hJ)
                {
                    bJ = bJ + 1;
                }
                else if (bI == hI && bJ - 1 == hJ)
                {
                    bJ = bJ - 1;
                }
                //Asigno las posiciones del hueco
                hI = auxHI;
                hJ = auxHJ;
                //Ahora lo que tiene
                matrizTablero[hI, hJ] = 0.ToString();
                matrizTablero[bI, bJ] = num.ToString();

                //asignos las fichas a cada boton con relacion a la matriz en memoria
                btn1.Text = matrizTablero[0, 0];
                btn2.Text = matrizTablero[0, 1];
                btn3.Text = matrizTablero[0, 2];
                btn4.Text = matrizTablero[0, 3];
                //***************************************
                btn5.Text = matrizTablero[1, 0];
                btn6.Text = matrizTablero[1, 1];
                btn7.Text = matrizTablero[1, 2];
                btn8.Text = matrizTablero[1, 3];
                //***************************************
                btn9.Text = matrizTablero[2, 0];
                btn10.Text = matrizTablero[2, 1];
                btn11.Text = matrizTablero[2, 2];
                btn12.Text = matrizTablero[2, 3];
                //***************************************
                btn13.Text = matrizTablero[3, 0];
                btn14.Text = matrizTablero[3, 1];
                btn15.Text = matrizTablero[3, 2];
                btnHueco.Text = matrizTablero[3, 3];



                listo = false;

                //verifica si todas las fichas estan correctamente colocadas
                //para saber si ganó
                int verifica = 1;
                bool bandBreak = true;
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        //Pregunta si es diferente y si es diferente sale del ciclo
                        //no se pudo completar la revisión
                        if (matrizTablero[i, j] != verifica.ToString())
                        {
                            //para que salga de los 2 ciclos
                            bandBreak = false;
                            break;
                        }
                        verifica++;
                    }
                    //En la ultima vuelta cuando verifica tenga 16
                    //Es porque todos estaban correctos y el ultimo número es un 0
                    //entonces no es 16 la bandera se pasaria a falso pero como es correcto se cambia a true
                    if (verifica == 16)
                    {
                        bandBreak = true;
                    }
                    //sale de los 2 ciclos
                    if (bandBreak != true)
                    {
                        break;
                    }
                }
                //Aqui ya gano y imprime mensaje en pantalla
                if (bandBreak == true)
                {
                    txtGana.Text = "Felicidades Ganaste!!";
                }
            }
        }

        //buttons of the 0 to 15
        #region 
        private void btn3_Click(object sender, EventArgs e)
        {
            //boton 3
            bI = 0;
            bJ = 2;
            //para que si selecciona el hueco no salte error
            if (btn3.Text != "")
            {
                num = int.Parse(btn3.Text);
                //verifica si se puede mover el boton
                moverFicha();
                //si la bandera cambia a falso entonces significa que la ficha si se movió
            }
            if (listo == false)
            {
                btn3.Text = "";
                listo = true;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //boton 4
            bI = 0;
            bJ = 3;
            //para que si selecciona el hueco no salte error
            if (btn4.Text != "")
            {
                num = int.Parse(btn4.Text);
                //verifica si se puede mover el boton
                moverFicha();
                //si la bandera cambia a falso entonces significa que la ficha si se movió
            }
            if (listo == false)
            {
                btn4.Text = "";
                listo = true;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //boton 5
            bI = 1;
            bJ = 0;
            //para que si selecciona el hueco no salte error
            if (btn5.Text != "")
            {
                num = int.Parse(btn5.Text);
                //verifica si se puede mover el boton
                moverFicha();
                //si la bandera cambia a falso entonces significa que la ficha si se movió
            }
            if (listo == false)
            {
                btn5.Text = "";
                listo = true;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //boton 6
            bI = 1;
            bJ = 1;
            //para que si selecciona el hueco no salte error
            if (btn6.Text != "")
            {
                num = int.Parse(btn6.Text);
                //verifica si se puede mover el boton
                moverFicha();
                //si la bandera cambia a falso entonces significa que la ficha si se movió
            }
            if (listo == false)
            {
                btn6.Text = "";
                listo = true;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //boton 7
            bI = 1;
            bJ = 2;
            //para que si selecciona el hueco no salte error
            if (btn7.Text != "")
            {
                num = int.Parse(btn7.Text);
                //verifica si se puede mover el boton
                moverFicha();
                //si la bandera cambia a falso entonces significa que la ficha si se movió
            }
            if (listo == false)
            {
                btn7.Text = "";
                listo = true;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            //boton 8
            bI = 1;
            bJ = 3;
            //para que si selecciona el hueco no salte error
            if (btn8.Text != "")
            {
                num = int.Parse(btn8.Text);
                //verifica si se puede mover el boton
                moverFicha();
                //si la bandera cambia a falso entonces significa que la ficha si se movió
            }
            if (listo == false)
            {
                btn8.Text = "";
                listo = true;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //boton 9
            bI = 2;
            bJ = 0;
            //para que si selecciona el hueco no salte error
            if (btn9.Text != "")
            {
                num = int.Parse(btn9.Text);
                //verifica si se puede mover el boton
                moverFicha();
                //si la bandera cambia a falso entonces significa que la ficha si se movió
            }
            if (listo == false)
            {
                btn9.Text = "";
                listo = true;
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            //boton 10
            bI = 2;
            bJ = 1;
            //para que si selecciona el hueco no salte error
            if (btn10.Text != "")
            {
                num = int.Parse(btn10.Text);
                //verifica si se puede mover el boton
                moverFicha();
                //si la bandera cambia a falso entonces significa que la ficha si se movió
            }
            if (listo == false)
            {
                btn10.Text = "";
                listo = true;
            }
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            //boton 11
            bI = 2;
            bJ = 2;
            //para que si selecciona el hueco no salte error
            if (btn11.Text != "")
            {
                num = int.Parse(btn11.Text);
                //verifica si se puede mover el boton
                moverFicha();
                //si la bandera cambia a falso entonces significa que la ficha si se movió
            }
            if (listo == false)
            {
                btn11.Text = "";
                listo = true;
            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            //boton 12
            bI = 2;
            bJ = 3;
            //para que si selecciona el hueco no salte error
            if (btn12.Text != "")
            {
                num = int.Parse(btn12.Text);
                //verifica si se puede mover el boton
                moverFicha();
                //si la bandera cambia a falso entonces significa que la ficha si se movió
            }
            if (listo == false)
            {
                btn12.Text = "";
                listo = true;
            }
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            //boton 13
            bI = 3;
            bJ = 0;
            //para que si selecciona el hueco no salte error
            if (btn13.Text != "")
            {
                num = int.Parse(btn13.Text);
                //verifica si se puede mover el boton
                moverFicha();
                //si la bandera cambia a falso entonces significa que la ficha si se movió
            }
            if (listo == false)
            {
                btn13.Text = "";
                listo = true;
            }
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            //boton 14
            bI = 3;
            bJ = 1;
            //para que si selecciona el hueco no salte error
            if (btn14.Text != "")
            {
                num = int.Parse(btn14.Text);
                //verifica si se puede mover el boton
                moverFicha();
                //si la bandera cambia a falso entonces significa que la ficha si se movió
            }
            if (listo == false)
            {
                btn14.Text = "";
                listo = true;
            }
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            //boton 15
            bI = 3;
            bJ = 2;
            //para que si selecciona el hueco no salte error
            if (btn15.Text != "")
            {
                num = int.Parse(btn15.Text);
                //verifica si se puede mover el boton
                moverFicha();
                //si la bandera cambia a falso entonces significa que la ficha si se movió
            }
            if (listo == false)
            {
                btn15.Text = "";
                listo = true;
            }
        }

        private void btnHueco_Click(object sender, EventArgs e)
        {
            //boton hueco
            bI = 3;
            bJ = 3;
            //para que si selecciona el hueco no salte error
            if (btnHueco.Text != "")
            {
                num = int.Parse(btnHueco.Text);
                //verifica si se puede mover el boton
                moverFicha();
                //si la bandera cambia a falso entonces significa que la ficha si se movió
            }
            if (listo == false)
            {
                btnHueco.Text = "";
                listo = true;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //boton 2
            bI = 0;
            bJ = 1;
            //para que si selecciona el hueco no salte error
            if (btn2.Text != "")
            {
                num = int.Parse(btn2.Text);
                //verifica si se puede mover el boton
                moverFicha();
                //si la bandera cambia a falso entonces significa que la ficha si se movió
            }
            if (listo == false)
            {
                btn2.Text = "";
                listo = true;
            }
        }

        bool listo = true;

        private void btn1_Click(object sender, EventArgs e)
        {
            //boton 1
            bI = 0;
            bJ = 0;
            //para que si selecciona el hueco no salte error
            if (btn1.Text != "")
            {
                num = int.Parse(btn1.Text);
                //verifica si se puede mover el boton
                moverFicha();
                //si la bandera cambia a falso entonces significa que la ficha si se movió
            }
            if (listo == false)
            {
                btn1.Text = "";
                listo = true;
            }
        }
        #endregion //botones
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();

            for (int i = 0; i < vectorFichas.Length; i++)
            {
                // Generar un número aleatorio entre 0 y la longitud del vector - 1
                int randomIndex = rnd.Next(vectorFichas.Length);

                // Intercambiar los elementos en las posiciones i y randomIndex
                int temp = vectorFichas[i];
                vectorFichas[i] = vectorFichas[randomIndex];
                vectorFichas[randomIndex] = temp;
            }
            //****PRUEBA****
            //txtTitulo.Text = "";
            // Imprimir el vector mezclado
            //foreach (int num in vectorFichas)
            //{
            //    txtTitulo.Text += num.ToString() + "-";
            //}

            //Relleno la matriz con los números revueltos del vector
            itera = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (vectorFichas[itera] == 0)
                    {
                        //guardo las posiciones del hueco
                        hI = i;
                        hJ = j;
                        matrizTablero[i, j] = "";
                        itera++;
                    }
                    else
                    {
                        //relleno matriz
                        matrizTablero[i, j] = vectorFichas[itera].ToString();
                        itera++;
                    } 
                }
            }

            //asignos las fichas a cada boton con relacion a la matriz en memoria
            btn1.Text = matrizTablero[0, 0];
            btn2.Text = matrizTablero[0, 1];
            btn3.Text = matrizTablero[0, 2];
            btn4.Text = matrizTablero[0, 3];
            //***************************************
            btn5.Text = matrizTablero[1, 0];
            btn6.Text = matrizTablero[1, 1];
            btn7.Text = matrizTablero[1, 2];
            btn8.Text = matrizTablero[1, 3];
            //***************************************
            btn9.Text = matrizTablero[2, 0];
            btn10.Text = matrizTablero[2, 1];
            btn11.Text = matrizTablero[2, 2];
            btn12.Text = matrizTablero[2, 3];
            //***************************************
            btn13.Text = matrizTablero[3, 0];
            btn14.Text = matrizTablero[3, 1];
            btn15.Text = matrizTablero[3, 2];
            btnHueco.Text = matrizTablero[3, 3];
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //titulo
            txtTitulo.Text = "Tramposo";
        }

    }
}
