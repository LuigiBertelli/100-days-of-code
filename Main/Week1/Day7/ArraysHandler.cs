using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day7
{
    public class ArraysHandler
    {

        //Given two sorted integer arrays, merge the second into the first one
        public static void mergeSortedArrays(ref int[] nums1, int[] nums2){
            for(int i = 0; i <= nums2.GetUpperBound(0); i++) {
                nums1.SetValue(nums2[i], nums1.GetUpperBound(0) - (nums2.GetUpperBound(0) - i));
            }
            Array.Sort(nums1);
        }

        //Given two sorted integer arrays, merge the second into the first one (V2)
        public static void mergeSortedArraysV2(ref int[] nums1, int[] nums2){
            List<int> nums1List = new List<int>(nums1);
            nums1List.AddRange(nums2);
            nums1 = nums1List.Where(x => x > 0).OrderBy(x => x).ToArray();
        }
    }
}