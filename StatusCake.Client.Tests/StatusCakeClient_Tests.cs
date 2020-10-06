using Moq;
using NUnit.Framework;
using StatusCake.Client.Interfaces;
using StatusCake.Client.Models;
using System.Threading.Tasks;

namespace StatusCake.Client.Tests
{
  [TestFixture]
  public class StatusCakeClient_Tests
  {
    private readonly Mock<IStatusCakeClient> _objMockStatusCakeClient;
    private readonly StatusCakeClient _objStatusCakeClient;
    private readonly TestDetails _objTestDetails = new TestDetails();

    public StatusCakeClient_Tests()
    {
      _objMockStatusCakeClient = new Mock<IStatusCakeClient>();
      _objStatusCakeClient = new StatusCakeClient();
    }

    [Test]
    public async Task GetTestDetailsAsync_WhenCalled_ShouldReturnTestDetailsAsync() // [MethodName]_[Scenario]_[ExpectedBehavior]
    {
      //Arrange        
      _objMockStatusCakeClient.Setup(sc => sc.GetTestDetailsAsync(It.IsAny<long>())).ReturnsAsync(_objTestDetails);

      //Act
      var result = _objStatusCakeClient.GetTestDetailsAsync(It.IsAny<long>()).Result;

      //Assert
      Assert.NotNull(result);
      Assert.IsInstanceOf(typeof(TestDetails), result);
      //_objMockStatusCakeClient.Verify(sc => sc.GetTestDetailsAsync(It.IsAny<long>()), Times.Once);
    }
  }
}
