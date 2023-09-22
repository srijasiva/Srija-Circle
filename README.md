
# Srija-Circle
Srija Circle Health repository on GitHub.
# Running C# Selenium SpecFlow Tests from the Command Prompt

This guide will walk you through the steps to execute C# Selenium SpecFlow tests from the command prompt.

## Prerequisites

Before you begin, make sure you have the following software installed on your machine:

- [Visual Studio](https://visualstudio.microsoft.com/): You need Visual Studio to create and manage your SpecFlow project.
- [SpecFlow Extension](https://marketplace.visualstudio.com/items?itemName=TechTalkSpecFlowTeam.SpecFlowforVisualStudio): Install SpecFlow extension for Visual Studio from the Visual Studio Marketplace.
- [NuGet Package Manager](https://www.nuget.org/downloads): Ensure you have NuGet installed, as it's used to manage dependencies for your project.
- [Selenium WebDriver](https://www.selenium.dev/documentation/en/webdriver/dotnet_guide/installing_browser_drivers/): Install the Selenium WebDriver packages via NuGet for your project.

Steps

1. Created a SpecFlow project in Visual Studio.
2. Writen SpecFlow feature files and step definitions. These files define the behavior of your tests.

3. Build  SpecFlow project to ensure that it compiles successfully.

4. **Run the Tests from the Command Prompt**:

   Use the SpecFlow CLI tool (`specflow.exe`) to run your tests from the command prompt. Here are the steps:

   - Open the command prompt.
   - Navigate to the root folder of your SpecFlow project.
   - Run the following command to execute your SpecFlow tests:

     ```bash
     specflow.exe run "Path\CircleHealth.csproj" /testExecution:NUnit
     ```
5. **View Test Results**:

   After the tests run, you'll see the test results in the command prompt. Any failures or errors will be displayed, including stack traces to help you identify issues.


