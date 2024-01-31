//Variaveis
using locadora;

decimal precoInicial, precoHora = 0;

//Iniciar sistema

Console.WriteLine("Seja Bem vindos ao estacionamento");
Console.WriteLine("---------------------------------");

Console.WriteLine("Digite o preço inicial: ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora: ");
precoHora = Convert.ToDecimal(Console.ReadLine());

//Estancia a classe estacionamento

estacionamento es = new estacionamento(precoInicial, precoHora);

//loop

bool menu = true;

while (menu)
{
    Console.Clear();
    Console.WriteLine("Escolha uma opção");
    Console.WriteLine("1. - Adicionar veículo");
    Console.WriteLine("2. - Remover");
    Console.WriteLine("3. - Listar veículo");
    Console.WriteLine("4. - Sair do sistema");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;
        case "2":
            es.RemoverVeiculo();
            break;
        case "3":
            es.listarVeiculo();
            break;
        case "4":
            menu = false;
            break;
        default:
            Console.WriteLine("Digitar uma opção válida");
            break;
    }
    Console.WriteLine("Digite uma tecla para continuar:");
    Console.ReadLine();
    
}
Console.WriteLine("O programa encerrou");