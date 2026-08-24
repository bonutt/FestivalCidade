Console.Write("Nome do fa: ");
string nome = Console.ReadLine();

Console.Write("Quantidade de dias de show: ");
int dias = int.Parse(Console.ReadLine());

Console.Write("Cupom de desconto: ");
string cupom = Console.ReadLine();

Console.Write("Pontuacao do clube de fidelidade: ");
int pontos = int.Parse(Console.ReadLine());

decimal custoBruto = 15.00m + (120.00m * dias);

Console.WriteLine("Valor bruto: " + custoBruto);

Console.ReadLine();
