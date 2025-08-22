using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;

public class ContainsDuplicate : MonoBehaviour
{
    public int[] nums;

    [Button]
    public void test()
    {
      Debug.Log(hasDuplicate(nums));
    }
    public bool hasDuplicate(int[] nums)
    {
        if (nums == null|| nums.Length == 0) return false;
        HashSet<int> values= new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (values.Contains(nums[i])) return true;

            values.Add(nums[i]);


        }
        return false;
    }
}
