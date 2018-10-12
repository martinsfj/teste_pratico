using System;

namespace Teste_Pratico
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayUtil vetUtil = new ArrayUtil();
            int[] vet1 = new int[5] { 1, 2, 4, 5, 7 };
            int[] vet2 = new int[4] { 2, 3, 5, 6 };
            int[] vet3 = new int[5] { 1, 3, 4, 2, 5 };
            

            int[] vet = vetUtil.mesclaVetor(vet1, vet2);
            Console.WriteLine("Teste 1");
            Console.WriteLine("Vetor 1:");
            vetUtil.imprimeVetor(vet1);
            Console.WriteLine("Vetor 2:");
            vetUtil.imprimeVetor(vet2);
            Console.WriteLine("Imprimindo vetores mesclados em ordem crescente:");
            vetUtil.imprimeVetor(vet);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Teste 2");
            Console.WriteLine("Valores:");
            vetUtil.imprimeVetor(vet3);
            Console.WriteLine("Imprimindo segundo maior valor do vetor: ");
            Console.WriteLine("Segundo maior: "+vetUtil.retornaSegundoMaior(vet3));
            Console.WriteLine();
            Console.WriteLine();

            String mensagem = "33 8 88 777 66 0 9 33 22 0 33 0 7777 666 333 8 9 2 777 33 0 7777 666 555 88 8 444 666 66";
            Sms sms = new Sms();
            Console.WriteLine("Teste 3");
            Console.WriteLine("String:");
            Console.WriteLine(mensagem);
            Console.WriteLine("Mensagem interpretada: ");
            String mensagemInterpretada = sms.interpretaTexto(mensagem);
            Console.Write(mensagemInterpretada);

           
            Console.ReadLine();
        }
    }
}
