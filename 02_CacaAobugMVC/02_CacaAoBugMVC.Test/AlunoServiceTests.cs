using _02_CacaAobugMVC.Model;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter;

namespace _02_CacaAoBugMVC.Test
{
    [TestClass]
    public class AlunoServiceTests
    {
        [TestMethod]
        public void CalcularMedia_DeveRetornarMediaCorreta()
        {
            /*Arrange(preparar)
            cria objetos
            define variáveis
            simula dependências
            monta os dados de entrada*/
            var service = new AlunoService();//instance of the service

            //Act(Agir) Aqui você executa a ação que está sendo testada:
            var resultado = service.CalcularMedia(8.0, 7.5, 6.5);

            // Assert(Afirmar) Aqui você confere se o resultado é o esperado:
            Assert.AreEqual(7.33, resultado);//AreEqual compara o valor esperado com o valor real
            //Math.Round arredonda o valor para 2 casas decimais

            //Não ajustar o teste mas sim ajustar o código fonte 

        }

        [TestMethod]
        public void CalcularMedia_DeveRetornarErro()
        {
            /*Arrange(preparar)
            cria objetos
            define variáveis
            simula dependências
            monta os dados de entrada*/
            var service = new AlunoService();//instance of the service

            //Act(Agir) Aqui você executa a ação que está sendo testada:
            var resultado = service.CalcularMedia(6.0, 5.5, 3.5);

            // Assert(Afirmar) Aqui você confere se o resultado é o esperado:
            Assert.AreNotEqual(7.33, resultado);//AreEqual compara o valor esperado com o valor real
            //AreNotEqual compara o valor esperado com o valor real e espera que sejam diferentes

            //Não ajustar o teste mas sim ajustar o código fonte 

        }

        [TestMethod]
        public void ObterSituacao_DeveRetornarAprovado()
        {
            //Arrange
            var service = new AlunoService();
            //Act
            var resultadoAprovado = service.ObterSituacao(7.0);
            //Assert
            Assert.AreEqual("Aprovado", resultadoAprovado);
        }

        [TestMethod]
        public void ObterSituacao_DeveRetornarEmExameFinal()
        {
            //Arrange
            var service = new AlunoService();
            //Act
            var resultadoEmExameFinal = service.ObterSituacao(5.5);
            //Assert
            Assert.AreEqual("Em Exame Final", resultadoEmExameFinal);
        }

        [TestMethod]
        public void ObterSituacao_DeveRetornarReprovado()
        {
            //Arrange
            var service = new AlunoService();
            //Act
            var resultadoReprovado = service.ObterSituacao(4.0);
            //Assert
            Assert.AreEqual("Reprovado", resultadoReprovado);
        }

        [TestMethod]
        public void ObterTaxaAprovacao_DeveRetornarTaxaCorreta()
        {
            //Arrange
            var service = new AlunoService();
            //Act
            var taxaAprovacao = service.CaucularTaxaAprovacao(10, 7);//10 alunos, 7 aprovados
            //Assert
            Assert.AreEqual(70.0, taxaAprovacao);
        }




    }
}
