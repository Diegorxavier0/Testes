using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CacaAobugMVC.Model
{
     class Aluno
    {
        //private string nome = string.Empty;//atributo
        ////metódos acessadores
        //public string GetNome()
        //{
        //    return nome;//retorna o atributo nome
        //}

        //public void SetNome(string nome)
        //{
        //    this.nome = nome;//this referencia o atributo da classe
        //}
        public string Nome { get; set; }= string.Empty;//propriedade autoimplementada
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double nota3 { get; set; }

        public string situacao = string.Empty;
    }
}
