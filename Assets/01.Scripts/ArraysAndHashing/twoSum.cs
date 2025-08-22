using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;

public class twoSum : SerializedMonoBehaviour
{
    public int [] nums = new int[] { 3, 4, 5, 6 };
    public int target = 7;
    public Dictionary<int, int> diff = new Dictionary<int, int>();

    [Button]
    public void TestTwoSum()
    {
        diff.Clear(); // Clear the dictionary before each test to avoid stale data
        int[] result = TwoSum(nums, target);
       
        if (result != null)
        {
            Debug.Log($"Indices found: {result[0]}, {result[1]}");
        }
        else
        {
            Debug.Log("No two sum solution found."); 
        }
    }

    // 2 passes
    //public int[] TwoSum(int[] nums, int target)
    //{
    //    int first = -1;
    //    int second = -1;
    //    for (int i = 0; i < nums.Length; i++)
    //    {
    //        if (!diff.ContainsKey(nums[i]))
    //            diff.Add(nums[i], i);
    //        else if (target - nums[i] == nums[i])
    //        {
    //            return new int[] { diff[nums[i]], i };
    //        }

    //    }

    //    for (int i= 0; i < nums.Length; i++)
    //    {
    //        if (diff.ContainsKey(target - nums[i]) )
    //        {
    //            first = i;
    //            second = diff[target - nums[i]];

    //            return new int[] { first, second };
    //        }
    //    }

    //    return null;
    //}

    //one pass
    public int[] TwoSum(int[] nums, int target)
    {
       
        for (int i = 0; i < nums.Length; i++)
        {
            if (!diff.ContainsKey(nums[i]))
            {
                if (diff.ContainsKey(target - nums[i]))
                {
                    return new int[] { diff[target - nums[i]], i };
                }
                diff.Add(nums[i], i);
            }
            else if (target - nums[i] == nums[i])
            {
                return new int[] { diff[nums[i]], i };
            }

        }

       
        return null;
    }
}
