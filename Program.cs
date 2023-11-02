double Salariohora;
double Horastotais;
double Horasextras;
double Salario;

Console.Write("Digite seu salário por hora: ");
Salariohora = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

Console.Write("Digite suas horas totais: ");
Horastotais = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

Console.Write("Digite suas horas extras: ");
Horasextras = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

Salario = (Salariohora * (Horastotais - Horasextras)) + (double)(Salariohora * Horasextras * 1.4);

Console.WriteLine($"salario-hora {Salariohora:C}, {Horastotais} horas, sendo {Horasextras} horas-extra, salário = {Salario:C}");