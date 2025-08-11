namespace Program;

public class Program {
    public static void Main(){
        Solution so = new Solution();
        PrintArr(so.PlusOne(new int[] {4,3,2,1}));
        PrintArr(so.PlusOne(new int[] {1,2,3}));
        PrintArr(so.PlusOne(new int[] {4,9,9,9}));
        PrintArr(so.PlusOne(new int[] {9,9,9,9}));
    }

    public static void PrintArr(int[] arr){
        Console.Write("result = [");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(" {0} ", arr[i]);
        }
        Console.WriteLine("]");
    }
}

public class Solution {
    public int[] PlusOne(int[] digits) {
        if(digits.Length < 1 || digits.Length > 100)
            return new int[] {0};

        int[] auxArr = new int[digits.Length];
        auxArr[digits.Length - 1] = 1;

        for(int i = digits.Length - 1; i >= 0; i--){
            int result = digits[i] + auxArr[i];

            if(result > 9){
                digits[i] = 0;
                if(i - 1 < 0){
                    digits = new int[digits.Length + 1];
                    digits[0] = 1;
                    break;
                } else {
                    auxArr[i - 1] = 1;
                }
            } else {
                digits[i] = result;
            }
        }

        return digits;
    }
}
