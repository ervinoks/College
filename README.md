# College
All my programming throughout college. The tasks I do can usually be found in the .pdf files which are in the folder alongside the source files. Typically I have different `.cs` files for multiple programs, and I go into Properties to change the startup object to my desired program.

## What the letters mean:
**A** for assignment, these are my key weekly assignments which are mandatory.

**L** for lesson, these are some extra non-mandatory tasks that I'm able to do, usually a few in class, then I try to complete the rest of them outside of class.

**W** for worksheet, these are the worksheets that I do, all of them accessible from my college's compsci website, most of the time I do them in class. 

The first number signifies what year of college that work is, so Year 1 or Year 2. The following two numbers state what index that piece of work is, 00 being the very first, and so on.

## How to open the solution
Using [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/ "Download Visual Studio Community") tends to be much more intuitive to use than [Visual Studio Code](https://code.visualstudio.com/ "Download Visual Studio Code") for C#.
However for VSCode, you require the [C# extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp "Download the C# extension"), and likely the [GitHub extension](https://marketplace.visualstudio.com/items?itemName=GitHub.vscode-pull-request-github "Download the GitHub extension") if you wish to clone this repository directly into VSCode.  
- Once you have these extensions, you can view the code and edit, but debugging can get tedious. 
- It's possible to use **"Run and Debug"** and make a launch.json, or use the terminal and use `dotnet` commands, such as: 
    ```batch
    dotnet build 
    dotnet run
    ```
    or by trying to launch the `.exe` it creates in `\bin\Debug` once it has compiled.

With Visual Studio Community, things should work right away without any extensions:
- You can easily clone the repository as soon as you launch it up, instead of creating a new project or solution.  
 Or you can clone it through the Git option at the top of the window, then copying the URL - https://github.com/3leh/College.git.
- Once you have the solution open, to run specific **.cs** files, double click **"Properties"** in that class, and make sure you're in **"Application"**. 
- Under **"Startup object:"** it will likely say **"(Not set)"**, change this to the desired program, Ctrl+S to save.
- Then once you click "**<img src="https://user-images.githubusercontent.com/37591724/211109448-66de17b4-f41a-4219-9afa-5c084ecd5c6a.svg" width="11" height="11"> Start**" for that class, it will run that selected program.

You also will need [.NET SDKs](https://dotnet.microsoft.com/en-us/download/visual-studio-sdks "Download .NET") to run everything, preferably a .NET 6.0 SDK, and you could also get the latest .NET framework off of there, which I recommended especially for use with VSCode, as OmniSharp (which is what the C# extension uses) might have errors without .NET 4.8.
