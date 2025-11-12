using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CacaAobugMVC.Model
{
    class AlunoService
    {
        public double CalcularMedia(double n1, double n2, double n3)
        {
            return (n1 + n2 + n3) / 3;
        }

        public string ObterSituacao(double media)
        {
            if (media >= 7)
            {
                return "Aprovado";
            }
            else if (media >= 5)
            {
                return "Em Exame Final";
            }
            else
            {
                return "Reprovado";
            }
        }
        public double CaucularTaxaAprovacao(int totalAlunos, int alunosAprovados)
        {
            //cast para double para evitar divisão inteira
            return (alunosAprovados / (double)totalAlunos) * 100;
        }
    }
}
