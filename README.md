# College <picture><img alt="top lang" src="https://img.shields.io/github/languages/top/ervinoks/College?color=388A34"></picture> <picture><img alt="repo size" src="https://img.shields.io/github/repo-size/ervinoks/College"></picture> <picture><img alt="last commit" src="https://img.shields.io/github/last-commit/ervinoks/College"></picture>
All my programming throughout college. The tasks I do can usually be found in the .pdf files which are in the folder alongside the source files. In some projects, especially the earliest ones, I have different <samp>.cs</samp> files for different programs all in the same project, so you can just go into Properties to change the startup object to the desired program that you want to run ([how-to](#vs-com)).

## What the letters mean:
<table>
    <tr>
        <th align="center">A</td>
        <th align="center">L</td>
        <th align="center">W</td>
        <th rowspan="3"></td>
        <th align="center">Assessments / CAP</td>
    </tr>
    <tr>
        <td align="center">
            <table>
            <tr><td align="center"><a href="Assignments">Assignments<br>
            <picture><img alt="dir count in Assignments" src="https://img.shields.io/github/directory-file-count/ervinoks/College/Assignments?type=dir&color=lightgrey"></picture></a></td></tr></td>
            </table>
        <td align="center">
            <table>
            <tr><td align="center"><a href="Lessons">Lessons<br>
            <picture><img alt="dir count in Lessons" src="https://img.shields.io/github/directory-file-count/ervinoks/College/Lessons?type=dir&color=lightgrey"></picture></a></td></tr></td>
            </table>
        <td align="center">
            <table>
            <tr><td align="center"><a href="Worksheets">Worksheets<br>
            <picture><img alt="dir count in Worksheets" src="https://img.shields.io/github/directory-file-count/ervinoks/College/Worksheets?type=dir&color=lightgrey"></picture></a></td></tr></td>
            </table>
        <td align="center">
            <table>
            <tr><td align="center"><a href="Assessments">Assessments<br>
            <picture><img alt="dir count in Assessments" src="https://img.shields.io/github/directory-file-count/ervinoks/College/Assessments?type=dir&color=lightgrey"></picture></a></td></tr></td>
            </table>
    </tr>
    <tr>
        <td align="center">These are my key weekly assignments, which is mandatory homework.</td>
        <td align="center">These are usually done in class after learning a specific topic or something.</td>
        <td align="center">These are the worksheets that I do, all of them accessible from my college's compsci website, typically I do them in class.</td>
        <td rowspan="1" align="center"><b>CAP</b> stands for 'College Assessment Point', these are like practice exams for us to revise what we've learned in the past few months, and to also do it in silence as if it's an exam. The assessments are also like the CAPs.
    </tr>
    <tr>
        <td colspan="3" align="justify">The first number signifies what year of college that work is, so 1<sup>ﬆ</sup> Year or 2<sup>nd</sup> Year. The following two numbers state what index that piece of work is, 00 being the very first, and so on (the index ≤99). However for worksheets there could be WX## which means it's an extension worksheet. </td>
    </tr>
</table>

## How to open the solution:
Using [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/ "Download Visual Studio Community") tends to be much more intuitive to use than [Visual Studio Code](https://code.visualstudio.com/ "Download Visual Studio Code") for C#.

However for VSCode, you require the [C# extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp "Download the C# extension"), but more likely you'll want [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit "Download C# Dev Kit") (will automatically install C# and Intellicode) and as well as [Git](https://git-scm.com/downloads "Download Git") if you wish to clone this repository directly into VSCode - for Visual Studio Community you can find it as an individual component (see [Dependencies](#dependencies)).
- Once you have Git, you can view the code and edit, but debugging can get tedious. 
- It's possible to use <kbd><samp>Run and Debug</samp></kbd> and make a <samp>launch.json</samp> - see the VSCode Docs for [Debugging](https://code.visualstudio.com/docs/editor/debugging "Open Visual Studio Code Docs"), or use the terminal and use <samp>`dotnet`</samp> commands, such as: 
    ```batch
    dotnet build
    dotnet run
    ```
    or by trying to launch the <samp>.exe</samp> it creates in <samp>\bin\Debug</samp> once it has compiled (but obviously there are no debug features).

C# Dev Kit is very new to VSCode, so it's still in preview (however the C# extension already existed). But currently it doesn't support .NET Framework for intuitive debugging, because it's not in the SDK style: see <ins>https://stackoverflow.com/a/68110363</ins>. I might change to the new SDK style in the future.

---
<a id="vs-com" />With Visual Studio Community, things should work right away without any extensions:
- You can easily clone the repository as soon as you launch it up, instead of creating a new project or solution.  
 Or you can clone it through the Git option at the top of the window, then copying the URL - https://github.com/ervinoks/College.git.
 - Once you have the solution open, you can choose any desired project using the drop down window in the debug toolbar.
    - Or to run specific <samp>.cs</samp> files, double click <kbd><samp>Properties</samp></kbd> in that class, and make sure you're in <kbd><samp>Application</samp></kbd>. 
    - Under <kbd><samp>Startup object:</samp></kbd> it will likely say <kbd><samp>(Not set)</samp></kbd>, change this to the desired program, <kbd><kbd>Ctrl</kbd>+<kbd>S</kbd></kbd> to save.
- Then once you click <kbd><picture><img src="https://github.com/ervinoks/College/assets/37591724/7d123503-75d1-47b2-b7c8-c75485454391" width='9' height='9'></picture><samp> Start</samp></kbd> (or just <kbd><picture><img src="https://github.com/ervinoks/College/assets/37591724/982379dc-5468-4c86-908d-b2dad7094137" width='9' height='9' title="Start Without Debugging (Ctrl+F5)"></picture></kbd>), it will run that selected program.
- You can also add breakpoints as necessary to see what happens throughout the code, by just clicking in the margin on the left of the code editor, to the left of the line numbers until you see:
<kbd><picture><source media="(prefers-color-scheme: dark)" srcset="https://github.com/ervinoks/College/assets/37591724/2dd0bd0c-c6fb-4f57-98ca-e1d581fee13e"><img src="https://github.com/ervinoks/College/assets/37591724/94b977f5-7ce6-4502-9f2a-ca004e8910df" width='11' height='11' title="Breakpoint Available"></picture></kbd>, then click to enable it: <kbd><picture><img src="https://github.com/ervinoks/College/assets/37591724/5c99624f-7834-498b-8cbc-07d175075edd" width='11' height='11' title="Breakpoint Enabled"></picture></kbd>.


## Dependencies
You also will need [<samp>.NET SDK</samp>s](https://dotnet.microsoft.com/en-us/download/visual-studio-sdks "Download .NET SDK") to run everything, especially <samp>.NET Framework</samp>, and you could also get the <samp>.NET/.NET Core SDK</samp>s off of there. With both VSCode and Visual Studio community, you might have errors without <samp>.NET 4.8</samp>. However with Visual Studio Community you can just go to the VS Installer app which should already be on your computer, and modify your installation to your liking, also being able to search for individual components. Furthermore, you can import configurations, here's a basic config which should run this Solution as expected: [vsconfig.zip](https://github.com/ervinoks/College/files/11683051/vsconfig.zip "Download vsconfig.zip").
