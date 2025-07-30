int[] TwoSum_bruteForce(int[] nums, int target) {
    int[] result = [];
    for(int i = 0; i < nums.Length ; i++)
    {
        for(int j = 0; j < nums.Length; j++)
        {
            if(i == j) continue; // Não podemos uilizar o mesmo elemento

            else if(nums[i] + nums[j] == target)
            {
                return new int[] {i, j};
            }
        }
    }

    return result;
}

int[] TwoSum(int[] nums, int target) {
    Dictionary<int, int> map = new Dictionary<int, int>();
    for(int i = 0; i < nums.Count(); i++)
    {
        /* Pode haver sobreescrita de valores, mas como a descrição do problema cita que há apenas 
        uma solução possível esse ponto não será considerado */
        map[nums[i]] = i; 
    }

    for(int i = 0; i < nums.Count(); i++)
    {
        int diference = target - nums[i];

        if(map.ContainsKey(diference))
        {
            if(map[diference] == i)
                continue;

            return new int[] { i, map[diference] };
        }
    }

    return new int[] {};
}
