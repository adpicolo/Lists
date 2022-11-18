
using System.Collections.Generic;

List<string> carros = new List<string>();
List<string> carros2 = new List<string>();


carros.Add("golf");
carros.Add("HRV");
carros.Add("Focus");
carros.Add("Tiggo");
//Add adiciona na sequencia; 

carros2.AddRange(carros);
//AddRange adiciona varios elementos de uma só vez em outra lista;




//carros.Clear() Limpa a lista;
//Contains - para buscar algo na lista - retorna TRUE se esta na lista e FALSE s enão estiver;

if (carros.Contains("HRV"))
{
    Console.WriteLine("Esta na lista");
}
else
{
    Console.WriteLine("NÃO ENCONTRADO");
}



foreach(string c in carros2)
{
    Console.WriteLine("Carro: {0}", c);
}

//IndexOff - retorna a posição do elemento pesquisado;
string car = "Tiggo";
int pos = 0;
pos = carros.IndexOf(car);
Console.WriteLine("carro {0} esta na posição {1} ", car, pos);