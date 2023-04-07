//Faça um programa que receba uma string nesse formato e grave em variáveis a quantidade de dados, de faces e o valor a acrescentar. Exiba os valores ao usuário.

string rolagem;
string dados;
string faces;
string bonus;

Console.WriteLine("---Rolagem Composta---\n");

Console.Write("Digite a rolagem desejada: ");
rolagem = Console.ReadLine()!;


// Começando do início, até a posição de "d"
dados = rolagem.Substring(0, rolagem.IndexOf("d"));

// Da primeira posição após "d", quantos caracteres houverem entre as posições "d" e "+"
faces = rolagem.Substring(rolagem.IndexOf("d") + 1, rolagem.IndexOf("+") - rolagem.IndexOf("d") - 1);

// Da posição após "+", até o final
bonus = rolagem.Substring(rolagem.IndexOf("+") + 1);

Console.WriteLine($"\n{dados} dado(s) de {faces} face(s) mais {bonus}");

Console.WriteLine("Entrada inválida. Certifique-se de digitar no formato correto (ex: 2d20+3).");

Console.WriteLine("Entrada vazia. Por favor, digite a rolagem desejada.");
























