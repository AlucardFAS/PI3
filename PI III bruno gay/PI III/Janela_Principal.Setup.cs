﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_III
{
    partial class Janela_Principal
    {
        private int atendente;
        private char[] postos;
        private char[] atendente_pos;
        private int troca;
        private int postoA;
        private int postoB;
        private int postoC;
        private int postoD;
        private int postoE;
        private int postoF;
        private int postoG;
        private int postoH;
        private int postoI;
        private int postoJ;


        private void CarregarSetup()
        {
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\fernando.asilva10\Desktop\WindowsFormsApplication2\setup\Setup.txt");//busca o arquivo de texto
            int counter = 0;
            postos = new char[20];
            string line;//cria uma string que recebe as linhas
            string[] setup;//declara o vetor de setup
            setup = new string[50];//declara que setup terá 9 posições
            while ((line = file.ReadLine()) != null)//laço que le linha por linha
            {
                if (counter == 0)
                {
                    atendente = Convert.ToInt32(line);
                    //MessageBox.Show(Convert.ToString(atendente));
                }
                else if (counter == 1)
                {
                    postos = line.ToCharArray();
                }
                else if (counter == 2)
                {
                    atendente_pos = line.ToCharArray();
                }
                else if (counter == 3)
                {
                    var vetor_aux = line.ToCharArray();
                    char[] numfinal;
                    numfinal = new char[10];
                    int condicional = 0, k = 0;
                    for (int i = 0; i < (vetor_aux.Length); i++)
                    {
                        if (condicional == 1)
                        {
                            numfinal[k] = vetor_aux[i];
                            k++;
                        }
                        else if (vetor_aux[i] == ':')
                        {
                            condicional = 1;
                        }
                    }
                    string temp = new string(numfinal);
                    troca = Convert.ToInt32(temp);
                    //MessageBox.Show(Convert.ToString(troca));
                }
                else if(counter==4)
                {
                    var vetor_aux = line.ToCharArray();
                    char[] numfinal;
                    numfinal = new char[10];
                    int k = 0,condicional = 0;
                    for (int i = 0; i < (vetor_aux.Length); i++)
                    {
                        if(vetor_aux[i] == ':')
                        {
                            condicional = 1;
                        }

                        else if(i>0 && condicional != 1)
                        {
                            numfinal[k] = vetor_aux[i];
                            k++;
                        }
                    }

                    string temp = new string(numfinal);
                    postoA = Convert.ToInt32(temp);
                    //MessageBox.Show(Convert.ToString(postoA));
                }
                else if (counter == 5)
                {
                    var vetor_aux = line.ToCharArray();
                    char[] numfinal;
                    numfinal = new char[10];
                    int k = 0, condicional = 0;
                    for (int i = 0; i < (vetor_aux.Length); i++)
                    {
                        if (vetor_aux[i] == ':')
                        {
                            condicional = 1;
                        }

                        else if (i > 0 && condicional != 1)
                        {
                            numfinal[k] = vetor_aux[i];
                            k++;
                        }
                    }

                    string temp = new string(numfinal);
                    postoB = Convert.ToInt32(temp);
                    //MessageBox.Show(Convert.ToString(postoB));
                }
                else if (counter == 6)
                {
                    var vetor_aux = line.ToCharArray();
                    char[] numfinal;
                    numfinal = new char[10];
                    int k = 0, condicional = 0;
                    for (int i = 0; i < (vetor_aux.Length); i++)
                    {
                        if (vetor_aux[i] == ':')
                        {
                            condicional = 1;
                        }

                        else if (i > 0 && condicional != 1)
                        {
                            numfinal[k] = vetor_aux[i];
                            k++;
                        }
                    }


                    string temp = new string(numfinal);
                    postoC = Convert.ToInt32(temp);
                    //MessageBox.Show(Convert.ToString(postoC));
                }
                else if (counter == 7)
                {
                    var vetor_aux = line.ToCharArray();
                    char[] numfinal;
                    numfinal = new char[10];
                    int k = 0, condicional = 0;
                    for (int i = 0; i < (vetor_aux.Length); i++)
                    {
                        if (vetor_aux[i] == ':')
                        {
                            condicional = 1;
                        }

                        else if (i > 0 && condicional != 1)
                        {
                            numfinal[k] = vetor_aux[i];
                            k++;
                        }
                    }


                    string temp = new string(numfinal);
                    postoD = Convert.ToInt32(temp);
                    //MessageBox.Show(Convert.ToString(postoD));
                }
                else if (counter == 8)
                {
                    var vetor_aux = line.ToCharArray();
                    char[] numfinal;
                    numfinal = new char[10];
                    int k = 0, condicional = 0;
                    for (int i = 0; i < (vetor_aux.Length); i++)
                    {
                        if (vetor_aux[i] == ':')
                        {
                            condicional = 1;
                        }

                        else if (i > 0 && condicional != 1)
                        {
                            numfinal[k] = vetor_aux[i];
                            k++;
                        }
                    }


                    string temp = new string(numfinal);
                    postoE = Convert.ToInt32(temp);
                    //MessageBox.Show(Convert.ToString(postoE));
                }
                else if (counter == 9)
                {
                    var vetor_aux = line.ToCharArray();
                    char[] numfinal;
                    numfinal = new char[10];
                    int k = 0, condicional = 0;
                    for (int i = 0; i < (vetor_aux.Length); i++)
                    {
                        if (vetor_aux[i] == ':')
                        {
                            condicional = 1;
                        }

                        else if (i > 0 && condicional != 1)
                        {
                            numfinal[k] = vetor_aux[i];
                            k++;
                        }
                    }


                    string temp = new string(numfinal);
                    postoF = Convert.ToInt32(temp);
                    //MessageBox.Show(Convert.ToString(postoG));
                }
                else if (counter == 10)
                {
                    var vetor_aux = line.ToCharArray();
                    char[] numfinal;
                    numfinal = new char[10];
                    int k = 0, condicional = 0;
                    for (int i = 0; i < (vetor_aux.Length); i++)
                    {
                        if (vetor_aux[i] == ':')
                        {
                            condicional = 1;
                        }

                        else if (i > 0 && condicional != 1)
                        {
                            numfinal[k] = vetor_aux[i];
                            k++;
                        }
                    }


                    string temp = new string(numfinal);
                    postoG = Convert.ToInt32(temp);
                    //MessageBox.Show(Convert.ToString(postoG));
                }
                else if (counter == 11)
                {
                    var vetor_aux = line.ToCharArray();
                    char[] numfinal;
                    numfinal = new char[10];
                    int k = 0, condicional = 0;
                    for (int i = 0; i < (vetor_aux.Length); i++)
                    {
                        if (vetor_aux[i] == ':')
                        {
                            condicional = 1;
                        }

                        else if (i > 0 && condicional != 1)
                        {
                            numfinal[k] = vetor_aux[i];
                            k++;
                        }
                    }


                    string temp = new string(numfinal);
                    postoH = Convert.ToInt32(temp);
                    //MessageBox.Show(Convert.ToString(postoH));
                }
                else if (counter == 12)
                {
                    var vetor_aux = line.ToCharArray();
                    char[] numfinal;
                    numfinal = new char[10];
                    int k = 0, condicional = 0;
                    for (int i = 0; i < (vetor_aux.Length); i++)
                    {
                        if (vetor_aux[i] == ':')
                        {
                            condicional = 1;
                        }

                        else if (i > 0 && condicional != 1)
                        {
                            numfinal[k] = vetor_aux[i];
                            k++;
                        }
                    }


                    string temp = new string(numfinal);
                    postoI = Convert.ToInt32(temp);
                    //MessageBox.Show(Convert.ToString(postoI));
                }
                else if (counter == 13)
                {
                    var vetor_aux = line.ToCharArray();
                    char[] numfinal;
                    numfinal = new char[10];
                    int k = 0, condicional = 0;
                    for (int i = 0; i < (vetor_aux.Length); i++)
                    {
                        if (vetor_aux[i] == ':')
                        {
                            condicional = 1;
                        }

                        else if (i > 0 && condicional != 1)
                        {
                            numfinal[k] = vetor_aux[i];
                            k++;
                        }
                    }


                    string temp = new string(numfinal);
                    postoJ = Convert.ToInt32(temp);
                    //MessageBox.Show(Convert.ToString(postoJ));
                }


                counter++;//aumenta o contador para ler e armazenar novas linhas até o fim do arquivo(!=null)
            }

            MessageBox.Show("Setup Carregado");
            file.Close();//fecha o txt
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Janela_Principal
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Janela_Principal";
            this.Load += new System.EventHandler(this.Janela_Principal_Load);
            this.ResumeLayout(false);

        }

        private void Janela_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
