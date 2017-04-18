﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteFormulas
{
    partial class Program
    {
        static void processo(Queue<Pessoas>[] fila, Pessoas[] pessoas, GuichesSetup[] guiches, double tempo)
        {
            int turno = 1;
            //obtendo a quantidade de guiches

            int quantidadeFilas = 0;
            int i = 0;
            while (i < guiches.Length)
            {
                i += guiches[i].guichesIguais;
                quantidadeFilas++;
            }

            i = 0;

            //esse laço vai até entrar todas as pessoas nas filas
            while (i < pessoas.Length)
            {
                //jogando as pessoas na fila do guiche A (ou dos guiches A)
                while (pessoas[i].chegada == turno)
                {
                    fila[0].Enqueue(pessoas[i]);
                    i++;
                    if (i >= pessoas.Length) break; //quando o i for maior do que a quantidade de pessoas
                }

                //jogando as primeiras pessoas das filas nos guiches
                atualizarFilas(guiches, fila);

                //atualizando os guiches e jogando as pessoas pras respectivas filas
                atualizarGuiches(guiches, fila);

                //jogando as primeiras pessoas das filas nos guiches
                atualizarFilas(guiches, fila);


                turno = contarTurnos(tempo, turno);
            }


            //esse laço vai até esvaziar todos os guiches, assim, terminando
            Boolean continuar = true;
            while (continuar)
            {

                //jogando as primeiras pessoas das filas nos guiches
                atualizarFilas(guiches, fila);

                //atualizando os guiches e jogando as pessoas pras respectivas filas
                atualizarGuiches(guiches, fila);

                //jogando as primeiras pessoas das filas nos guiches
                atualizarFilas(guiches, fila);



                continuar = false;
                for (int j = 0; j < guiches.Length; j++) if (guiches[j].vazio == false) continuar = true;    //testando se todos os guiches estão vazios, se algum não estiver vazio, então continuar se torna verdade

                turno = contarTurnos(tempo, turno);
            }

            Console.WriteLine("Turno terminado: " + turno);
        }

        static void atualizarGuiches(GuichesSetup[] guiches, Queue<Pessoas>[] fila)
        {
            int quantidadeGuiches = guiches.Length;
            char proximoGuiche;

            for (int i = 0; i < guiches.Length; i++)
            {
                if (guiches[i].vazio == false && guiches[i].ultimoTurno < guiches[i].turnosNecessarios)
                {
                    guiches[i].ultimoTurno++;
                }
                else if (guiches[i].vazio == false && guiches[i].ultimoTurno >= guiches[i].turnosNecessarios)
                {
                    guiches[i].vazio = true;
                    guiches[i].ultimoTurno = 1;
                    guiches[i].pessoaDentro.atualGuiche++;

                    //testando se a pessoa ainda tem guiches pra ir, se não, ela cai no esquecimento e segue o jogo
                    if (guiches[i].pessoaDentro.atualGuiche >= guiches[i].pessoaDentro.guiches.Length) return;
                    //verificando o proximo guiche que ela tem que ir
                    proximoGuiche = guiches[i].pessoaDentro.guiches[guiches[i].pessoaDentro.atualGuiche];

                    //achando o guiche que a pessoa tem de ir
                    int j = 0;
                    while (guiches[j].guiche != proximoGuiche) j++;

                    //enviando a pessoa para a fila
                    fila[j].Enqueue(guiches[i].pessoaDentro);
                }
            }
        }
        static void atualizarFilas(GuichesSetup[] guiches, Queue<Pessoas>[] fila)
        {
            for (int j = 0; j < guiches.Length; j++)
            {
                for (int k = 0; k < guiches[j].guichesIguais; k++)
                {
                    if (guiches[j + k].atendente == true && guiches[j + k].vazio == true && fila[j].Count != 0)
                        entrarGuiches(fila[j].Dequeue(), guiches[j + k]);
                }
                j += guiches[j].guichesIguais - 1;
            }
        }
        static int contarTurnos(double tempo, int turno)
        {
            turno++;
            // MessageBox.Show("turno: "+turno);
            return turno;
        }
        private static void entrarGuiches(Pessoas pessoa, GuichesSetup guiche)
        {
            guiche.vazio = false;
            guiche.pessoaDentro = pessoa;
        }
    }

}
