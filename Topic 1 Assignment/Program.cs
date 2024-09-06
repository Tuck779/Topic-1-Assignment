namespace Topic_1_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Bill";
            string favMovie = "The Matrix";
            Console.WriteLine("hello, my name is " + firstName.ToLower() + " and my favourite movie is " + favMovie.ToLower());
            Console.WriteLine();
            Console.WriteLine(favMovie.ToUpper());
            Console.WriteLine("Does the above phrase contain 'The'? " + favMovie.ToUpper().Contains("THE"));
            Console.WriteLine(favMovie.Replace("a", "@").Replace("e", "3"));
            Console.WriteLine();
            string favQuote = "Cause we are who we are till were not";
            Console.WriteLine(favQuote);
            Console.WriteLine(favQuote.ToLower().Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", ""));
            Console.WriteLine();
            Console.WriteLine("          /\"*._         _                                            .-.");
            Console.WriteLine("      .-*'`    `*-.._.-'/                (___________________________()6 `-,");
            Console.WriteLine("    < * ))     ,       (                 (   ______________________   /''\"`");
            Console.WriteLine("      `*-._`._(__.--*\"`.\\              //\\                      //\\");
            Console.WriteLine("                                         \"\" \"\"                     \"\" \"\"");
            Console.ReadLine();
        }
    }
}
