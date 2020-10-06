using StatusCake.Client.Enumerators;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StatusCake.Client.Models
{
  /// <summary>
  /// StatusCake test details
  /// </summary>
  public class TestUpdate
  {
    /// <summary>
    /// Create a new TestUpdate with the default values
    /// </summary>
    public TestUpdate(string testName, string url, int checkRate, TestType TestType)
    {
      this.Initialize();

      // Set the initial values
      this.TestType = TestType;
      this.WebsiteName = testName;
      this.WebsiteURL = url;
      this.CheckRate = checkRate;
    }

    /// <summary>
    /// Create a new TestUpdate with the current data from an existing test
    /// </summary>
    public TestUpdate(Test test, string url, int checkRate)
    {
      this.Initialize();

      // Copy the values from an existing test
      this.TestID = test.TestID;
      this.TestType = test.TestType;
      this.WebsiteName = test.WebsiteName;
      this.WebsiteURL = url;
      this.CheckRate = checkRate;
    }

    /// <summary>
    /// Initialize the model with the default values
    /// </summary>
    private void Initialize()
    {
      this.BasicPass = null;
      this.BasicUser = null;
      this.CheckRate = 300;
      this.Confirmations = null;
      this.ContactGroupID = null;
      this.CustomHeader = null;
      this.DisplayBranding = null;
      this.DNSIP = null;
      this.DNSServer = null;
      this.DoNotFind = null;
      this.EnableSSLAlert = null;
      this.FindString = null;
      this.FollowRedirect = null;
      this.IncludeHeader = null;
      this.LogoImageUrl = null;
      this.NodeLocations = null;
      this.Paused = null;
      this.PingURL = null;
      this.Port = null;
      this.PostBody = null;
      this.PostRaw = null;
      this.PublicReporting = null;
      this.StatusCodes = null;
      this.TestID = null;
      this.TestTags = null;
      this.TestType = null;
      this.TestWithRealBrowser = null;
      this.Timeout = 30;
      this.TriggerRate = null;
      this.UseJar = null;
      this.UserAgent = null;
      this.VirusCheckEnabled = null;
      this.WebsiteHost = null;
      this.WebsiteName = null;
      this.WebsiteURL = null;
    }

    /// <summary>
    /// If BasicUser is set then this should be the password for the BasicUser
    /// </summary>
    public string BasicPass { get; set; }

    /// <summary>
    /// A Basic Auth User account to use to login
    /// </summary>
    public string BasicUser { get; set; }

    /// <summary>
    /// The check rate in seconds at which the website will be tested.  Default: 300
    /// </summary>
    [Required(AllowEmptyStrings = false, ErrorMessage = "CheckRate is Required")]
    [Range(0, 24000)]
    public int CheckRate { get; set; }

    /// <summary>
    /// The number of confirmation
    /// </summary>
    [Range(0, 10)]
    public int? Confirmations { get; set; }

    /// <summary>
    /// Contains the contact group or null if the group is not set
    /// </summary>
    public long? ContactGroupID { get; set; }

    /// <summary>
    /// Custom HTTP header.  Must be supplied as JSON.
    /// </summary>
    public string CustomHeader { get; set; }

    /// <summary>
    /// Set to true to use branding (default) or false to disable public reporting branding. Default: true
    /// </summary>
    public bool? DisplayBranding { get; set; }

    /// <summary>
    /// DNS Tests only.  IP to compare against WebsiteURL value.
    /// </summary>
    public string DNSIP { get; set; }

    /// <summary>
    /// DNS Tests only.  Hostname or IP of DNS server to use.
    /// </summary>
    public string DNSServer { get; set; }    

    /// <summary>
    /// Set to true to invert the FindString value
    /// </summary>
    public bool? DoNotFind { get; set; }

    /// <summary>
    /// HTTP Tests only. If set to true, tests will send warnings if the SSL certificate is about to expire. Paid users only. Default: false
    /// </summary>
    public bool? EnableSSLAlert { get; set; }

    /// <summary>
    /// A string that should either be found or not found in the test response
    /// </summary>
    public string FindString { get; set; }

    /// <summary>
    /// HTTP Tests only. If enabled, our tests will follow redirects and log the status of the final page. Default: true
    /// </summary>
    public bool? FollowRedirect { get; set; }

    /// <summary>
    /// Include header content in string match search. Default: false
    /// </summary>
    public bool? IncludeHeader { get; set; }

    /// <summary>
    /// The Url to the logo image in the public reporting
    /// </summary>
    public string LogoImageUrl { get; set; }

    /// <summary>
    /// A List of locations where the test will be ran from (using the Node Location IDs) Default: Random Locations
    /// </summary>
    public List<string> NodeLocations { get; set; }

    /// <summary>
    /// If the Test is paused.  Default: false
    /// </summary>
    public bool? Paused { get; set; }

    /// <summary>
    /// The URL to ping if a site goes down.
    /// </summary>
    public string PingURL { get; set; }

    /// <summary>
    /// The port where the website will be pinged
    /// </summary>
    public int? Port { get; set; }

    /// <summary>
    /// HTTP Tests only. Converts JSON object to formdata. Changes HTTP method to POST
    /// </summary>
    public string PostBody { get; set; }

    /// <summary>
    /// HTTP Tests only. Sends string to server. Changes HTTP method to POST
    /// </summary>
    public string PostRaw { get; set; }

    /// <summary>
    /// Set to true to enable public reporting for the test. Default: false
    /// </summary>
    public bool? PublicReporting { get; set; }    

    /// <summary>
    /// The list of status codes that should trigger the error.  (On Update will replace, so send full list each time)
    /// </summary>
    public List<int> StatusCodes { get; set; }

    /// <summary>
    /// The unique ID of the test to update.  If not provided, a new test will be created.
    /// </summary>
    public int? TestID { get; set; }

    /// <summary>
    /// List of Tags for the test
    /// </summary>
    public List<string> TestTags { get; set; }

    /// <summary>
    /// The type of the test.
    /// </summary>
    [Required(AllowEmptyStrings = false, ErrorMessage = "TestType is Required")]
    public TestType? TestType { get; set; }

    /// <summary>
    /// Set to true to test the website with a real browser
    /// </summary>
    public bool? TestWithRealBrowser { get; set; }

    /// <summary>
    /// The timeout of the tests in seconds. Default: 30 Seconds
    /// </summary>
    [Range(5, 100)]
    public int? Timeout { get; set; }

    /// <summary>
    /// How many minutes to wait before sending an event. Default: 5 Minutes
    /// </summary>
    [Range(0, 60)]
    public int? TriggerRate { get; set; }

    /// <summary>
    /// Set to true to enable the Cookie Jar. Required for some redirects. Default: false
    /// </summary>
    public bool? UseJar { get; set; }

    /// <summary>
    /// The User Agent you want to send with the test
    /// </summary>
    public string UserAgent { get; set; }

    /// <summary>
    /// Set to true to enable virus checking on the website
    /// </summary>
    public bool? VirusCheckEnabled { get; set; }

    /// <summary>
    /// The website host
    /// </summary>
    public string WebsiteHost { get; set; }

    /// <summary>
    /// The name of the Test
    /// </summary>
    [Required(AllowEmptyStrings = false, ErrorMessage = "WebsiteName is Required")]
    public string WebsiteName { get; set; }

    /// <summary>
    /// The URL of the website that will be tested
    /// </summary>
    [Required(AllowEmptyStrings = false, ErrorMessage = "WebsiteURL is Required")]
    public string WebsiteURL { get; set; }    
  }
}
