//Console.WriteLine("Quantos pneus você quer trocar?");
//int troca = int.Parse(Console.ReadLine());
//int total = 0;
//for(int pneusTrocados = 1; pneusTrocados <= troca; pneusTrocados++)
//{
//    Console.WriteLine($" Numero de pneus trocados {pneusTrocados} º");
//    total = pneusTrocados;
//}
//Console.WriteLine($"Serviço finalizado! total de pneus {total}");

List<int> numeros = new List<int> { 90, 80, 100, 20, 2000 };

int notas = numeros.Select(x => x > 90).Count();
Console.WriteLine($"Notas maior que 90 {notas}");

