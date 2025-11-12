using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_CacaAobugMVC.Model
{
    class ValidaService
    {

        //padrão
        //mínimo 3 caracteres, sem caracteres repetidos 3x seguidas, sem espaços duplos
        private readonly string padraoNome = @"^(?!.*([A-Za-zÀ-ÖØ-öø-ÿ])\1\1)(?!.* {2,})(?=.{3,}).+$";

        //padrão
        //mínimo 3 caracteres, sem caracteres repetidos 3x seguidas, sem espaços duplos
        private readonly string padraoNota = @"^(?:10(?:[.,]0+)?|[0-9](?:[.,][0-9]+)?)$";
        public bool ValidarNome(string nome, out string mensagemErro)
        {
            mensagemErro = string.Empty;
            if(string.IsNullOrEmpty(nome))
            {
                mensagemErro = "Nome vazio";
                return false;
            }

            if(Regex.IsMatch(nome.Trim(), padraoNome))
            {
               mensagemErro = "-Minímo 3 caracteres\n-Não pode ter 3 caracteres repetidos 3x seguidas\n-Não pode ter espaços duplos";
                return false;
            }
            return true;
        }

        public bool ConverteNota(string notaEntrada, out double nota)
        {
            nota = -1;

            if(string.IsNullOrEmpty(notaEntrada))
            {
                return false;
            }

            //replace substitui vírgula por ponto
            var notaDecimalVirgula = notaEntrada.Replace(',', '.');
            if (!Regex.IsMatch(notaDecimalVirgula, padraoNota))
            {
                return false;
            }

            if(!double.TryParse(notaDecimalVirgula,System.Globalization.NumberStyles.Number,System.Globalization.CultureInfo.InvariantCulture, out nota))
            {
                if(nota < 0 || nota > 10)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
