namespace Program; 

internal class Program 
{
    static void Main(string[] args) 
    {
        for(int i = 0; i < args.Count(); i++)
            Console.WriteLine("fancy: " + MakeFancyString(args[i]));
    }

    // A really bad performant method more than 1 second on the teste.txt file
    public static string MakeFancyString(string input)
    {
        string fancyString = string.Empty;

        for(int i = 0; i < input.Count(); i++)
        {
            if(i + 2 < input.Count())
            {
                if(input[i] == input[i + 1] && input[i + 1] == input[i + 2])
                    continue;
            }

            fancyString = $"{fancyString}{input[i]}";
        }

        return fancyString;
    }
}

