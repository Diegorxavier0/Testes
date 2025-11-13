using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_CacaAobugMVC.Model;

namespace _02_CacaAobugMVC.Controller
{
    public class AlunoController
    {
        private readonly ValidaService validaService;
        private readonly AlunoService alunoService;
        private readonly List<Aluno> alunos;

        public AlunoController()
        {
            validaService = new ValidaService();
            alunoService = new AlunoService();
            alunos = new List<Aluno>();

        }

        public bool adicionaAluno(Aluno aluno, out string mensagemErro)
        {
            mensagemErro = string.Empty;
            if (!validaService.ValidarNome(aluno.Nome, out string ErroNome))
            {
                mensagemErro = $" Nome Inválido{ErroNome}";
                return false;
            }

            aluno.Media = alunoService.CalcularMedia(aluno.Nota1, aluno.Nota2, aluno.nota3);

            aluno.situacao = alunoService.ObterSituacao(aluno.Media);

            alunos.Add(aluno);//adiciona o aluno na lista
            return true;

        }

        //=> expressão lambda 
        public IReadOnlyList<Aluno> ObterAlunos() => alunos.AsReadOnly();

        public double ObterTaxaAprovacao()
        {
            int totalAlunos = alunos.Count;
            //FindAll retorna uma lista com todos os alunos que atenderem a condição, substitui um "FOR"
            int totalAprovados = alunos.FindAll(a => a.situacao == "Aprovado").Count;
            return alunoService.CaucularTaxaAprovacao(totalAlunos, totalAprovados);

        }

        public ValidaService GetValidaService() => validaService;
        //=> expressão lambda substitui um "return"

    }
}

