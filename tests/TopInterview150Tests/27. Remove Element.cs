using Top_Interview_150._27._Remove_Element;
 
 namespace TopInterview150Tests;
 
 public class RemoveElement
 {
     [Theory]
     [InlineData(new[] { 3, 2, 2, 3 }, 3, 2, new[] { 2, 2 })]
     [InlineData(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5, new[] { 0, 0, 1, 3, 4 })]
     public void Test_RemoveElement(
         int[] nums,
         int val,
         int expectedK,
         int[] expectedNums)
     {
         var sol = new Solution();

         var k = sol.RemoveElement(nums, val);

         Assert.Equal(expectedK, k);

         var actual = nums[..k];

         Array.Sort(actual);
         Array.Sort(expectedNums);

         Assert.Equal(expectedNums, actual);
     }
 }