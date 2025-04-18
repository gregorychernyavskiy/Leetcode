/*
 * @lc app=leetcode id=658 lang=csharp
 *
 * [658] Find K Closest Elements
 */

// @lc code=start
public class Solution {
    public IList<int> FindClosestElements(int[] arr, int k, int x) {
        int left = 0;
        int right = arr.Length - k;
        while (left < right) {
            int mid = (right - left) / 2;
            if (x - arr[mid] > arr[mid + k] - x) {
                left = mid + 1;
            }
            else {
                right = mid;
            }
        }
        List<int> result = new List<int>();
        for (int i = left; i < left + k; i++) {
            result.Add(arr[i]);
        }
        return result;
    }
}
// @lc code=end

