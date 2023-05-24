# College ![GitHub top language](https://img.shields.io/github/languages/top/3leh/College?color=blueviolet) ![GitHub repo size](https://img.shields.io/github/repo-size/3leh/College?color=green) ![GitHub last commit](https://img.shields.io/github/last-commit/3leh/College)
All my programming throughout college. The tasks I do can usually be found in the .pdf files which are in the folder alongside the source files. In some projects - especially the earliest ones - I have different `.cs` files for different programs all in the same project, so I go into Properties to change the startup object to my desired program (how-to steps are below).

## What the letters mean:
### A - Assignments ![GitHub repo dir count (Assignments)](https://img.shields.io/github/directory-file-count/3leh/College/Assignments?type=dir&color=lightgrey)
These are my key weekly assignments, which is mandatory homework.

### L - Lessons ![GitHub repo dir count (Lessons)](https://img.shields.io/github/directory-file-count/3leh/College/Lessons?type=dir&color=lightgrey)
These are usually done in class after learning a specific topic or something.

### W - Worksheets ![GitHub repo dir count (Worksheets)](https://img.shields.io/github/directory-file-count/3leh/College/Worksheets?type=dir&color=lightgrey)
These are the worksheets that I do, all of them accessible from my college's compsci website, typically I do them in class.

> The first number signifies what year of college that work is, so 1<sup>st</sup> Year or 2<sup>nd</sup> Year. The following two numbers state what index that piece of work is, 00 being the very first, and so on (the index ≤99). However for worksheets there could be WX## which means it's an extension worksheet. 

---

**CAP** for 'College Assessment Point', these are like practice exams for us to revise what we've learned in the past few months, and to also do it in silence as if it's an exam. The assessments are also like the CAPs.

## How to open the solution:
Using [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/ "Download Visual Studio Community") tends to be much more intuitive to use than [Visual Studio Code](https://code.visualstudio.com/ "Download Visual Studio Code") for C#.
However for VSCode, you require the [C# extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp "Download the C# extension"), and likely you'll want [Git](https://git-scm.com/downloads "Download Git") if you wish to clone this repository directly into VSCode - fpr Visual Studio Community you can find it as an individual component (see [Dependencies](#dependencies)).
- Once you have these extensions, you can view the code and edit, but debugging can get tedious. 
- It's possible to use **"Run and Debug"** and make a launch.json, or use the terminal and use `dotnet` commands, such as: 
    ```batch
    dotnet build
    dotnet run
    ```
    or by trying to launch the `.exe` it creates in `\bin\Debug` once it has compiled (but obviously no debug features).

With Visual Studio Community, things should work right away without any extensions:
- You can easily clone the repository as soon as you launch it up, instead of creating a new project or solution.  
 Or you can clone it through the Git option at the top of the window, then copying the URL - https://github.com/3leh/College.git.
 - Once you have the solution open, you can choose any desired project using the drop down window in the debug toolbar.
    - Or to run specific `.cs` files, double click **"Properties"** in that class, and make sure you're in **"Application"**. 
    - Under **"Startup object:"** it will likely say **"(Not set)"**, change this to the desired program, Ctrl+S to save.
- Then once you click "**<picture><img src="https://github.com/3leh/College/assets/37591724/7d123503-75d1-47b2-b7c8-c75485454391" width='11' height='11'></picture> Start**" (or just <picture><img src="https://github.com/3leh/College/assets/37591724/982379dc-5468-4c86-908d-b2dad7094137" width='11' height='11' title="Start Without Debugging (Ctrl+F5)"></picture>), it will run that selected program.
- You can also add breakpoints as necessary to see what happens throughout the code, by just clicking in the margin on the left of the code editor, to the left of the line numbers until you see:
<picture><source media="(prefers-color-scheme: dark)" srcset="https://github.com/3leh/College/assets/37591724/2dd0bd0c-c6fb-4f57-98ca-e1d581fee13e"><img src="https://github.com/3leh/College/assets/37591724/94b977f5-7ce6-4502-9f2a-ca004e8910df" width='11' height='11' title="Breakpoint Available"></picture>, then click to enable it: <picture><img src="https://github.com/3leh/College/assets/37591724/5c99624f-7834-498b-8cbc-07d175075edd" width='11' height='11' title="Breakpoint Enabled"></picture>.

## Dependencies
You also will need [`.NET` SDKs](https://dotnet.microsoft.com/en-us/download/visual-studio-sdks "Download .NET SDK") to run everything, preferably `.NET Framework`, and you could also get `.NET 6.0 SDK` off of there, which I recommended especially for use with VSCode, as OmniSharp (which is what the C# extension uses) might have errors without `.NET 4.8`. However with Visual Studio Community you can just go to the VS Installer app and modify your installation to your liking, and to search for individual components.
