using StatusCake.Client.Enumerators;
using System;
using System.Collections.Generic;

namespace StatusCake.Client.Models
{
  /// <summary>
  /// The details of a test
  /// </summary>
  public class TestDetails
  {
    /// <summary>
    /// The unique ID of the test
    /// </summary>
    public int TestID { get; set; }

    /// <summary>
    /// The type of the test. Possible values: HTTP or TCP
    /// </summary>
    public TestType TestType { get; set; }

    /// <summary>
    /// True if the test is paused
    /// </summary>
    public bool Paused { get; set; }

    /// <summary>
    /// The name of the test
    /// </summary>
    public string WebsiteName { get; set; }

    /// <summary>
    /// The URI of the test
    /// </summary>
    public string URI { get; set; }

    /// <summary>
    /// Contains the contact group or null if the group is not set
    /// </summary>
    public string ContactGroup { get; set; }

    /// <summary>
    /// The contact ID the test is tied to
    /// </summary>
    public int ContactID { get; set; }

    /// <summary>
    /// Contains the ContactGroups Array or null if the group is not set
    /// </summary>
    public List<ContactGroup> ContactGroups { get; set; }

    /// <summary>
    /// Current status of the test. Possible values: Up, Down
    /// </summary>
    public string Status { get; set; }

    /// <summary>
    /// The uptime percentage for the last day
    /// </summary>
    public double Uptime { get; set; }

    /// <summary>
    /// The check rate in seconds
    /// </summary>
    public int CheckRate { get; set; }

    /// <summary>
    /// The test check timeout in seconds
    /// </summary>
    public int Timeout { get; set; }

    /// <summary>
    /// The URL of the logo image for public reporting
    /// </summary>
    public string LogoImage { get; set; }

    /// <summary>
    /// The URL of the logo image for public reporting
    /// </summary>
    public string Confirmation { get; set; }

    /// <summary>
    /// The URL of the logo image for public reporting
    /// </summary>
    public string FinalEndpoint { get; set; }    

    /// <summary>
    /// User entered value for Website Host
    /// </summary>
    public string WebsiteHost { get; set; }

    /// <summary>
    /// A list of locations selected to test from
    /// </summary>
    public List<string> NodeLocations { get; set; }

    /// <summary>
    /// The string the test will look for in the response
    /// </summary>
    public string FindString { get; set; }

    /// <summary>
    /// If a string should be found or not be ound in the result
    /// </summary>
    public string DoNotFind { get; set; }

    /// <summary>
    /// The last time the test was ran
    /// </summary>
    public DateTime LastTested { get; set; }

    /// <summary>
    /// The next location where the test will be ran from
    /// </summary>
    public string NextLocation { get; set; }

    /// <summary>
    /// True if the website is currently being tested
    /// </summary>
    public bool Processing { get; set; }

    /// <summary>
    /// The current test status
    /// </summary>
    public string ProcessingState { get; set; }

    /// <summary>
    /// The server that is processing the test
    /// </summary>
    public string ProcessingOn { get; set; }

    /// <summary>
    /// The amount of consecutive downtimes recorded for this test
    /// </summary>
    public int DownTimes { get; set; }

    /// <summary>
    /// The Trigger Rate of the Test
    /// </summary>
    public string TriggerRate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Sensitive { get; set; }

    /// <summary>
    /// If SSLWarning is Enabled
    /// </summary>
    public bool EnableSSLWarning { get; set; }

    /// <summary>
    /// If Follow Redirect is Enabled
    /// </summary>
    public bool FollowRedirect { get; set; }

    /// <summary>
    /// The DNS IP of the Test
    /// </summary>
    public string DNSIP { get; set; }

    /// <summary>
    /// The DNS Server of the Test
    /// </summary>
    public string DNSServer { get; set; }

    /// <summary>
    /// The Custom Header of the Test
    /// </summary>
    public string CustomHeader { get; set; }

    /// <summary>
    /// The PostRaw of the Test
    /// </summary>
    public string PostRaw { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public int UseJar { get; set; }

    /// <summary>
    /// The StatusCodes to fail on of the Test
    /// </summary>
    public List<string> StatusCodes { get; set; }
  }
}
