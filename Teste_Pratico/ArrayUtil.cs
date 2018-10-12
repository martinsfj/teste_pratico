using System;
using System.Collections.Generic;
using System.Text;

namespace Teste_Pratico
{
    class ArrayUtil
    {
        /*Método que realiza a mescla de dois vetores ordenados
         * salvando em um novo vetor mantendo a ordenação em ordem
         * crescente*/
        public int[] mesclaVetor(int[] vet1,int[] vet2)
        {

            int[] vet = new int[vet1.Length + vet2.Length];
            int aux;

            for(int i = 0; i < vet1.Length; i++)
            {
                vet[i] = vet1[i];
            }

            aux = vet1.Length;
            for(int i = 0; i < vet2.Length; i++)
            {
                vet[aux] = vet2[i];
                aux++;
            }
            vet = ordenaVetor(vet);
            
            
            return vet;
            

        }
        /*Metodo que realiza a ordenação de um vetor recebido como
         * parâmetro em ordem crescente*/
        public int[] ordenaVetor(int[] vetDesordenado)
        {
            int[] vet = vetDesordenado;
            
            int aux;
            
            for (int i = 0; i < vet.Length; i++)
            {
                for (int j = i + 1; j < vet.Length; j++)
                {
                    if (vet[i] > vet[j])
                    {
                        aux = vet[j];
                        vet[j] = vet[i];
                        vet[i] = aux;
                    }
                }
            }
            return vet;
        }
        /*Método que recebe um vetor como parâmetro e retorna o segundo
         * maior valor contido no mesmo*/
        public int retornaSegundoMaior(int[] vetDesordenado)
        {
            int segundoMaiorValor;
            bool encontrou = false; ;
            int[] vet = vetDesordenado;
            ordenaVetor(vet);
            segundoMaiorValor = vet[vet.Length - 1];
            for(int i = vet.Length-1; i > 0; i--)
            {
                if(vet[i-1] < vet[i])
                {
                    segundoMaiorValor = vet[i - 1];
                    encontrou = true;
                }
                if(encontrou == true)
                {
                    i = 0;
                }
            }
            if (!encontrou)
            {
                Console.WriteLine("Todos os campos do vetor possuem o valor: " + segundoMaiorValor);
            }
            return segundoMaiorValor;
        }
        //Método que imprime os valores do vetor no console
        public void imprimeVetor(int[] vet)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }
            Console.WriteLine("");

        }
    }

}
