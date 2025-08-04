int RemoveElement(int[] nums, int val) {
    int k = 0;

    for(int i = 0; i < nums.Length; i++) {

        if(nums[i] != nums[k]) {
            int swapValue = nums[k];
            nums[k] = nums[i];
            nums[i] = swapValue;
            k++;
        }

        if(nums[k] != val)
            k++;
    }

    return k;
}
