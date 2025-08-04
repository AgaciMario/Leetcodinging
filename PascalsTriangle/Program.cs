IList<IList<int>> Generate(int numRows) {
    if(numRows <= 1 || numRows >= 30)
        return new List<IList<int>>();

    List<List<int>> ptAux = new List<List<int>>();

    for (int i = 0; i < numRows; i++)
    {
        List<int> row = new List<int>();

        for (int j = 0; j < numRows; j++) {
            if(i == 0 || j == 0)
                row.Add(1);
            else
                row.Add(ptAux[i-1][j] + row[j-1]);
        }

        ptAux.Add(row);
    }

    List<List<int>> pascalTriangle = new List<List<int>>();

    for (int i = 0; i < numRows; i++)
    {
        List<int> row = new List<int>();

        for (int j = 0; j < numRows; j++) {
            int k = i - j;
            row.Add(ptAux[k][j]);
        }

        pascalTriangle.Add(row);
    }

    return pascalTriangle.Select(innerList => (IList<int>)innerList).ToList();
}

IList<IList<int>> pascalTriangle = Generate(5);

for (int i = 0; i < 5; i++)
{
    IList<int> row = pascalTriangle[i];

    for (int j = 0; j < 5; j++) {
        Console.Write(" "+row[j]);
    }

    Console.WriteLine("");
}
