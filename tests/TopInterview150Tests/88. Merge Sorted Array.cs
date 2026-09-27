namespace TopInterview150Tests;

public class MergeSortedArray
{
    [Theory]
    [InlineData(new[] {1,2,3,0,0,0}, 3, new[] {2,5,6}, 3, new[] {1,2,2,3,5,6})]
    [InlineData(new[] {1}, 1, new int[] {}, 0, new[] {1})]
    [InlineData(new [] {0}, 0, new int[] {1}, 1, new[] {1})]
    public void Test_MergeSortedArray(int[] arr1, int m, int[] arr2, int n, int[] expected)
    {
        var sol = new mergeSortedArray.Solution();
        sol.Merge(arr1, m,arr2, n);
        
        Assert.Equal(expected, arr1);
    }
    
}