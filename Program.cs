using bytebank;
using bytebank.Titular;

Console.WriteLine("Boas vindas ao seu banco, ByteBank!");

//-------------------------------------------------------
Console.WriteLine("");
Console.WriteLine("====================");
Console.WriteLine("Apresentando o total de contas...");
ContaCorrente conta1 = new ContaCorrente(123, "12345-X");
ContaCorrente conta2 = new ContaCorrente(456, "45678-X");
Console.WriteLine("Total de contas criadas: " + ContaCorrente.TotalDeContasCriadas);

//-------------------------------------------------------
Console.WriteLine("");
Console.WriteLine("====================");
Console.WriteLine("Apresentando o total de clientes...");
Cliente cliente1 = new Cliente();
Cliente cliente2 = new Cliente();
Console.WriteLine("Total de clientes cadastrados: " + Cliente.TotalClientesCadastrados);

//-------------------------------------------------------
Console.WriteLine("");
Console.WriteLine("====================");
Console.WriteLine("Apresentando a transferencia entre contas...");

cliente1.Nome = "André Silva";
conta1.Titular = cliente1;
conta1.Saldo = 250;

cliente2.Nome = "Amanda Nogueira";
conta2.Titular = cliente2;
conta2.Saldo = 100;

Console.WriteLine($"Saldo Anterior da conta: {conta1.Titular.Nome}: R$ {String.Format("{0:0.00}", conta1.Saldo)}"); //250,00
Console.WriteLine($"Saldo Anterior da conta: {conta2.Titular.Nome}: R$ {String.Format("{0:0.00}", conta2.Saldo)}"); //100,00
Console.WriteLine("");
Console.WriteLine("Efetuando a transferencia...");
Console.WriteLine($"{conta1.Titular.Nome} transfere R$50,00 para {conta2.Titular.Nome}");
Console.WriteLine("");
conta1.Transferir(50, conta2);
Console.WriteLine($"Saldo Atual da conta: {conta1.Titular.Nome}: R$ {String.Format("{0:0.00}", conta1.Saldo)}"); //200,00
Console.WriteLine($"Saldo Atual da conta: {conta2.Titular.Nome}: R$ {String.Format("{0:0.00}", conta2.Saldo)}"); //150,00

//-------------------------------------------------------
Console.WriteLine("");
Console.WriteLine("====================");
Console.WriteLine("Apresentando o saque de uma conta...");
Console.WriteLine($"Saldo Anterior: {conta1.Titular.Nome}: R$ {String.Format("{0:0.00}", conta1.Saldo)}");
Console.WriteLine("Efetuando o saque...(90,00)");
bool saque = conta1.Sacar(90);
Console.WriteLine("Saque efetuado com sucesso? " + (saque ? "Sim" : "Não"));
Console.WriteLine($"Saldo Atual (esperado 110.00): {conta1.Titular.Nome}: R$ {String.Format("{0:0.00}", conta1.Saldo)}"); //110,00

//-------------------------------------------------------
Console.WriteLine("");
Console.WriteLine("Pressione algo para encerrar...");
Console.ReadKey();
