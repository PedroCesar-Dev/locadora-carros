using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locadora
{
    internal class estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoHora = 0;
        private List<string> veiculos = new List<string>();

        public estacionamento( decimal precoInicial, decimal precoHora) 
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
        }
        
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo:");
            string placa = Console.ReadLine();
            placa = placa.ToUpper();

            if (veiculos.Any(x => x.Equals(placa.ToUpper())))
            {
                Console.WriteLine("Já existe um veículo com essa placa");
            }
            else
            {
                veiculos.Add(placa);
                Console.WriteLine("Veículo cadastrado com sucesso");
            }
        }
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo");
            string placa = Console.ReadLine();
            placa = placa.ToUpper();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Informe a quantidade de horas que o veículo permaneceu no pátio: ");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal precoTotal = precoInicial + precoHora * horas;
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo de placa: {placa} foi removido e deve pagar {precoTotal}");
            }
            else
            {
                Console.WriteLine("O veículo não está em nosso pátio. ");
            }
        }
        public void listarVeiculo()
        { 
            if (veiculos.Any())
            {
                Console.Write("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }

            }
            else
            {
                Console.WriteLine("Não há veículos no pátio");
            }
        }

    }
}
