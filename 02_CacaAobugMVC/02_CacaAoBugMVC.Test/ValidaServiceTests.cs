using Microsoft.VisualStudio.TestTools.UnitTesting;
using _02_CacaAobugMVC.Model;
using System.Security.Cryptography.X509Certificates;

namespace _02_CacaAobugMVC.Test
{
    [TestClass]
    public class ValidaServiceTests
    {
        [TestMethod]
        public void ValidarNome_DeveRetornarTrue_QuandoNomeValido()
        {
            // Arrange
            var service = new ValidaService();
            string mensagemErro;

            // Act
            var resultado = service.ValidarNome("Diego", out mensagemErro);//precisa dos 2 parâmetros para funcionar

            // Assert
            Assert.IsTrue(resultado);
            Assert.AreEqual("", mensagemErro);
        }

        [TestMethod]
        public void ValidarNome_QuandoVazio_DeveRetornarFalse()
        {
            // Arrange
            var service = new ValidaService();
            string mensagemErro;

            // Act
            var resultado = service.ValidarNome("", out mensagemErro);

            // Assert
            Assert.IsFalse(resultado);
            Assert.AreNotEqual(mensagemErro, "");//valida a mensagem de erro 
           
        }

        [TestMethod]
        public void ValidarNome_QuandoMenosDe3Letras_DeveRetornarFalse()
        {
            var service = new ValidaService();
            string mensagemErro;

            var resultado = service.ValidarNome("Di", out mensagemErro);

            Assert.IsFalse(resultado);//Aqui verifica se retorna False
            Assert.AreNotEqual(mensagemErro, "");
        }

        [TestMethod]
        public void ValidarNome_QuandoTiverCom3LetrasIguaisConsecutivas_DeveRetornarFalse()
        {
            var service = new ValidaService();
            string mensagemErro;

            var resutado = service.ValidarNome("ddd", out mensagemErro);

            Assert.IsFalse(resutado);
            Assert.AreNotEqual(mensagemErro, "");
        }

        [TestMethod] 
        public void ValidarNome_QuandoEstiverContendoEspacoDuplo_DeveRetornarFalse()
        {  
            var service = new ValidaService();
           string mensagemErro;

            var resultado = service.ValidarNome("D  iego", out mensagemErro);

            Assert.IsFalse(resultado);
            Assert.AreNotEqual(mensagemErro, "");

        }

        [TestMethod]
        public void ValidarNome_QuandoContemCaracteresInvalidos_DeveRetornarFalse()
        {
            // Arrange
            var service = new ValidaService();
            string mensagemErro;

            // Act
            var resultado = service.ValidarNome("Di3go!", out mensagemErro);

            // Assert
            Assert.IsFalse(resultado);
            Assert.AreNotEqual(mensagemErro, "");

        }
            public void ConverteNota_NotaValida_DeveRetornarTrue()
            {
                var service = new ValidaService();
                double nota;

                var resultado = service.ConverteNota("7.5", out nota);

                Assert.IsTrue(resultado);
                Assert.AreEqual(7.5, nota);
            }

            [TestMethod]
            public void ConverteNota_NotaComVirgula_DeveRetornarTrue()
            {
                var service = new ValidaService();
                double nota;

                var resultado = service.ConverteNota("7,5", out nota);

                Assert.IsTrue(resultado);
                Assert.AreEqual(7.5, nota);
            }

            [TestMethod]
            public void ConverteNota_NotaComPonto_DeveRetornarTrue()
            {
                var service = new ValidaService();
                double nota;

                var resultado = service.ConverteNota("8.3", out nota);

                Assert.IsTrue(resultado);
                Assert.AreEqual(8.3, nota);
            }

            [TestMethod]
            public void ConverteNota_NotaForaDoIntervalo_DeveRetornarFalse()
            {
                var service = new ValidaService();
                double nota;

                var resultado = service.ConverteNota("12", out nota);

                Assert.IsFalse(resultado);
            }

            [TestMethod]
            public void ConverteNota_TextoInvalido_DeveRetornarFalse()
            {
                var service = new ValidaService();
                double nota;

                var resultado = service.ConverteNota("abc", out nota);

                Assert.IsFalse(resultado);
            }

            [TestMethod]
            public void ConverteNota_CampoVazio_DeveRetornarFalse()
            {
                var service = new ValidaService();
                double nota;

                var resultado = service.ConverteNota("", out nota);

                Assert.IsFalse(resultado);
            }

            [TestMethod]
            public void ConverteNota_FormatoNumericoIncorreto_DeveRetornarFalse()
            {
                var service = new ValidaService();
                double nota;

                var resultado = service.ConverteNota("7,5,2", out nota);

                Assert.IsFalse(resultado);
            }
        }
    }

