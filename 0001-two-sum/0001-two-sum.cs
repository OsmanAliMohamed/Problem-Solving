public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> ans = new Dictionary<int, int>();
        List<int> res = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if(ans.ContainsKey(target - nums[i]))
            {
                res.Add(i);
                res.Add(ans[target - nums[i]]);
                return res.ToArray();
            }
            ans.TryAdd(nums[i], i);
        }
        return res.ToArray();
    }
}