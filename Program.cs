string move;
char[] positions = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
string board;
void playerMove()
{
    do
    {
        Console.WriteLine("\n", board);
        Console.WriteLine("Choose your move: 1~9");
        move = Console.ReadLine();
    }
    while (move == "X" || move == "O" || !(Array.IndexOf(positions, Convert.ToChar(move)) >= 0));
    positions[Array.IndexOf(positions, Convert.ToChar(move))] = 'X';
};

string updateBoard(char[] positions)
{
    board = $" {positions[0]} | {positions[1]} | {positions[2]} \n___|___|___\n {positions[3]} | {positions[4]} | {positions[5]} \n___|___|___\n {positions[6]} | {positions[7]} | {positions[8]} \n   |   |   ";
    return board;
}
;

Console.WriteLine("Welcome to Tic-Tac-Toe!");
updateBoard(positions);
playerMove();
updateBoard(positions);
Console.WriteLine(board);





//string cpuMove(string move)
//{

//}

//Check array for elements that match move, if none found

//Make 2 functions designed for player moves and cpu moves. There is a lot of repitition of updating the board and printing the value.
//Figure out how to make it so that the process is split in to repeatable methods.