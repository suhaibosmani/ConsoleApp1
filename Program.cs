Console.WriteLine("Welcome to Tic-Tac-Toe!");
string move;
string[] positions = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
string board = $" {positions[0]} | {positions[1]} | {positions[2]} \n___|___|___\n {positions[3]} | {positions[4]} | {positions[5]} \n___|___|___\n {positions[6]} | {positions[7]} | {positions[8]} \n   |   |   ";
Console.WriteLine(board);

do
{
    Console.WriteLine("Choose your move: 1~9");
    move = Console.ReadLine();
}
while (Convert.ToInt32(move) < 1 || Convert.ToInt32(move) > 9);
//Make an array for positions, and have the user enter the index to place their mark

