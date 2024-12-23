using System;

class Program
{
  static void Main()
  {
    string aluno1, aluno2, aluno3;
    int nota1_1, nota1_2, nota1_3, nota2_1, nota2_2, nota2_3, nota3_1, nota3_2, nota3_3;

    //Nomes dos alunos
    Console.WriteLine("Digite o nome do primeiro aluno: ");
    aluno1 = Console.ReadLine();

    Console.WriteLine("\nDigite o nome do segundo aluno: ");
    aluno2 = Console.ReadLine(); 

    Console.WriteLine("\nDigite o nome do terceiro aluno: ");
    aluno3 = Console.ReadLine();

    //Nota dos alunos:
    Console.WriteLine($"\nDigite a primeira nota do aluno {aluno1}");
    nota1_1 = int.Parse(Console.ReadLine());

    Console.WriteLine($"\nDigite a segunda nota do aluno {aluno1}");
    nota1_2 = int.Parse(Console.ReadLine());

    Console.WriteLine($"\nDigite a terceira nota do aluno {aluno1}");
    nota1_3 = int.Parse(Console.ReadLine());

    Console.WriteLine($"\nDigite a primeira nota do aluno {aluno2}");
    nota2_1 = int.Parse(Console.ReadLine());

    Console.WriteLine($"\nDigite a segunda nota do aluno {aluno2}");
    nota2_2 = int.Parse(Console.ReadLine());

    Console.WriteLine($"\nDigite a terceira nota do aluno {aluno2}");
    nota2_3 = int.Parse(Console.ReadLine());

    Console.WriteLine($"\nDigite a primeira nota do aluno {aluno3}");
    nota3_1 = int.Parse(Console.ReadLine());

    Console.WriteLine($"\nDigite a segunda nota do aluno {aluno3}");
    nota3_2 = int.Parse(Console.ReadLine());

    Console.WriteLine($"\nDigite a terceira nota do aluno {aluno3}");
    nota3_3 = int.Parse(Console.ReadLine());

    //soma das notas:
    int alunoSoma1 = nota1_1 + nota1_2 + nota1_3;
    int alunoSoma2 = nota2_1 + nota2_2 + nota2_3;
    int alunoSoma3 = nota3_1 + nota3_2 + nota3_3;

    //Variável para armazenar a quantidade de notas para posteriormente obter a média
    int notas = 3;

    //media das notas:
    decimal alunoMedia1 = alunoSoma1 / notas;
    decimal alunoMedia2 = alunoSoma2 / notas;
    decimal alunoMedia3 = alunoSoma3 / notas;

    //categorização das notas:

    string media1 = "", media2 = "", media3 = "";

    if (alunoMedia1 <=2){
      media1 = "Pessimo";
    }
    else if (alunoMedia1 <=4){
      media1 = "Ruim";
    }
    else if (alunoMedia1 <=6){
      media1 = "Regular";
    }
    else if (alunoMedia1 <=8){
      media1 = "Bom";
    }
    else if (alunoMedia1 <=10){
      media1 = "Excelente";
    }

    if (alunoMedia2 <=2){
      media2 = "Pessimo";
    }
    else if (alunoMedia2 <=4){
      media2 = "Ruim";
    }
    else if (alunoMedia2 <=6){
      media2 = "Regular";
    }
    else if (alunoMedia2 <=8){
      media2 = "Bom";
    }
    else if (alunoMedia2 <=10){
      media2 = "Excelente";
    }
    if (alunoMedia3 <=2){
      media3 = "Pessimo";
    }
    else if (alunoMedia3 <=4){
      media3 = "Ruim";
    }
    else if (alunoMedia3 <=6){
      media3 = "Regular";
    }
    else if (alunoMedia3 <=8){
      media3 = "Bom";
    }
    else if (alunoMedia3 <=10){
      media3 = "Excelente";
    }
    //frequencia presencial:
    //Implementar posteriormente após deixar o codigo mais limpo


    Console.WriteLine("\nAlunos\t\tNotas\t\tResultado\n");
    Console.WriteLine($"{aluno1}\t\t{alunoMedia1}\t\t{media1}");
    Console.WriteLine($"{aluno2}\t\t{alunoMedia2}\t\t{media2}");
    Console.WriteLine($"{aluno3}\t\t{alunoMedia3}\t\t{media3}");

  }   

}