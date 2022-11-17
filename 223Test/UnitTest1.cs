namespace _223Test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void NoOverlap()
    {
        Solution sol = new Solution();

        int area = sol.ComputeArea(0, 0, 10, 10, 10, 10, 20, 20);

        Assert.AreEqual(200, area);
    }

    [TestMethod]
    public void TotalOverlap()
    {
        Solution sol = new Solution();

        int area = sol.ComputeArea(0, 0, 10, 10, 0, 0, 10, 10);

        Assert.AreEqual(100, area);
    }

    [TestMethod]
    public void PartialOverlap()
    {
        Solution sol = new Solution();

        int area = sol.ComputeArea(0, 0, 10, 10, 5, 5, 15, 15);

        Assert.AreEqual(175, area);
    }

    [TestMethod]
    public void Sample1()
    {
        Solution sol = new Solution();

        int area = sol.ComputeArea(-3, 0, 3, 4, 0, -1, 9, 2);

        Assert.AreEqual(45, area);
    }

    [TestMethod]
    public void Sample2()
    {
        Solution sol = new Solution();

        int area = sol.ComputeArea(-2, -2, 2, 2, -2, -2, 2, 2);

        Assert.AreEqual(16, area);
    }
}