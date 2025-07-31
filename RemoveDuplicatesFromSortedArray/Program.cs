int RemoveDuplicates_notOtp(int[] nums) {
    int lastIndex = nums.Length - 1;

    // count the number of non-repeted values
    int lastValueSeen = nums[0];
    int k = 1;
    for (int i = 1; i < nums.Length; i++)
    {
        if(nums[i] == lastValueSeen)
            continue;
        else {
            lastValueSeen = nums[i];
            k++;
        }
    }

    // Adding a new max-value to the duplicated spaces in the array
    for (int i = 0; i < lastIndex; i++)
    {
        if(nums[i] != nums[i + 1])
            continue;

        if(nums[i] == nums[i + 1])
            nums[i] = nums[lastIndex] + 1;
    }

    Array.Sort(nums);
    return k;
}

// optmized solution
public int RemoveDuplicates(int[] nums) {
    if(nums.Length == 0) return 0;

    int res = 1; 
    for(int i = 1; i < nums.Length; i++){
        if(nums[i] != nums[i - 1]) {
            nums[res] = nums[i];
            res++;
        }
    }

    return res;
}
