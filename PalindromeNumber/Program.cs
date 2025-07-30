namespace Program;

public class Program {
    public static void Main(string[] args) {
        for(int i = 0; i < args.Count(); i++) {
            Console.WriteLine(args[i] + " IsPalindrome " + IsPalindrome(int.Parse(args[i])));
        }
    }

    public static bool IsPalindrome(int x) {
        int y = ReverseNumber(x); 
        Console.WriteLine("--------------" + y);
        return x == y;
    }

    public static int ReverseNumber(int x){
        int result = 0;

        while(x > 0){
            result *= 10; // adiciona a casa decimal
            result += x % 10; // separa o primeiro digito e o adiciona ao resultado
            x /= 10; // remove o digito separado do número informado para o próximo loop
        }

        return result;
    }
}

