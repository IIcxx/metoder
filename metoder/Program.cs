String player1name = "Cassius Clay";
String player2name = "Floyd Mayweather";

int round = 1;
int player1hp = 100;
int player2hp = 100;

Random generator = new Random();

Console.ReadLine();

while (player1hp > 0 && player2hp > 0){
Console.WriteLine($">>>>>>>[Runda {round}]<<<<<<<");
round += 1;
int p1Damage = generator.Next(15);
player1hp -= p1Damage;
player1hp = Math.Max(0, player1hp);
Console.WriteLine($"{player2name} does {p1Damage} damage to {player1name}");
Console.WriteLine($"{player1name}'s HP:{player1hp}");
Console.ReadLine();
int p2Damage = generator.Next(15);
player2hp -= p2Damage;
player2hp = Math.Max(0, player2hp);
Console.WriteLine($"{player1name} does {p2Damage} damage to {player2name}");
Console.WriteLine($"{player2name}'s HP:{player2hp}");
Console.ReadLine();
}
if(player1hp == 0 && player2hp == 0){
    Console.WriteLine(">>>>>>[Fight is over]<<<<<<");
    Console.WriteLine(">>>>>>>[Tie!]<<<<<<<");
    Console.WriteLine("Press any button to close game");
    }
    else if(player1hp == 0 && player2hp > 0){
         Console.WriteLine(">>>>>>[Fight is over]<<<<<<");
         Console.WriteLine($">>>>>>[{player2name} wins!]<<<<<<");
         Console.WriteLine("Press any button to close game");
         }
         else if(player1hp > 0 && player2hp == 0){
              Console.WriteLine(">>>>>>[Fight is over]<<<<<<");
              Console.WriteLine($">>>>>>[{player1name} wins!]<<<<<<");
              Console.WriteLine("Press any button to close game");
    }
    Console.ReadLine();
        
    
    
    
    
    


