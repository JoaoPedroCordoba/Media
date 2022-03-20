double n1, n2, n3, Media;

Console.WriteLine("Digite um numero, Por Favor:");
n1 = Convert.ToDouble(Console.ReadLine())!;

Console.WriteLine("Digite o segundo numero, Por favor:");
n2 = Convert.ToDouble(Console.ReadLine())!;

Console.WriteLine("Digite o terceiro numero, Por favor:");
n3 = Convert.ToDouble(Console.ReadLine());

Media = (n1+n2+n3) / 3;

Console.WriteLine($"A media é:{Media:N1}");