using System;

namespace rpg_c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            personagem jogador2= new personagem();
            personagem jogador1= new personagem();
            jogador1.vida= 20;
            jogador2.vida= 20;
            Console.WriteLine("Qual será o nome do seu primeiro personagem?");
            jogador1.nome=Console.ReadLine();
             Console.WriteLine("Qual sua classe?(classes disponiveis: guerreiro| arqueiro| mago)");
             jogador1.classe=Console.ReadLine();
             Console.WriteLine("Qual será o nome do seu segundo personagem?");
            jogador2.nome=Console.ReadLine();
             Console.WriteLine("Qual sua classe?(classes disponiveis: guerreiro| arqueiro| mago)");
             jogador2.classe=Console.ReadLine();
            Console.WriteLine("Ambos personagens tem 20 de vida");
             //classes

             if(jogador1.classe=="guerreiro"&&jogador2.classe=="arqueiro"){
                 Console.WriteLine("Otima escolha");
                Console.WriteLine($"{jogador1.nome} tem uma espada longa para seus combates");
                 Console.WriteLine($"{jogador2.nome} tem um arco e varias flechas para seus combates");
                Console.WriteLine($"{jogador1.nome} Gostaria de batalhar com o {jogador2.nome}?");
                string respostaj1=Console.ReadLine();
                Console.WriteLine($"{jogador2.nome} Gostaria de batalhar com o {jogador1.nome}?");
                string respostaj2=Console.ReadLine();
                if(respostaj1=="sim"&&respostaj2=="sim"){
                 Console.WriteLine($"Aguarde, a partida irá começar");
                 Console.WriteLine($"O primeiro ataque é do {jogador1.nome}");
                  Console.WriteLine($"com qual ataque você gostaria de começa? (ataque dos mil sois || ataque com a espada normal");
                  string ataqueb1= Console.ReadLine();
                  if(ataqueb1=="ataque dos mil sois"){
                       Console.WriteLine($"{jogador2.nome} qual defesa voce utilizará?(defesa com arco || esquiva)");
                       string def1= Console.ReadLine();
                       if(def1=="defesa com arco"){
                            Console.WriteLine($"{jogador1.nome} deu 10 de dano a {jogador2.nome}");
                            int vida=jogador2.vida-10;
                            Console.WriteLine($"{jogador2.nome}está com {vida}");
                       }
                       else if(def1=="esquiva"){
                           
                           Console.WriteLine($"é impossivel se esquivar ");
                          Console.WriteLine($"{jogador1.nome} deu 20 de dano e acabou com a vida do {jogador2.nome}");
                       }else{
                           Console.WriteLine("você escolheu uma opçao invalida logo recebera o ataque");
                           Console.WriteLine("----------------------------------------------------------------------");
                           Console.WriteLine($"{jogador1.nome} deu 20 de dano e acabou com a vida do {jogador2.nome}");
                       }
                  }
                  else if(ataqueb1=="ataque com a espada normal"){
                      Console.WriteLine($"{jogador2.nome} qual defesa voce utilizará?(defesa com arco || esquiva)");
                       string def1= Console.ReadLine();
                       if(def1=="defesa com arco"){
                            Console.WriteLine($"{jogador1.nome} deu 5 de dano ao {jogador2.nome}");
                            int vida=jogador2.vida-10;
                            Console.WriteLine($"{jogador2.nome}está com {vida}");
                       }
                       else if(def1=="esquiva"){
                           
                           Console.WriteLine($"é impossivel se esquivar ");
                          Console.WriteLine($"{jogador1.nome} deu 0 de dano ao {jogador2.nome}");
                       }else{
                           Console.WriteLine("você escolheu uma opçao invalida logo recebera o ataque");
                           Console.WriteLine("----------------------------------------------------------------------");
                           Console.WriteLine($"{jogador1.nome} deu 10 de dano ao {jogador2.nome}");
                       }
                  }else{
                       Console.WriteLine("você escolheu uma opçao invalida logo você nao atacará");
                  }
                }
                else if(respostaj1=="sim"&&respostaj2=="nao" || respostaj1=="nao"&&respostaj2=="sim"
                 || respostaj1=="nao" &&respostaj2=="nao" ){
                     Console.WriteLine($"Um jogador se recusou a jogar, por esse motivo nao terá nenhum combate");
                }else{
                      Console.WriteLine("opçao invalida");
                }
             }
             else  if(jogador1.classe=="arqueiro"){
                 Console.WriteLine("Otima escolha");
             }
              else  if(jogador1.classe=="mago"){
                  Console.WriteLine("Otima escolha");
             }
             else{
                 Console.WriteLine("opçao invalida");
             }
        }
    }
}
