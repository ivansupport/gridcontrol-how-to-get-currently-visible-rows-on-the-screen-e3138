﻿' Developer Express Code Central Example:
' How to get visible rows on the screen
' 
' You should get a DataPresenter. This dependency object supports the IScrollInfo
' interface. This interface provides the VerticalOffset and ViewportHeight
' properties. In fact, the VerticalOffset property is a VisibleIndex for the first
' row, but the ViewprotHeight is a number of visible rows. Use the
' GridControl.GetRowHandleByVisibleIndex method to get the first visible and last
' visible row handles. If the last row handle is not valid, it means that you try
' to parse empty space, and the last row handle on the screen is the last row
' within row handles.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3138

Imports System.Reflection
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.
<Assembly: AssemblyTitle("IScrollInfoSample")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyConfiguration("")>
<Assembly: AssemblyCompany("")>
<Assembly: AssemblyProduct("IScrollInfoSample")>
<Assembly: AssemblyCopyright("Copyright ©  2009")>
<Assembly: AssemblyTrademark("")>
<Assembly: AssemblyCulture("")>

' Setting ComVisible to false makes the types in this assembly not visible 
' to COM components.  If you need to access a type in this assembly from 
' COM, set the ComVisible attribute to true on that type.
<Assembly: ComVisible(False)>

'In order to begin building localizable applications, set 
'<UICulture>CultureYouAreCodingWith</UICulture> in your .csproj file
'inside a <PropertyGroup>.  For example, if you are using US english
'in your source files, set the <UICulture> to en-US.  Then uncomment
'the NeutralResourceLanguage attribute below.  Update the "en-US" in
'the line below to match the UICulture setting in the project file.

'[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)]


<Assembly: ThemeInfo(ResourceDictionaryLocation.None, ResourceDictionaryLocation.SourceAssembly)> 'where the generic resource dictionary is located - where theme specific resource dictionaries are located
    '(used if a resource is not found in the page, 
    ' or application resource dictionaries)
    '(used if a resource is not found in the page, 
    ' app, or any theme specific resource dictionaries)


' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
' You can specify all the values or you can default the Build and Revision Numbers 
' by using the '*' as shown below:
' [assembly: AssemblyVersion("1.0.*")]
<Assembly: AssemblyVersion("1.0.0.0")>
<Assembly: AssemblyFileVersion("1.0.0.0")>