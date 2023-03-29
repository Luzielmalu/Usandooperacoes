// See https://aka.ms/new-console-template for more information

double numero1;
double numero2;
double total;
string operacao;


Console.Write("digite numero1:");
numero1 = Convert.ToDouble(Console.ReadLine());
Console.Write("digite a operacao:");
operacao = (Console.ReadLine());  
Console.Write("digite numero2:");
numero2 = Convert.ToDouble(Console.ReadLine());

total = 0;

    if (operacao== "-");{
    total = numero1 - numero2;
}
    
Console.Write("o resultado é: " + total);
Console.ReadKey();



