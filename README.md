# Sistema de notas de alunos em C# (Projeto em desenvolvimento)

### O código escrito ate o momento tem como propósito conter 3 alunos. 
### Esses alunos devem receber 3 notas e, dessas 3 notas será feito um cálculo para tirar a média e ter a nota final.
### Após a média, será mostrado os nomes com as respectivas notas finais e ao lado um palavra de avaliação condizente com a noite

---

#### Código:

- Em primeira parte iremos criar nossas variáveis para armazenar os nomes dos alunos e suas notas:

~~~csharp

class Program
{
  static void Main()
  {
    string aluno1, aluno2, aluno3;
    int nota1_1, nota1_2, nota1_3, nota2_1, nota2_2, nota2_3, nota3_1, nota3_2, nota3_3;

~~~

- Após determinar as variáveis, iremos pedir ao usuário que insira o nome dos alunos:

~~~csharp

    //Nomes dos alunos
    Console.WriteLine("Digite o nome do primeiro aluno: ");
    aluno1 = Console.ReadLine();

    Console.WriteLine("\nDigite o nome do segundo aluno: ");
    aluno2 = Console.ReadLine(); 

    Console.WriteLine("\nDigite o nome do terceiro aluno: ");
    aluno3 = Console.ReadLine();

~~~

- Tendo os nomes dos alunos declarados, poderemos dar suas notas respectivamente:

~~~csharp

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

~~~

- Definindo a nota de cada aluno, podemos criar os cálculos para somar as notas e tirar a sua média:

~~~csharp

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

~~~

- Decidi implementar também uma categorização (avaliação) de notas, onde, dependendo da nota, possa dizer se é ` Péssimo `, `Ruim`, `Regular`,`Bom`, `Excelente`

~~~csharp

    //categorização das notas:

    string media1 = "";

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

~~~

*_O código se repete e é criado também as variáveis para armazenar a avaliação da média dos outros alunos_*