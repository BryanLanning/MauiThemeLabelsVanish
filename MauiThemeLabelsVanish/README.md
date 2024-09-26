# Purpose: 
Demonstrate the issue where changing the Theme works for sub-pages, but the Label controls on the Shell's main page disappear after the theme is changed.

# Steps to recreate:
1. Create a new MAUI project in Visual Studio from the template.
1. Disable the iOS and MacCatalyst output targets as they're irrelevant for this example.
    1. In the Properties of the project, uncheck the iOS output target. Save and close Property pages.
    1. In the XML of the .csproj file, remove `;net8.0-maccatalyst`
    ```
    <TargetFrameworks>net8.0-android;net8.0-maccatalyst</TargetFrameworks>
    ```
1. Change the minimum supported version for the Windows target to 10.0.20348.0.
1. Add the WindowsSdkPackageVersion node to the .csproj file.  This is to fix the following error from the MVVM toolkit: 
    > MVVMTKCFG0003	This version of the MVVM Toolkit requires 'Microsoft.Windows.SDK.NET.Ref' version '10.0.20348.38' or later. Please update to .NET SDK 8.0.109, 8.0.305 or 8.0.402 (or later). Alternatively, use a temporary 'Microsoft.Windows.SDK.NET.Ref' reference, which can be done by setting the 'WindowsSdkPackageVersion' property in your .csproj file. For your project configuration, it is recommended to set the package version to '10.0.20348.41'.	MauiThemeLabelsVanish (net8.0-windows10.0.20348.0)	S:\packages\nuget\communitytoolkit.mvvm\8.3.2\buildTransitive\CommunityToolkit.Mvvm.WindowsSdk.targets
 [Reference](https://learn.microsoft.com/en-us/dotnet/core/compatibility/sdk/5.0/override-windows-sdk-package-version).
```
  <PropertyGroup>
    <!-- nuget package: Microsoft.Windows.SDK.NET.Ref -->
    <WindowsSdkPackageVersion>10.0.20348.45</WindowsSdkPackageVersion>
  </PropertyGroup>
```
1. Add `CommunityToolkit.Maui` and `CommunityToolkit.MVVM` NuGet packages.
1. Add the INavigationService and MauiNavigationService as seen in the [Navigation](https://learn.microsoft.com/en-us/dotnet/architecture/maui/navigation) section of Microsoft Learn's [Enterprise Application Patterns Using .NET MAUI](https://learn.microsoft.com/en-us/dotnet/architecture/maui/).
1. Add GlobalUsings.cs
1. Add a MainView with several types of controls, and a ThemeSelectionView to change the theme.  ViewModels, dependency-injection registration in MauiProgram and route registration in AppShell.xaml.cs as well.
1. Add a ThemeService and Theme dictionaries for Default/Red themes.
1. Change the StaticResources for the TargetType="Label" from StaticResource to DynamicResource.
1. Implement Theme switching as seen in Microsoft's Learn documentation for .NET MAUI 8 at [Theming&rarr;Respond To system theme changes](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/system-theme-changes?view=net-maui-8.0).
1. Add WeakMessage registration to AppShell to listen for changes to the theme.

# To Correct Behavior
## Option 1
Remove the `BackgroundColor` Setter from all TargetType="Label" styles.  Including ones with an x:Key (Headline and SubHeadline) and both DefaultTheme and RedTheme.

## Option 2
Move all TargetType="Label" styles from the Theme.xaml files to the App.xaml file inside the ResourceDictionary xml element, below the reference to the DefaultTheme.xaml.
