using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatusCake.Client.Models;
using System.Collections.Generic;

namespace StatusCake.Client.Tests
{
  [TestClass]
  public class StatusCakeClient_IT
  {
    [TestMethod]
    public void GetTestDetails_IT()
    {
      //Arrange
      List<TestDetails> objTestDetails = new List<TestDetails>();
      StatusCakeClient objStatusCakeClient = new StatusCakeClient();
      var objStatusCakeTests = objStatusCakeClient.GetTestsAsync().Result;

      //Act
      foreach (var objStatusCakeTest in objStatusCakeTests)
      {
        objTestDetails.Add(objStatusCakeClient.GetTestDetailsAsync(objStatusCakeTest.TestID).Result);
      }

      //Assert
      Assert.IsTrue(objTestDetails.Count > 0);
    }
  }
}
