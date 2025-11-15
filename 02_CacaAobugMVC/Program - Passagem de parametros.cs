//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _02_CacaAobugMVC
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("*** Passagem de parâmetro por Valor ***");
//            //Passa o conteúdo da variável de origem para a variavel de destino
//            //O método de destino não altera o valor da váriavel do método de origem
//            double valor = 10;
//            if(PassagemParametroValor(valor)) 
//            Console.WriteLine($"Valor do método PassagemParametroValor{valor}");

//            Console.WriteLine("\n\n*** Passagem de parâmetro por Referência REF ***");
//            //Passa o endereço de memória da variável de origem para a variável de destino
//            //A variável de origem pode ser inicializada
//            //O método de destino pode alterar o valor da variável do método de origem
//            double valor1 = 10;
//            if(PassagemParamentroReferenciaRef(ref valor1))
//                Console.WriteLine($"Valor do método Main-> PassagemParametroReferenciaRef {valor1}");

//            Console.WriteLine("\n\n*** Passagem de parâmetro por Referência OUT ***");
//            //Passa o endereço de memória da variável de origem 
//            double valor2;
//            if (PassagemParamentroReferenciaOut(out valor2))
//                Console.WriteLine($"Valor do método Main-> PassagemParametroReferenciaOut {valor2}");

//            Console.WriteLine("\n\n*** Passagem de parâmetro por Referência IN ***");
//            double valor3= 100;
//            if (PassagemParamentroReferenciaIN(in valor3))
//                Console.WriteLine($"Valor do método Main-> PassagemParametroReferenciaIN {valor3}");
//        }
//        public static bool PassagemParametroValor(double valor)
//        {
//            valor = valor * 10;
//            Console.WriteLine($"Valor do método PassagemParametroValor{valor}");
//            return true;
//        }

//        public static bool PassagemParamentroReferenciaRef(ref double valor1)
//        { 
//        valor1= valor1 *10;
//            Console.WriteLine($"Valor do método PassagemParamentroReferenciaRef {valor1}");
//            return true;
//        }

//        public static bool PassagemParamentroReferenciaOut(out double valor2)
//        {
//            valor2 = 10;
//            valor2 = valor2 * 10;
//            Console.WriteLine($"Valor do método PassagemParamentroReferenciaRef {valor2}");
//            return true;
//        }

//        public static bool PassagemParamentroReferenciaIN(in double valor3)
//        {
//            //valor3 = 10;
//            //valor3 = valor3 * 10;

//            //in linha 
//            Console.WriteLine($"Valor do método PassagemParamentroReferenciaRef {valor3}");
//            return true;
//        }


//    }
//}
