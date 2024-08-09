public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int l = 0, r = nums.Length - 1;
        int ans = nums.Length;
        while(l <= r)
        {
            int mid = (l + r) / 2;
            if(nums[mid] >= target)
            {
                ans = mid;
                r = mid - 1;
            }
            else
            {
                l = mid + 1;

            }
        }
        return ans;
    }
}