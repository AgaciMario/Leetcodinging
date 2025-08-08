namespace Program;

public class Program {
    public static void Main() {
        Solution so = new Solution();
        int[] arr = new int[] {1, 3, 5, 6};

        so.SearchInsert(arr, 0);
    }

}

public class Solution {
    public int SearchInsert(int[] nums, int target) {
        return BinarySearch(nums, target, 0, nums.Length - 1);
    }

    private int BinarySearch(int[] nums, int target, int inf, int sup) {
        int middle = (inf + sup) / 2;

        if(nums[middle] == target) return middle;

        if(inf >= sup) 
            // if nums at inf is less than target -> target should be inserted in a position outside of the array.
            if(nums[inf] < target) 
                return inf + 1;
            else 
                return inf;
        else {
            if(nums[middle] < target)
                return BinarySearch(nums, target, middle+1, sup);
            else
                return BinarySearch(nums, target, inf, middle-1);
        }
    }
}
