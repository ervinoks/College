# College <a href=https://learn.microsoft.com/en-us/dotnet/csharp/><img alt="language | c#" src="https://img.shields.io/badge/-csharp-512BD4?logo=csharp"></a> <picture><img alt="repo size" src="https://img.shields.io/github/repo-size/ervinoks/College?labelColor=grey"></picture> <picture><img alt="last commit" src="https://img.shields.io/github/last-commit/ervinoks/College"></picture> <a href=https://opensource.org/license/mit/><img alt="license | MIT" src="https://img.shields.io/badge/License-MIT-ac8b11.svg?labelColor=yellow"></a>


All my programming throughout college. The tasks I do can usually be found in the <samp>.pdf</samp> files which are in the folder alongside the source files. In some projects, especially the earliest ones, I have different <samp>.cs</samp> files for different programs all in the same project, so you can just go into Properties to change the startup object to the desired program that you want to run ([how-to](#vs-com)).

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
        <td align="center">These are the worksheets that I do, all of them accessible from my college's compsci website, typically I do them in class. There aren't many 2nd Year worksheets, as I work on my NEA instead, but there is some <a href=https://www.haskell.org/><img alt="language | haskell" src="https://img.shields.io/badge/-haskell-5D4F85?logo=haskell"></a> that I do, to help understand functional programming.</td>
        <td rowspan="1" align="center"><b>CAP</b> stands for 'College Assessment Point', these are like practice exams for us to revise what we've learned in the past few months, and to also do it in silence as if it's an exam. The assessments are also like the CAPs.
    </tr>
    <tr>
        <td colspan="3" align="justify">The first number signifies what year of college that work is, so 1<sup>ﬆ</sup> Year or 2<sup>nd</sup> Year. The following two numbers state what index that piece of work is, 00 being the very first, and so on (the index ≤99). However for worksheets there could be WX## which means it's an extension worksheet. </td>
    </tr>
</table>

## How to open the solution:
Using [<img src="https://img.shields.io/badge/visual%20studio-5C2D91?style=plastic&logo=visualstudio">](https://visualstudio.microsoft.com/vs/community/ "Download Visual Studio Community") tends to be much more intuitive to use than [<img src="https://img.shields.io/badge/vscode-007ACC?style=plastic&logo=visualstudiocode">](https://code.visualstudio.com/ "Download Visual Studio Code") for C#.



However for VSCode, you require the 
[<img src="https://img.shields.io/badge/C%23%20Extension-white.svg?style=plastic&logo=data%3Aimage%2Fpng%3Bbase64%2CiVBORw0KGgoAAAANSUhEUgAAAIAAAACACAMAAAD04JH5AAAAIVBMVEWNdeRHcExyVN1iQNl7X9%2BBZeFZNNZmRdp0Vt38%2FP%2FLwPNsqB2hAAAABXRSTlP%2FAEXWmrnmltUAAAc8SURBVHjaxVuJgqMqEOwncoT%2F%2F%2BCnCNKnoHEnJJldd3ami6q%2BQIT%2Ffjzgux9ftvEzAMu6QhnruvwAwFKtVwzLHwOg5r%2BBAO%2BYfw7hCQDV%2FD6WPwGwwMVY%2FjmAZYXLcVsHeIl9BOEfAhiZ9w90gPfYLwj21y0d4DXzxfR9CPAm%2Bx691lcBLGPfO2buK4rt7ZbXAIzFR8Z9QzCpA7zhe5R9f8DYxwQEeIF93xhAGI4Bbv0SwHJP%2Bjb1k4KxK8C34jP6qwJ9wEAH%2BFJ8TL4nHzSuIMD37PfJgzDdxnIbwG3fB9%2FfeKTytl0BHpv3Cv3aSPVj6ADPii5PeyT6sfHUSNi%2BrJMAZsSXcQ%2F63A%2Fb5ZVUHeCh71PhbQgJIdj%2BKnWAp%2BzT0NfZTxRC2j%2FrJYDlxtxtxz%2FZr8a79f3DdIBb9j0w52u2QZpP%2BNW%2BJOEJcLfuXCdeXfzDchn73wgCuNX1kMxnJd5qnNpvXnBwoANYb%2BddU3wx%2FU5BGasGYLlR9sy4I96Pps%2FHogBYR7P3SuzbeY%2B6vk1BBzBYbpDcA73ae6X2SNfno%2FshTCjgjbwDknpGvz79iDWAoQJa6oHLxHNa99r0Y%2FmscwB4w3dRd3ne0a03CNEJAOPp2y1Pj3zp%2BYL%2BWBDMAOBVB4UecNenVe9UXhH%2FIGACgBb4VteTjNjTxI%2F1y5gBmXglCJR1kXVL%2B9N4HPqAZwu9g46LtLv%2FT%2Bx5%2B7%2FrpsufAwk8W21Czp%2FPJ%2BcMFvew%2FYcMPfLrtRSgmr8E4IG2m%2FsvayOD6Ld3DHB8FxoD%2FRq5PrEfTR%2Fgjo%2FNFwik166pL7fvVYPtmrg%2Bem3DYMBTAuD83QIBqfntey3%2B0DVigGDQGODc72aE%2FY1YUfWAGcQAYrPe%2BK9vlQHZc8DnoyFgiddfAFD43yVQndCLwqcRUERIHvXaNgMnAWz6VwyQtKsSQCkoGQJ%2FY%2F85cp3o5IsLbkMCwEXPcw8EHI35JB%2FyZzS27NGMN%2FqjkQm92OXJZM6ntSy873pAtX5%2BdB%2BQNf%2B0yPG0WpfnAGTKQLTygFhvABO9X9cQ%2FEwOH5Hp%2BjcOYEH1vuVb5ly2t48Y8F37CwbkYgMDYCn3eM1LgG0bAGjHBQRADXxcZGgCGCogIKgM8CEY8K3MtpZnIgw%2FJQzlMBggGhAGartxuCPqOaWv4OuSiKUAcwwk%2FIuO4tPs0nYH5f5iqV8L37cZWBzYEqBWW%2Bv4SO7fPv2a%2B%2F4xwvbSGeAYetynZLfbkTKQdAYmfECsczAD1jqbMnCkO8IAxxCOlxsAkAycWzxKt49nvP8DzoBPGEgKA8ZqQ2hOnFATv7w0H3DKYhcx0MOO0a%2BEIfo5nxQvCPvbZAAtdWjub4kno257qh%2FwbPpx4AN9oQucAd7v%2B%2FliGNDk1TAseYCtdHn1I%2F3%2B7m2zxYgxsDuBu5Bgpts9Vhuz%2FUCqFASEQwGQ2B4jkYAUv8rAdD%2BQOvU1CIIeBYkxkHUAufbZdyQICEN5axKI%2FcVMKOhNaV1oxul%2BIJAcYDEgt5dJWw6I0rbYmOoHhP3tSwgiCryyvWrM0PdVbskPV2vDFLn6IehR4Lh5nwyRM13pbyhY6sXXIXLxDwxB9wG%2BuQy6pGSxlUTuRwACC%2F%2FDuM4A3t9tdccrCIAt9q4ZwOqfHBg%2B0OeObnBkVQC00EzIYGQAYqUcG65D9wF6g0lVASrtCbfaGafczd55zdlHMKQPWJvrdJMKSd8EOBuA1n%2BEep3Y9OOAAXN30ed9n27fpSP7TKjS70plH0%2BnP67F7PGQPqDfYKn7O9U1I91nQB3v2XjUoGveh80%2FYCCiLV6xz5HUTici69bsDR9Qe160vYvsJqXZ7RACy7st%2B4W7DESbAXWEqGQ%2BawwBKBucxkIHCS%2BrjoVDMrBae%2FsJW08x2goELe6NMQIgmMfGoy4%2FLzqXEORNq0UTn1a9E0RUFxxq3bGGct%2FQ2eJHm4KA%2FZ85fbwFAGlA723Ea9eX8z9L%2FowC%2BOY1ubUQKQI9AljKw9bjJAHk9j1i%2F2g6rZQnnO9koHccl2PVDzC4RCae2PauRT52%2Bzg2jmOQH%2BFwKXEM17ZF6ptgf7O%2FmIdYHE%2F8RvAHycDh9hPTD%2FYhloMDMnWr6vFuE0VdvGVfHmSaCTzid1T%2BIQX8LJU8yuXYzRVtn8Vot%2B%2FSbx1mc9cVV11tTKGYOsxWdHCmCkram56%2BeqLQOtBoRF6Mqvkn4o%2BOdDoz7yvR90T84aHW1WlJT9acKfPrs2O9PPHwkj8b%2FM%2BO9XIIMu3MJb7gnh5s7q4QtOR3Wo9fmJ843F5dIdCSE%2BfKDim8z4%2F3i5lPF543jvdXHcKD3OPeecChQmDbHC%2BZn37IZVkd9ftx4nv%2FMZ8e%2BvEN8R886OSe9TxvPurlwnd59%2BuH3ZY1vMj%2Bs8f93HvsP33g0b1o%2FuEjn%2B4N8b976PUF8b987Ne9wP43ADgE99cPPtf0XEA495NHvyuIXz78%2Fs74H74rCNcp%2Bce1AAAAAElFTkSuQmCC">](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp "Download the C# extension"), but more likely you'll want 
[<img src="https://img.shields.io/badge/C%23%20Dev%20Kit-white.svg?style=plastic&logo=data%3Aimage%2Fpng%3Bbase64%2CiVBORw0KGgoAAAANSUhEUgAAAIAAAACACAMAAAD04JH5AAAAOVBMVEXQxvS6qu62p%2BxpR9vIvPGgi%2BhoR9pHcEzFuPGWgOJoRtpRK9RoRtqgi%2Bj%2F%2F%2F9LKMVEJbLr5vpeQb5QkdCZAAAAC3RSTlP%2BkVFSzt3hAP4eomIbDkUAAAUjSURBVHja7ZuJkpswEERlsB0Bo2D4%2F48NCHQyukZaU0ll1tlQ3mz6aboRuJDYr5uLVf32MHTdMNwEMHSP55Nt9Xw%2BuuHrAEMnxVU9uy8DuPI1CCSA4cGQegxfAhgeT4bWk4LAGnRfFif6wJrIc%2BND96MAuPknApccpT6wevO570MRAqs23xo%2FJ0QhG6ALdv8Csr3yo8BqzTej5zoIvMAHRph3IyzGi82HoRVAynxbVkNsr6wosALzl6j5lhGH%2FvYtwweWeeotyQnAZTggMqLA0t1fWHb%2BNQJXbUj6wIjmH6pCFvfltQvy7zgCi3WfJ%2BTXj6xVcG2Ar79X1AcWPvVeXJu%2FRORlCc44Nn6ejEIIoHsJnjN6Vau4iusW8EgUcID%2BIaR%2BIH%2Bce%2FIYwqmtKQKzM0PNf23RCp%2F9HD5YrWC09XlgKuADw8w%2Fop3R%2Ffkzb69rFLgatglCKI0MMV8oAMwBLT%2Fb5fjgmWDXNQrM774QBoCFuz9fyiBo370gHlEYYgBq%2BCYCi9t9T36ap%2B2FEmDjx5rAAvoiZr5Rn1AGoWOYtoEF9MUlAkreGbwsg6ACuXch2AKXwAIYbH0RNP9jhm%2BV3wSwEC4kzwEFeIggAPeHj5XqgtWEUBseGIBjgAvgmn%2B2%2FCLvd%2BFEQKtDANwGiKj5gVIEnyTC4wrgJsAAYOaHEXYKmwACCCYFGqATKIA7%2FLj0eVbOSBTCHrCAAwKbd5Ojj6Qx5AELOCCs7s%2BZw7%2BkEUUQrgcRAK3%2FKRi9H0c1NQZDEAEAk7zs4Wc3IQNAHHE%2B1Uv0sblxPRBEfgc4zOaiRyrn%2BrAqhGwAYa70pAaYSeFowroqAlEGMJHrvF4ftW4tsKOQBoB95OisX0hxGrF3wPIhDTAVnnipKKzriQCZFkxt9OezCZPqwBmFHIAm49dpWGHVDCLTgmvBVujb%2BLHNAKAQ1j2LeR3warvXXJbt7siTALEs6j372PtXq4WwCgIAsN9HLcxVEPub4nrsd0ACABlALL91LfZPQf5gAf8Yce8gkF%2BvUgCw9F2JEgDThVIA3f%2BzmPX%2FnqKy9HEAYD3%2FwLsMYBZq6Itjwp459Y4sfXxJoumA7EIhwMRPWYAzC9xkDi8eADgZCgFOB4QRlWeCGwy3%2FCCAW6UAeNBuB4hZIKafArAnG0IIGwDsqhxop2ETAO%2BCUzgRNQHIysc%2FDXCzBc41%2F44Q3n0aZk5EfPqnpuLp7osR4XLc9low%2BTck3w6haoGJ2JdPw4Y3pVSANrflNQDWjTEnfDBpAGA%2Bmk3Xj2YcrsftAWo%2BnDYCqKi%2FDwD%2Bd%2BBH9TMAxO0AcDsA%2FKB%2BDoC4HaAhAaQBfiEArQgAqXFIPbRqhwAoQPKxXasoAl598sFlmyYE5E0Ewo9umyCE9I0D4YfXDXwIysO7Tz%2B%2Br24CRGrMWMBQiRCTtxIQWcJRhxDX73MWsdREAfL1w8t46E2AEv3wQiYyQkJ%2BHDKXchEREsMf%2B%2BzFbKQoJLufsZhNL%2BcjNKGw%2B5EFjR0lCin5vnRJZxlCQv7dExa1FkSBYH7Ost5cBKCYn7WwORUFAftX8amXv7Q76YPsQ8nEV764PXl9oHc%2Fc3l%2FNAq18pkbHF604Y99sz0mKAL91CNtcnm1Nr90m493oabNu1UbnYb%2B1dR8ylav%2Fp0z8WSaT9vsNr6hlfnE7X792K77xA2PMYRiedqWz%2F7dwvyqTa9YFErNr9v2e%2FWB0P2qjc8uwpsqX7X1ux%2FHt6yRLl%2B%2F%2Bb3vb9v83qj%2BAB8KXeHqCLD5AAAAAElFTkSuQmCC">](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit "Download C# Dev Kit")
(will automatically install C# and Intellicode) and as well as [<img src="https://img.shields.io/badge/git-E44C30?style=plastic&logo=git&logoColor=white">](https://git-scm.com/downloads "Download Git") if you wish to clone this repository directly into VSCode - for Visual Studio Community you can find it as an individual component (see [Dependencies](#dependencies)).
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
