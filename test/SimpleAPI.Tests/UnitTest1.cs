using Simpleapi.SimpleApiController;

namespace SimpleAPI.Tests;

public class UnitTest1
{
    SimpleAPIController simpleAPIController=new SimpleAPIController();
    [Fact]
    public void GetReturnCorrectNumber()
    {
        var returnvalue= simpleAPIController.Get(5);
        Assert.Equal("Les Jackson", returnvalue.Value);
    }
}