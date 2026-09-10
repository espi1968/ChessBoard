namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8; // haha denna kämpade jag med för jag hade bara ? tecken.

            Console.Write("How many rows?");
            int rows = Int32.Parse(Console.ReadLine());

            Console.Write("How many columns?");
            int columns = Int32.Parse(Console.ReadLine());

            Console.WriteLine();


            char symbol1 = '◼';
            char symbol2 = '◻';

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    if ((row + col) % 2 == 0)
                    {
                        Console.Write(symbol1);
                    }
                    else
                    {
                        Console.Write(symbol2);
                    }
                    
                }
                Console.WriteLine();
            }
               
        }
    }
}
