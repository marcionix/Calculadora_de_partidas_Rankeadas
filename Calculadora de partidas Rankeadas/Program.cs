using System;

class Program {

    public static void Main() {
        int option = -1, vitorias= -1, derrotas = -1;
        while(option < 0) {
            Console.WriteLine("Calculadora de Partidas Rankeadas");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("-Calcular - 1                    ");
            Console.WriteLine("-Sair     - 0                    ");
            Console.WriteLine("---------------------------------\n");
            if(int.TryParse(Console.ReadLine(), out option)) {
                switch(option) {
                    case 1:
                        Console.WriteLine("Informe quantas vitórias\n");
                        while(!int.TryParse(Console.ReadLine(), out vitorias)) {
                            Console.WriteLine("Inválido, tente novamente");
                        }
                        Console.WriteLine("Informe quantas derrotas\n");
                        while(!int.TryParse(Console.ReadLine(), out derrotas)) {
                            Console.WriteLine("Inválido, tente novamente");
                        }
                        CalculaSaldoRank(vitorias, derrotas);
                        option = -1;
                    break;
                    case 0:
                        Console.WriteLine("Até mais!");
                        option = 99;
                    break;
                    default:
                        Console.WriteLine("Inválido, tente novamente");
                        option = -1;
                    break;
                }
            } else {
                Console.WriteLine("Inválido, tente novamente");
                option = -1;
            }
        }
    }

    public static void CalculaSaldoRank(int vitorias, int derrotas) {
        
        int saldoVitorias = vitorias - derrotas;
        string nivel;

        if(saldoVitorias < 10)
            nivel = "Ferro";
        else if(saldoVitorias >= 11 && saldoVitorias <= 20)
            nivel = "Bronze";
        else if(saldoVitorias >= 21 && saldoVitorias <= 50)
            nivel = "Prata";
        else if(saldoVitorias >= 51 && saldoVitorias <= 80)
            nivel = "Ouro";
        else if(saldoVitorias >= 81 && saldoVitorias <= 90)
            nivel = "Diamante";
        else if(saldoVitorias >= 91 && saldoVitorias <= 100)
            nivel = "Lendário";
        else
            nivel = "Imortal";

        Console.WriteLine($"O Herói tem de saldo de {saldoVitorias} está no nível de {nivel}");
    }
}