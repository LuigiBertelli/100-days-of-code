using Xunit;
using Day7;

namespace TestDay7{
    public class UnitTest1
    {

        [Theory(DisplayName = "When inputs are valid integer arrays, return success.")]
        [InlineData(
            new int[7]{1,2,3,0,0,0,0},
            new int[4]{1,2,3,5},
            new int[7]{1,1,2,2,3,3,5}
        )]
        [InlineData(
            new int[4]{1,3,6,0},
            new int[1]{9},
            new int[4]{1,3,6,9}
        )]
        [InlineData(
            new int[10]{1,7,12,0,0,0,0,0,0,0},
            new int[7]{1,2,3,5,9,22,25},
            new int[10]{1,1,2,3,5,7,9,12,22,25}
        )]
        public void TestmergeSortedArrays(int[] nums1, int[] nums2, int[] expectedResult)
        {
            ArraysHandler.mergeSortedArrays(ref nums1, nums2);

            Assert.Equal(expectedResult, nums1);
        }
        
        [Theory(DisplayName = "When inputs are valid integer arrays, return success. (V2)")]
        [InlineData(
            new int[7]{1,2,3,0,0,0,0},
            new int[4]{1,2,3,5},
            new int[7]{1,1,2,2,3,3,5}
        )]
        [InlineData(
            new int[4]{1,3,6,0},
            new int[1]{9},
            new int[4]{1,3,6,9}
        )]
        [InlineData(
            new int[10]{1,7,12,0,0,0,0,0,0,0},
            new int[7]{1,2,3,5,9,22,25},
            new int[10]{1,1,2,3,5,7,9,12,22,25}
        )]
        public void TestmergeSortedArraysV2(int[] nums1, int[] nums2, int[] expectedResult)
        {
            ArraysHandler.mergeSortedArraysV2(ref nums1, nums2);

            Assert.Equal(expectedResult, nums1);
        }
    }
}