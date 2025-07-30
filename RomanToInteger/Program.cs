static int RomanToInteger(string s){
    Dictionary<char, int> RomanNumbersMap = new Dictionary<char, int>()
    {
        { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 }
    };

    int result = 0;
    char[] inputArr = s.ToArray();
    for(int i = 0; i < inputArr.Count(); i++)
    {
        int currentNumber = RomanNumbersMap[inputArr[i]];
        int nextNumber = (i + 1 < inputArr.Count()) ? RomanNumbersMap[inputArr[i + 1]] : 0;

        if(currentNumber < nextNumber)
            result -= currentNumber;
        else 
            result += currentNumber;
    }

    return result;
}

Console.WriteLine("result: " + RomanToInteger("MCMXCIV"));
