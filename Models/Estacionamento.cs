namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine($"O veículo {placa} foi estacionado com sucesso!");

        }

        public void RemoverVeiculo()
        {   
            if (veiculos.Any()) {
                Console.WriteLine("Os veículos estacionados são:");

                foreach(var veiculo in veiculos)
                {
                    int contador = veiculos.IndexOf(veiculo) + 1;
                    Console.WriteLine($"{contador} - {veiculo}");
                }

            Console.WriteLine("Digite o número referente ao veiculo a ser retirado:");
            int val;
            while(!int.TryParse(Console.ReadLine(), out val)) {
            Console.WriteLine("Insira apenas números inteiros");
            Console.WriteLine("Digite o número referente ao veiculo a ser retirado:");
    }
            if (val > 0 && val <= veiculos.Count) {
                Console.WriteLine($"Selecionado *{veiculos[val - 1]}* para ser removido");
                Console.WriteLine("Por quantas horas o veículo ficou estacionado?");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal precoFinal = precoInicial + (precoPorHora * horas);
                veiculos.RemoveAt(val - 1);
                Console.WriteLine($"Veículo removido com sucesso! e o valor ficou em R${precoFinal}");
            } else {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou corretamente");
            }
            } else {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
                {
                    int contador = veiculos.IndexOf(veiculo) + 1;
                    Console.WriteLine($"{contador} - {veiculo}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
