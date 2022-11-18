using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaFuncionarios
{
    internal class Funcionarios
    {
        public int Id { get; set; }
        public string Nome {get; set;}
        public double Salario { get; set; }

        public Funcionarios(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }
        public void AumentoDeSalario(double porcentagem)
        {
            Salario += Salario * porcentagem / 100.0;
        }


        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario.ToString("F2");
            

        }

    }



}
