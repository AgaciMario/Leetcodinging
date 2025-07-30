string LongestCommonPrefix(string[] strs) {
    string baseWord = strs[0];
    string prefix = string.Empty;

    for(int i = 0; i < baseWord.Count(); i++)
    {
        bool CharExistInAllStrs = true;
        for(int j = 1; j < strs.Count(); j++)
        {
            if(i > strs[j].Count() - 1) {
                CharExistInAllStrs = false;
                break;
            }

            if(strs[j][i] != baseWord[i])
                CharExistInAllStrs = false;
        }

        if(!CharExistInAllStrs)
            break;

        prefix += baseWord[i];
    }

    return prefix;
}

Console.WriteLine(LongestCommonPrefix(["flower", "flow", "flight"]));
Console.WriteLine(LongestCommonPrefix(["dog","racecar","car"]));
