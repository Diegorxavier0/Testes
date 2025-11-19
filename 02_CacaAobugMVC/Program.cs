using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using _02_CacaAobugMVC.Controller;
using _02_CacaAobugMVC.Model;

namespace _02_CacaAobugMVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlunoController controller = new AlunoController();
            var validacao = controller.GetValidaService(); // obtém a instância do ValidaService do controller


            while (true)
            {
                Console.Clear();
                Console.WriteLine("==== Sistema de Notas - Caça ao Bug MVC ====");

                string nome;

                while (true)
                {
                    while (true)
                    {
                        Console.Write("Informe o nome do Aluno: ");
                        nome = Console.ReadLine();

                        if (validacao.ValidarNome(nome, out string msgErro))
                            break;

                        Console.WriteLine($"Nome Inválido! {msgErro}");
                    }

                    double nota1 = Program.LerNota("1ª", validacao);
                    double nota2 = Program.LerNota("2ª", validacao);
                    double nota3 = Program.LerNota("3ª", validacao);

                    // cria o aluno e enviar para o controller

                    var aluno = new Aluno()
                    {
                        Nome = nome,
                        Nota1 = nota1,
                        Nota2 = nota2,
                        nota3 = nota3
                    };

                    if(controller.adicionaAluno(aluno, out string mensagemErro))
                    {
                        Console.WriteLine($"\nAluno {aluno.Nome} cadastrado com sucesso!");
                        Console.WriteLine($"Média: {aluno.Media:F2} - Situação: {aluno.situacao}");
                    }
                    else
                    {
                        Console.WriteLine($"\nErro ao cadastrar aluno: {mensagemErro}");
                    }

                    Console.Write("Deseja cadastrar outro Aluno? (S/N)");

                    if (Console.ReadLine().ToUpper() != "S") // ToUpper converte para maiúsculo
                    {
                        break;
                    }

                    
                }
                //estastísticas de aprovação
                Console.WriteLine($"Taxa de aprovação{controller.ObterTaxaAprovacao():f2}%");

                Console.Write("Deseja reiniciar o sistema? (S/N)");

                if (Console.ReadLine().ToUpper() != "S")
                {
                    break;// sai do loop principal
                }
            }
        }

        public static double LerNota(string nota, ValidaService validacao)
        {
            while (true)
            {
                Console.Write($"Informe a {nota} Nota: ");
                string entrada = Console.ReadLine();
                //return double.Parse(entrada);
                if(validacao.ConverteNota(entrada, out double valorNota))
                {
                    return valorNota;
                }
                else
                {
                    Console.WriteLine("Nota inválida! Informe uma nota entre 0 e 10 (use vírgula ou ponto para decimais).");
                }
            }
        }
    }
}
