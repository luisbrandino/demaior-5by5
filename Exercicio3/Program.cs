// 3- FAÇA UM ALGORITMO QUE LEIA A IDADE DE UMA PESSOA E INFORME SE ELA É MAIOR OU MENOR DE IDADE;

Console.Write("Informe sua idade: ");
int age = int.Parse(Console.ReadLine());

if (age < 0)
{
    Console.WriteLine("Idade não pode ser negativa");
    Environment.Exit(0);
}

Console.Write($"Você tem {age} ano(s) e é de ");

if (age >= 18)
    Console.WriteLine("maior");
else
    Console.WriteLine("menor");