namespace ReverseProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter number");
            //int input = Convert.ToInt32(Console.ReadLine());
            //ReverseProgram.ReverseNumber(Number);
            //Console.ReadLine();
            ReverseProgram.ReverseWord("Rushi");
            Console.WriteLine("Please enter the word");
            string word = Console.ReadLine();
            ReverseProgram.ReverseWord(word);
            Console.ReadLine();
        }
    }
}