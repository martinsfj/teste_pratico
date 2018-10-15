using System;
using System.Collections.Generic;
using System.Text;

namespace Teste_Pratico
{
    class Sms
    {
        //tabela de valores que serão utilizados na interpretação da mensagem
        private static char zero = ' ';
        private static char[] dois = new char[3] { 'A', 'B', 'C' };
        private static char[] tres = new char[3] { 'D', 'E', 'F' };
        private static char[] quatro = new char[3] { 'G', 'H', 'I' };
        private static char[] cinco = new char[3] { 'J', 'K', 'L' };
        private static char[] seis = new char[3] { 'M', 'N', 'O' };
        private static char[] sete = new char[4] { 'P', 'Q', 'R','S'};
        private static char[] oito = new char[3] { 'T', 'U', 'V' };
        private static char[] nove = new char[4] { 'W', 'X', 'Y', 'Z'};

        String[] texto;
        String textoInterpretado;
        /*Método que recebe uma string como parâmetro, realiza a separação
         * de palavras contidas na string considerando os espaços ' ',
         * para cada palavra encontrada realiza a separação em caracteres
         * para que assim identifique qual o caractere e quantas vezes
         * o mesmo se repete e realize a interpretação da mensagem de
         * acordo com a tabela de valores definidos acima retornando
         uma nova string com a mensagem interpretada*/
        public String interpretaTexto(String frase)
        {
            texto = frase.Split(' ');
            int repeticoes;
            for(int i = 0; i < texto.Length; i++)
            {
                Char[] caractere = texto[i].ToCharArray();
               
                repeticoes = caractere.Length;
                

                if (caractere[0] == '0')
                {
                    textoInterpretado = textoInterpretado + zero;
                }
                if (caractere[0] == '2')
                {
                    textoInterpretado = textoInterpretado + dois[repeticoes - 1];
                }
                if (caractere[0] == '3')
                {
                    textoInterpretado = textoInterpretado + tres[repeticoes - 1];
                }
                if (caractere[0] == '4')
                {
                    textoInterpretado = textoInterpretado + quatro[repeticoes - 1];
                }
                if (caractere[0] == '5')
                {
                    textoInterpretado = textoInterpretado + cinco[repeticoes - 1];
                }
                if (caractere[0] == '6')
                {
                    textoInterpretado = textoInterpretado + seis[repeticoes - 1];
                }
                if (caractere[0] == '7')
                {
                    textoInterpretado = textoInterpretado + sete[repeticoes - 1];
                }
                 if(caractere[0] == '8')
                {
                    textoInterpretado = textoInterpretado + oito[repeticoes - 1];
                }
                if (caractere[0] == '9')
                {
                    textoInterpretado = textoInterpretado + nove[repeticoes - 1];
                }
              
            }
            return textoInterpretado;
        }
        

        
    }
}
