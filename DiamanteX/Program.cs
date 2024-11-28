using System;

class Programa {
    static void Main() {
        Console.WriteLine("Digite um número ímpar:");
        int n = int.Parse(Console.ReadLine());
        if (n % 2 == 0) {
            Console.WriteLine("Número inválido.");
            return;
        }

        int meio = n / 2;

        for (int i = 0; i < n; i++) {
            int espacos = Math.Abs(meio - i);
            int xs = n - 2 * espacos;
            Console.WriteLine(new string(' ', espacos) + new string('x', xs));
        }
    }
}
