# VS and You

This is a resource for getting started with Visual Studio in devdiv!

This repo contains a trimmed down .NET console app from our [csharp tutorial docs](https://docs.microsoft.com/dotnet/csharp/tutorials/intro-to-csharp/introduction-to-classes). We'll use it to demonstrate the got-to-know features of Visual Studio.

## Table of Contents

- [Resources](#resources)
- [Getting Started](#getting-started)
  - [Learning .NET](#learning-net)
  - [Source Control](#source-control)
  - [Installation](#installation)
  - [Developer command prompt](#developer-command-prompt)
- [Using Visual Studio](#using-visual-studio)
  - [New Project Dialog](#new-project-dialog)
  - [Solution Explorer](#solution-explorer)
  - [Code Editor](#code-editor)
    - [Basics](#basics)
    - [Important General Tool Windows](#important-general-tool-windows)
    - [Controlling Views and Windows](#controlling-views-and-windows)
    - [Symbol Navigation](#symbol-navigation)
    - [Tools, Options](#tools-options)
- [Solving Problems in Visual Studio](#solving-problems-in-visual-studio)
  - [Debugging](#debugging)
    - [Setup](#setup)
    - [Basic](#basic)
      - [Watch Window](#watch-window-ctrlaltwhttpsdocsmicrosoftcomvisualstudiodebuggerwatch-and-quickwatch-windowsviewvs-2019)
      - [Call Stack Window](#call-stack-window-ctrlaltchttpsdocsmicrosoftcomvisualstudiodebuggerhow-to-use-the-call-stack-windowviewvs-2019)
      - [Breakpoints Window](#breakpoints-window-ctrlaltbhttpsdocsmicrosoftcomvisualstudiodebuggerusing-breakpointsviewvs-2019bkmk_specify_advanced_properties_of_a_breakpoint_)
    - [Advanced Debugging](#advanced-debugging)
      - [Conditional Breakpoint](#conditional-breakpointhttpsdocsmicrosoftcomvisualstudiodebuggerusing-breakpointsviewvs-2019breakpoint-conditions)
      - [Exception Settings](#exception-settings-ctrlaltehttpsdocsmicrosoftcomvisualstudiodebuggermanaging-exceptions-with-the-debuggerviewvs-2019)
      - ["Just My Code"](#just-my-code)
      - [Pin tool tips in editor](#pin-tool-tips-in-editorhttpsdocsmicrosoftcomvisualstudiodebuggerdebugger-tips-and-tricksviewvs-2019pin-data-tips)
  - [Testing](#testing)
    - [Run tests from editor (CTRL+R,T)](#run-tests-from-editor-ctrlrt)
    - [Debug tests from editor (CTRL+R,CTRL+T)](#debug-tests-from-editor-ctrlrctrlt)
    - [Run from codelens](#run-from-codelens)
    - [Test Explorer](#test-explorer-ctrlethttpsdocsmicrosoftcomvisualstudiotestrun-unit-tests-with-test-explorerviewvs-2019run-tests-in-test-explorer)
    - [Test output](#test-output)

## Resources

- [VS office hours with Mads and Scott](https://www.youtube.com/playlist?list=PLReL099Y5nRem6UA4w849hTfd0LzBIsAk)
- [VS intro series](https://channel9.msdn.com/Series/Intro-to-Visual-Studio/?WT.mc_id=Educationalvside-c9-niner)
- [VS Documentation](https://docs.microsoft.com/dotnet/core/tutorials/with-visual-studio?tabs=csharp)
- [How to debug](https://docs.microsoft.com/visualstudio/debugger/debugging-absolute-beginners?view=vs-2019)
- [VS How](https://aka.ms/vshow)
- [index](http://index)
- [AzDo search](https://dev.azure.com/devdiv/DevDiv/_search?text=test&type=code&action=contents)

## Getting Started

### Learning .NET

- [C# 101 series](https://channel9.msdn.com/Series/CSharp-101/?WT.mc_id=Educationalcsharp-c9-scottha)
- [C# documentation](https://docs.microsoft.com/dotnet/csharp/)

### Source Control

- git resources
  - ~~[oh shit git!](https://ohshitgit.com/)~~
  - [official git tutorial](https://git-scm.com/docs/gittutorial)
  - [git tutorial from github](https://try.github.io/)
- use the commandline if you want (or whatever makes your comfortable!)
- AzDo (for closed source stuff) -> branch model

>`git checkout -b dev/alias/branch-name origin/master`

- github (where all the open source is) -> fork model (more about that [here](https://help.github.com/en/github/collaborating-with-issues-and-pull-requests/about-collaborative-development-models))

> `git checkout -b branch-name upstream/master`

### Installation

![image](https://user-images.githubusercontent.com/9797472/80104807-8be02800-852c-11ea-9305-895a8fe00d8c.png)

- Install VS Preview: http://aka.ms/vspreview
- That is the preview version, ask what your team recommends. (Dogfood version:http://aka.ms/vsdogfood)

### Developer command prompt

![image](https://user-images.githubusercontent.com/9797472/80104650-51768b00-852c-11ea-9ab2-3bf34c786e1a.png)

- Where it is
  - Searchable from the start menu
  - Script is located under `C:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\Common7\Tools\VsDevCmd.bat`
- What is does
  - Puts a lot of tools (`msbuid.exe` most importantly) on your path.
  - Tells build scripts which visual studio you want to use to build
- Why you need it
  - Ensures that all the tools can be found
  - Allows you to have multiple versions of Visual Studio installed at once

## Using Visual Studio

### New Project Dialog

![image](https://user-images.githubusercontent.com/9797472/80105337-5425b000-852d-11ea-8705-0105cbaf43eb.png)

- Clone code
  - Can be used to clone a git repository if you need it
- Open project
  - Probably the most used button :) opens an existing project
- Open folder
  - Allows you to open a folder. Not as useful as open project for .NET
- [Create project](https://docs.microsoft.com/visualstudio/ide/compiling-and-building-in-visual-studio?view=vs-2019)
  - UI to help you create a new project

### Solution Explorer

![image](https://user-images.githubusercontent.com/9797472/80105468-7f100400-852d-11ea-83d0-e32948695d0a.png)

- Not a file view, shows ['projects'](https://docs.microsoft.com/visualstudio/ide/solutions-and-projects-in-visual-studio?view=vs-2019)
- Scope to this
  - "I do not need to see all these other things right now, I need to focus"
- Search and filter (CTRL+;)
  - "I know the file I am looking for is in this view"
- Right click menu de-confuse-o-tron
  - Build / Rebuild / Clean
    - "Make sure I am in a sane state"
  - Run Tests
    - "Run all the tests in this project"
  - Set as startup project
    - "This is the thing I want to launch in the debugger"

### Code Editor

#### Basics

![image](https://user-images.githubusercontent.com/9797472/80105794-e5952200-852d-11ea-805a-581dfad72862.png)

- Multi-instance
  - You can open as many visual studios as you want!
- Find: ([CTRL+F](https://docs.microsoft.com/visualstudio/ide/finding-and-replacing-text?view=vs-2019))
  - When all else fails just search all the code files for the string 'goo'
- Intellisense: ([CTRL+space](https://docs.microsoft.com/visualstudio/ide/visual-csharp-intellisense?view=vs-2019))
  - Shows what is valid in certain contexts. also suggests names, offers snippets and is an all-around swell guy
- Copy/cut line ([CTRL+c/CTRL+v](https://docs.microsoft.com/visualstudio/ide/reference/options-text-editor-all-languages?view=vs-2019#settings))
  - Remove blank lines or delete large section of text
  - Move line (ALT+up/ALT+down)
    - Use with copy/paste line to save some typing
  - [Line numbers](https://docs.microsoft.com/visualstudio/ide/reference/how-to-display-line-numbers-in-the-editor?view=vs-2019)
  - Go to line ([CTRL+g](https://docs.microsoft.com/visualstudio/ide/reference/go-to-line?view=vs-2019))
    - "Build log says the exception occurred on line xxx in file yyy"
  - Add/remove bookmark ([CTRL+k,CTRL+k](https://docs.microsoft.com/visualstudio/ide/setting-bookmarks-in-code?view=vs-2019))
- CTRL+Q
  - Search for anything if you know the name
- Rename ([CTRL+R,CTRL+R](https://docs.microsoft.com/visualstudio/ide/reference/rename?view=vs-2019))
  - Safely rename a class. method, anything (can even rename the file for you!)
- Multi-cursor ([CTRL+d](https://docs.microsoft.com/visualstudio/ide/finding-and-replacing-text?view=vs-2019#multi-caret-selection))
  - For complex replacements and edits (replace BankAccount with BankBuilding for example)
- Code fixes ([CTRL+.](https://docs.microsoft.com/visualstudio/ide/quick-actions?view=vs-2019))
  - Should be able to fixup errors and generally save time
- Build ([CTRL+Shift+B](https://docs.microsoft.com/visualstudio/ide/compiling-and-building-in-visual-studio?view=vs-2019))
  - Compile all your changes and write them to disk

#### Important General Tool Windows

![image](https://user-images.githubusercontent.com/9797472/80105712-cbf3da80-852d-11ea-95c3-5ff4ceef0418.png)

- Error List ([CTRL+shift+M](https://docs.microsoft.com/visualstudio/ide/reference/error-list-window?view=vs-2019))
  - Filtering categories
    - "Only show me errors please"
  - Checkboxes for error codes
    - "I want to fix this specific error everywhere first"
  - Searching
    - "How many errors are about variable 'goo'?"
- Output Window ([CTRL+shift+U](https://docs.microsoft.com/visualstudio/ide/reference/output-window?view=vs-2019))
  - For when real problems happen
    - "I am going to copy and paste this into and email and ask for help"
- Bookmarks window (no short cut by default, use CTRL+Q)
  - "Let me keep track of interesting places in the code"
- Task list ([CTRL+\,T](https://docs.microsoft.com/visualstudio/ide/using-the-task-list?view=vs-2019))
  - "Lets make sure I don't forget to do this before I submit a pull request"

#### Controlling Views and Windows

![image](https://user-images.githubusercontent.com/9797472/80105957-14ab9380-852e-11ea-94e9-955e328c0455.png)

- [Split window](https://docs.microsoft.com/visualstudio/ide/how-to-manage-editor-windows?view=vs-2019)
  - For when the method is just too long and you need to see two parts at once
- Duplicate window (CTRL+K,O)
  - [Now there are two of them](https://pics.me.me/this-is-getting-out-hand-now-there-are-two-of-16048246.png)
- Pin tab
  - This tab is better and more important than the others
- [Window layout](https://docs.microsoft.com/visualstudio/ide/customizing-window-layouts-in-visual-studio?view=vs-2019)
  - Save and load custom window layouts
- Vertical tabs
  - You get more space for code
  
#### Symbol Navigation

![image](https://user-images.githubusercontent.com/9797472/80106014-2856fa00-852e-11ea-9c6b-43b57e696732.png)

- Go to: ([CTRL+T](https://docs.microsoft.com/visualstudio/ide/go-to?view=vs-2019))
  - Navigates you to anything you type (uses fuzzy matching)
  - "There should be a test named 'Parser Test' somewhere"
- Go to definition / Peek: ([F12/ALT+F12](https://docs.microsoft.com/visualstudio/ide/go-to-and-peek-definition?view=vs-2019))
  - "Where was this first created / declared?"
- Go to implementation: (CTRL+F12)
  - "Take me to the place where the functionality lives"
- Go to base: (ALT+HOME)
  - "Take me up a level"
- Find-all-references: ([Shift+F12](https://docs.microsoft.com/visualstudio/ide/finding-references?view=vs-2019))
  - "Show me everyone that reads or writes to this"

#### Tools, Options

![image](https://user-images.githubusercontent.com/9797472/80106352-9ac7da00-852e-11ea-9e42-343c8db9781e.png)

- Settings de-confuse-o-tron (CTRL+,)
  - Full Solution Analysis
    - Always analyze everything vs. just the current document
  - Intellisense for un-imported types
    - Intellisense can complete even more things
  - De-compiler
    - I want to see how this is implemented

## Solving Problems in Visual Studio

### Debugging

#### Setup

![image](https://user-images.githubusercontent.com/9797472/80106590-e9757400-852e-11ea-9cb8-d4e71870ec06.png)

- Symbols
  - you need 'em
  - with the microsoft symbol server (http://symweb) you should be able to debug into anything!
- Default setting you should use
  - Enable "Just My Code"
    - makes debugging faster
    - turn this off if you want to debug things that are not in your solution or project
  - Enable source server support
    - Allows you to use the microsoft symbol servers
  - Enable Source Link support
    - Allows you to get symbols for open source projects
  - Suppress JIT optimization
    - Due to the way VS is architected some breakpoints will not be hit unless this in on

#### Basic

- Add/Remove Breakpoint ([F9](https://docs.microsoft.com/visualstudio/debugger/using-breakpoints?view=vs-2019))
- Debug ([F5](https://docs.microsoft.com/visualstudio/get-started/csharp/tutorial-debugger?toc=%2Fvisualstudio%2Fdebugger%2Ftoc.json&view=vs-2019#set-a-breakpoint-and-start-the-debugger))
  - Big green 'play' button
  - Launches whatever is set as the 'Startup Project'
- Step Over ([F10](https://docs.microsoft.com/visualstudio/debugger/navigating-through-code-with-the-debugger?view=vs-2019#step-through-code))
  - "Go to the next line"
- Step Into ([F11](https://docs.microsoft.com/visualstudio/debugger/navigating-through-code-with-the-debugger?view=vs-2019#BKMK_Step_over_Step_out))
  - like go-to-implementation earlier
  - "Let me see what is happening inside this method"
- Move execution pointer
  - Just click and drag and its like it never happened!
  - Great if you accidentally stepped over something you meant step into
- Run To Cursor ([CTRL+F10](https://docs.microsoft.com/visualstudio/debugger/navigating-through-code-with-the-debugger?view=vs-2019#run-to-a-cursor-location))
  - No need to set a breakpoint!
  - "Ok now I want to keep running the program past this loop until I get _here_"
- Restart ([CTRL+shift+F5](https://docs.microsoft.com/visualstudio/debugger/debugger-feature-tour?view=vs-2019#restart-your-app-quickly))
  - "I want to quickly restart this debug session"
  - Faster than stopping debugging and restarting

##### Watch Window ([CTRL+ALT+W](https://docs.microsoft.com/visualstudio/debugger/watch-and-quickwatch-windows?view=vs-2019))

![image](https://user-images.githubusercontent.com/9797472/80110555-a8339300-8533-11ea-8eb3-b9637e9b0f50.png)

- Expression evaluator
  - Type in anything and the debugger will evaluate it for you!
  - You are able to watch the values change as you step through your program
- Search
  - Search by name _or_ value!
- Pin
  - Make it easier to keep track of deep inner variables

##### Call Stack Window ([CTRL+ALT+C](https://docs.microsoft.com/visualstudio/debugger/how-to-use-the-call-stack-window?view=vs-2019))

![image](https://user-images.githubusercontent.com/9797472/80112441-f8abf000-8535-11ea-8ac5-afe9383abce4.png)

- View a list of methods and the order they called each other in
- Jump to different methods

##### Breakpoints Window ([CTRL+ALT+B](https://docs.microsoft.com/visualstudio/debugger/using-breakpoints?view=vs-2019#BKMK_Specify_advanced_properties_of_a_breakpoint_))

![image](https://user-images.githubusercontent.com/9797472/80110351-702c5000-8533-11ea-8840-709cf7e2de42.png)

- See all your breakpoints in one place
- Able to toggle them to "inactive" without deleting them

#### Advanced Debugging

##### [Conditional Breakpoint](https://docs.microsoft.com/visualstudio/debugger/using-breakpoints?view=vs-2019#breakpoint-conditions)

![image](https://user-images.githubusercontent.com/9797472/80109025-df08a980-8531-11ea-9148-b54d1e112305.png)

- Only stop your program when a condition is met
- "I want to know when in this loop the value is set to `null`"

##### Exception Settings ([CTRL+ALT+E](https://docs.microsoft.com/visualstudio/debugger/managing-exceptions-with-the-debugger?view=vs-2019))

![image](https://user-images.githubusercontent.com/9797472/80111495-cea5fe00-8534-11ea-832a-06f2c026cd49.png)

- Even with "Just My Code" turned on some debugging sessions can take a while to get started
- Turning off breaking on exceptions until your breakpoint is hit can save time

##### "Just My Code"

- By default only loads code that was built by you
- Necessary to turn this off if you want to step into code from other teams

##### [Pin tool tips in editor](https://docs.microsoft.com/visualstudio/debugger/debugger-tips-and-tricks?view=vs-2019#pin-data-tips)

![image](https://user-images.githubusercontent.com/9797472/80111221-7a9b1980-8534-11ea-942c-05178df3f6e8.png)

- Allows you to inspect values quickly in the editor
- Drag them around to track multiple values at once

- Modules Window ([CTRL+ALT+U](https://docs.microsoft.com/visualstudio/debugger/how-to-use-the-modules-window?view=vs-2019))

### Testing

#### Run tests from editor (CTRL+R,T)

![image](https://user-images.githubusercontent.com/9797472/80119050-0c5b5480-853e-11ea-97b2-7025371139e9.png)

- Place your cursor on any class or method to run tests

#### Debug tests from editor (CTRL+R,CTRL+T)
  
- Place your cursor on any class or method to run tests

#### Run from codelens

![image](https://user-images.githubusercontent.com/9797472/80118901-dddd7980-853d-11ea-83ee-bcaa55932074.png)

#### Test Explorer ([CTRL+E,T](https://docs.microsoft.com/visualstudio/test/run-unit-tests-with-test-explorer?view=vs-2019#run-tests-in-test-explorer))
  
- Run options
  - You can choose to run all tests or just a few you select
  - Filter tests
    - If you have a lot of tests you can just show tests that have failed
  - Grouping

  ![image](https://user-images.githubusercontent.com/9797472/80118259-01ec8b00-853d-11ea-8edf-93983d37973c.png)

#### Test output

![image](https://user-images.githubusercontent.com/9797472/80119388-7ecc3480-853e-11ea-8d3a-d208a498bd95.png)

- If tests aren't running for some reason you can go to the output window ([CTRL+shift+U](https://docs.microsoft.com/visualstudio/ide/reference/output-window?view=vs-2019)) and look for the `Tests` category in the drop-down.
