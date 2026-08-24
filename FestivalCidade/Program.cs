using System.Globalization;

CultureInfo br = new CultureInfo("pt-BR");

Console.Write("Nome do fa: ");
string nome = Console.ReadLine();

Console.Write("Quantidade de dias de show: ");
int dias = int.Parse(Console.ReadLine());

Console.Write("Cupom de desconto: ");
string cupom = Console.ReadLine();

Console.Write("Pontuacao do clube de fidelidade: ");
int pontos = int.Parse(Console.ReadLine());

decimal custoBruto = 15.00m + (120.00m * dias);
decimal desconto = 0.00m;

if (cupom.ToUpper() == "ROCK10")
{
    desconto = custoBruto * 0.10m;
}

decimal valorFinal = custoBruto - desconto;

bool loungeVip = dias > 2 && pontos >= 500;

Console.WriteLine();
Console.WriteLine("Fa: " + nome.ToUpper());
Console.WriteLine("Valor bruto: " + custoBruto.ToString("C", br));
Console.WriteLine("Valor final: " + valorFinal.ToString("C", br));
Console.WriteLine("Acesso ao Lounge VIP: " + loungeVip);

Console.ReadLine();
