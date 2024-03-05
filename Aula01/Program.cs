
//altere o programa para calcular o imc de uma pessoa
// imc = peso / altura * altura
using Aula01;
using System.Globalization;

bool entrada = true;
do
{
    try
    {

        //Console.WriteLine("Informe o peso atual: ");
        //int peso = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Informe a altura atual: ");
        //float altura = float.Parse(Console.ReadLine());
        //CalculaIMC calculaIMC = new CalculaIMC();
        //Console.WriteLine(calculaIMC.Calcular(peso, altura));
        //Crie uma classe chamada Calculadora, que possua um método que some dois números inteiros e retorne o resultado dessa soma.
        //O nome do Método deve ser Soma. Ao final deverão ser exibidos os números informados e o valor da soma. 

        Console.WriteLine("Informe o um número inteiro: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o mais um número inteiro: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Calculadora calculo = new Calculadora();
        Console.WriteLine(calculo.Soma(num1, num2));
        entrada = false;
    }
    catch (FormatException e)
    {
        Console.WriteLine("O peso deve ser um número inteiro e a altura em numero decimal");
    }
} while (entrada);



