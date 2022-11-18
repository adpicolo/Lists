

using ListaFuncionarios;
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Quantos funcionários irá registrar? ");
int numeroDeFuncionarios = int.Parse(Console.ReadLine());

List<Funcionarios> lista = new List<Funcionarios>();

for(int i=1; i <= numeroDeFuncionarios; i++)
{
    Console.WriteLine("Funcionario # " + i + ": ");
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Salário: ");
    double salario = double.Parse(Console.ReadLine());

    lista.Add(new Funcionarios(id, nome, salario));
    Console.WriteLine();


}


Console.Write("Entre com o ID do funcionário que terá aumento de salário: ");
int searchId = int.Parse(Console.ReadLine());

Funcionarios func = lista.Find(x => x.Id == searchId);
if(func != null)
{
    Console.WriteLine("Entre com a porcentagem: ");
    float porcentagem = float.Parse(Console.ReadLine());
    func.AumentoDeSalario(porcentagem);

}
else
{
    Console.WriteLine("Esse ID não existe!");
}


Console.WriteLine();
Console.WriteLine("Lista atualizada de funcionários: ");
foreach(Funcionarios nomesNaLista in lista)
{
    Console.WriteLine(nomesNaLista);
}




