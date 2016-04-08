using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rhino.PlugIns;

[assembly: PlugInDescription(DescriptionType.Address,      "")]
[assembly: PlugInDescription(DescriptionType.Country,      "Australia")]
[assembly: PlugInDescription(DescriptionType.Email,        "thetonyho@gmail.com")]
[assembly: PlugInDescription(DescriptionType.Phone,        "")]
[assembly: PlugInDescription(DescriptionType.Organization, "Tony Ho")]
[assembly: PlugInDescription(DescriptionType.UpdateUrl,    "https://raw.githubusercontent.com/theTonyHo/MyPythonPlugin/master/build/MyPythonPlugin.rhp")]
[assembly: PlugInDescription(DescriptionType.WebSite,      "http://www.thetonyho.net")]

[assembly: AssemblyTitle("MyPythonPlugin")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("MyPythonPlugin")]
[assembly: AssemblyCopyright("Copyright © Tony Ho 2016")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]
[assembly: Guid("7bb47b08-e0ce-95e6-19ff-4a3e0a5e5da6")]
[assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyInformationalVersion("2")]

public class CompilerPlugin : PlugIn 
{ 
  protected override LoadReturnCode OnLoad(ref string errorMessage)
  {
    // Display message.
    string message = @"Welcome this is a sample message";
    if (!string.IsNullOrEmpty(message))
      Rhino.RhinoApp.WriteLine(message);

    return LoadReturnCode.Success;
  }

  private static bool librariesLoaded = false;
  internal static void LoadLibraries()
  {
    if (librariesLoaded) return;
    librariesLoaded = true;

    
  }
}