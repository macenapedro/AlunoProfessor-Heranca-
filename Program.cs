using Ex4;

Console.WriteLine("## Exercicio 4 ##\n ");

int total = 3;

Pessoa[] pessoa = new Pessoa[total];

for (int i = 0; i < pessoa.Length; i++)
{
    if(i == 0)
    {
        Console.WriteLine("\nInsira o nome do Professor:");
        pessoa[i] = new Professor(Console.ReadLine());
    } else
    {
        Console.WriteLine("\nInsira o nome do Aluno:");
        pessoa[i] = new Aluno(Console.ReadLine());
    }
}

for (int i = 0;i < pessoa.Length; i++)
{
    if (i == 0)
    {
        Console.Write("O Professor ");
        ((Professor)pessoa[i]).Explicar();
    } else
    {
        Console.Write("O Aluno ");
        ((Aluno)pessoa[i]).Estudar();
    }
}

Console.ReadKey();