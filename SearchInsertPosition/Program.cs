public class Solution {
    public int SearchInsert(int[] nums, int target) {
        return BinarySearch(nums, target, 0, nums.Length - 1);
    } 

    public int BinarySearch(int[] nums, int target, int inf, int sup) {
        int middle = (inf + sup) / 2;

        if(nums[middle] == target) return middle;

        if(inf == sup) {
            if(target > nums[middle])
                return inf + 1;
            else
                return inf;
        }
        else {
            if(nums[middle] < target)
                return BinarySearch(nums, target, middle+1, sup);
            else
                return BinarySearch(nums, target, inf, middle-1);
        }
    }
}
