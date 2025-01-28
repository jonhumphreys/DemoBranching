namespace TestProject;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(true);
    }
    
    [Fact]
    public void Test2AndStringIsEmpty()
    {
        // this was stupid
        Assert.False(!true);
        Assert.Empty(String.Empty);
        Assert.True(!false);
    }
}
