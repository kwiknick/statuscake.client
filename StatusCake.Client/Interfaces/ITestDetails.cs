using StatusCake.Client.Enumerators;
using StatusCake.Client.Models;
using System;
using System.Collections.Generic;

namespace StatusCake.Client.Interfaces
{
  public interface ITestDetails
  {
    int CheckRate { get; set; }
    string Confirmation { get; set; }
    string ContactGroup { get; set; }
    List<ContactGroup> ContactGroups { get; set; }
    int ContactID { get; set; }
    string CustomHeader { get; set; }
    string DNSIP { get; set; }
    string DNSServer { get; set; }
    bool DoNotFind { get; set; }
    int DownTimes { get; set; }
    bool EnableSSLWarning { get; set; }
    string FinalEndpoint { get; set; }
    string FindString { get; set; }
    bool FollowRedirect { get; set; }
    DateTime LastTested { get; set; }
    string LogoImage { get; set; }
    string NextLocation { get; set; }
    List<string> NodeLocations { get; set; }
    bool Paused { get; set; }
    string PostRaw { get; set; }
    bool Processing { get; set; }
    string ProcessingOn { get; set; }
    string ProcessingState { get; set; }
    bool Sensitive { get; set; }
    string Status { get; set; }
    List<string> StatusCodes { get; set; }
    int TestID { get; set; }
    TestType TestType { get; set; }
    int Timeout { get; set; }
    string TriggerRate { get; set; }
    double Uptime { get; set; }
    string URI { get; set; }
    int UseJar { get; set; }
    string WebsiteHost { get; set; }
    string WebsiteName { get; set; }
  }
}