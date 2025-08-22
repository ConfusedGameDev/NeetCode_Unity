using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;

public class ValidAnagram  : MonoBehaviour
{

    [Button]
    public bool IsAnagram(string s, string t)
    {
        if(s == null || t == null || s.Length != t.Length|| s.Length==0|| t.Length==0)
            return false;
      Dictionary<char, int> anagram = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if(anagram.ContainsKey(s[i]))
            {
                anagram[s[i]]++;
            }
            else
            {
                anagram[s[i]] = 1;
            }
            
        }

        for (int i = 0; i < t.Length; i++)
        {
            if (!anagram.ContainsKey(t[i] )|| anagram[t[i]]<=0) 
                return false;
            else
            {
                 anagram[t[i]]--;
            }
        }

        return true;

    }
}
