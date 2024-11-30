namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) // Loop infinito: para manter a calculadora ativa até que o usuário escolha sair
                        // O programa só sairá do loop se um break for chamado
            {
                Console.Clear(); // Limpa o terminal a cada iteração, mantendo a interface "limpa" para o usuário
                Console.WriteLine("Calculadora Simples");
                Console.WriteLine("Escolha uma operação:");
                Console.WriteLine("1. Adição (+)");
                Console.WriteLine("2. Subtração (-)");
                Console.WriteLine("3. Multiplicação (*)");
                Console.WriteLine("4. Divisão (/)");
                Console.WriteLine("5. Sair");
                Console.WriteLine("Opção: ");

                string opcao = Console.ReadLine()!; // Solicita ao usuário que insira uma opção

                if (opcao == "5") // Se a opção for "5", o programa sairá do loop
                {
                    Console.WriteLine("Encerrando a calculadora. Até logo!");
                    break;
                }

                Console.WriteLine("Digite o primeiro número: "); // Solicita o primeiro número
                double numero1 = Convert.ToDouble(Console.ReadLine()); // Converte a entrada do usuário para double

                Console.WriteLine("Digite o segundo número: "); // Solicita o segundo número
                double numero2 = Convert.ToDouble(Console.ReadLine()); // Converte a entrada do usuário para double

                double resultado = 0; // Inicializa o resultado com 0, que armazenará o resultado da operação
                bool operacaoValida = true; // Funciona como um controle de fluxo

                switch (opcao) // Avalia a variável opção e executa o bloco correspondente
                {
                    case "1":
                        resultado = numero1 + numero2;
                        break;
                    case "2":
                        resultado = numero1 - numero2;
                        break;
                    case "3":
                        resultado = numero1 * numero2;
                        break;
                    case "4":
                        if (numero2 != 0) // Verifica se num2 não é zero antes de realizar a divisão.
                        {
                            resultado = numero1 / numero2;
                        }
                        else
                        {
                            Console.WriteLine("Erro: Divisão por zero não é permitida!");
                            operacaoValida = false;
                        }
                        break;
                    default:   // Opção inválida: Mostra uma mensagem de erro se o usuário digitar uma opção que não existe.

                        Console.WriteLine("Opção inválida, Tente novamente!");
                        operacaoValida = false;
                        break;

                }

                if (operacaoValida) // Mostra o resultado apenas se a operação for válida
                {
                    Console.WriteLine($"Resultado: {resultado}");
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey(); // Exibe uma mensagem para o usuário e aguarda uma tecla antes de limpar a tela e reiniciar o loop.
            }
        }
    }
}

