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
    - [Controling Views and Windows](#controling-views-and-windows)
    - [Symbol navigation](#symbol-navigation)
    - [Tools, Options](#tools-options)
- [Solving Problem in Visual Studio](#solving-problem-in-visual-studio)
  - [Debugging](#debugging)
  - [Testing](#testing)

## Resources

- [VS office hours with Mads and Scott](https://www.youtube.com/playlist?list=PLReL099Y5nRem6UA4w849hTfd0LzBIsAk)
- [VS intro series](https://channel9.msdn.com/Series/Intro-to-Visual-Studio/?WT.mc_id=Educationalvside-c9-niner)
- [VS Documentation](https://docs.microsoft.com/dotnet/core/tutorials/with-visual-studio?tabs=csharp)
- [VS How](https://aka.ms/vshow)
- [index](http://index)
- [AzDo search](https://dev.azure.com/devdiv/DevDiv/_search?text=test&type=code&action=contents)

## Getting Started

### Learning .NET

- [C# 101 series](https://channel9.msdn.com/Series/CSharp-101/?WT.mc_id=Educationalcsharp-c9-scottha)
- [C# documentation](https://docs.microsoft.com/dotnet/csharp/)
- [David Fowlers async guidance (super advanced)](https://github.com/davidfowl/AspNetCoreDiagnosticScenarios/blob/master/AsyncGuidance.md)

### Source Control

- link to git resources
  - ~~[oh shit git!](https://ohshitgit.com/)~~
  - [official git tutorial](https://git-scm.com/docs/gittutorial)
  - [git tutorial from github](https://try.github.io/)
- use the commandline if you want (or whatever makes your comfortable!)
- AzDo (for closed source stuff) -> branch model

>`git checkout -b dev/alias/branch-name origin/master`

- github (where all the open source is) -> fork model (more about that [here](https://help.github.com/en/github/collaborating-with-issues-and-pull-requests/about-collaborative-development-models))

> `git checkout -b branch-name upstream/master`

### Installation

- Install VS Preview: http://aka.ms/vspreview
- That is the preview version, ask what your team recommends. (Dogfood version:http://aka.ms/vsdogfood)

### Developer command prompt

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

- Clone code
  - Can be used to clone a git repository if you need it
- Open project
  - Probably the most used button :) opens an existing project
- Open folder
  - Allows you to open a folder. Not as useful as open project for .NET 
- [Create project](https://docs.microsoft.com/visualstudio/ide/compiling-and-building-in-visual-studio?view=vs-2019)
  - UI to help you create a new project

### Solution Explorer

- Not a file view, shows ['projects'](https://docs.microsoft.com/visualstudio/ide/solutions-and-projects-in-visual-studio?view=vs-2019)
- Scope to this
  - "I do not need to see all these other things right now, I need to focus" 
- Search and filter (ctrl+;)
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

- Multi-instance
  - You can open as many visual studios as you want!
- Find: ([ctrl+F](https://docs.microsoft.com/visualstudio/ide/finding-and-replacing-text?view=vs-2019))
  - When all else fails just search all the code files for the string 'goo'
- Intellisense: ([ctrl+space](https://docs.microsoft.com/visualstudio/ide/visual-csharp-intellisense?view=vs-2019))
  - Shows what is valid in certain contexts. also suggests names, offers snippets and is an all-around swell guy
- Copy/cut line ([ctrl+c/ctrl+v](https://docs.microsoft.com/visualstudio/ide/reference/options-text-editor-all-languages?view=vs-2019#settings))
  - Remove blank lines or delete large section of text
  - Move line (alt+up/alt+down)
    - Use with copy/paste line to save some typing
  - [Line numbers](https://docs.microsoft.com/visualstudio/ide/reference/how-to-display-line-numbers-in-the-editor?view=vs-2019)
  - Go to line ([ctrl+g](https://docs.microsoft.com/visualstudio/ide/reference/go-to-line?view=vs-2019))
    - "Build log says the exception occurred on line xxx in file yyy"
  - Add/remove bookmark ([ctrl+k,ctrl+k](https://docs.microsoft.com/visualstudio/ide/setting-bookmarks-in-code?view=vs-2019))
- Ctrl+Q
  - Search for anything if you know the name
- Rename ([ctrl+R,ctrl+R](https://docs.microsoft.com/visualstudio/ide/reference/rename?view=vs-2019))
  - Safely rename a class. method, anything (can even rename the file for you!)
- Multi-cursor ([ctrl+d](https://docs.microsoft.com/visualstudio/ide/finding-and-replacing-text?view=vs-2019#multi-caret-selection))
  - For complex replacements and edits (replace BankAccount with BankBuilding for example)
- Code fixes ([ctrl+.](https://docs.microsoft.com/visualstudio/ide/quick-actions?view=vs-2019))
  - Should be able to fixup errors and generally save time
- Build ([Ctrl+Shift+B](https://docs.microsoft.com/visualstudio/ide/compiling-and-building-in-visual-studio?view=vs-2019))
  - Compile all your changes and write them to disk

#### Important General Tool Windows

- Error List ([ctrl+shift+M](https://docs.microsoft.com/visualstudio/ide/reference/error-list-window?view=vs-2019))
  - Filtering categories
    - "Only show me errors please"
  - Checkboxes for error codes
    - "I want to fix this specific error everywhere first"
  - Searching
    - "How many errors are about variable 'goo'?"
- Output Window ([ctrl+shift+U](https://docs.microsoft.com/visualstudio/ide/reference/output-window?view=vs-2019))
  - For when real problems happen
    - "I am going to copy and paste this into and email and ask for help"
- Bookmarks window (no short cut by default, use ctrl+Q)
  - "Let me keep track of interesting places in the code"
- Task list ([ctrl+\,T](https://docs.microsoft.com/visualstudio/ide/using-the-task-list?view=vs-2019))
  - "Lets make sure I don't forget to do this before I submit a pull request"

#### Controlling Views and Windows

- [Split window](https://docs.microsoft.com/visualstudio/ide/how-to-manage-editor-windows?view=vs-2019)
  - For when the method is just too long and you need to see two parts at once
- Duplicate window (ctrl+K,O)
  - [Now there are two of them](https://pics.me.me/this-is-getting-out-hand-now-there-are-two-of-16048246.png)
- Pin tab
  - This tab is better and more important than the others
- [Window layout](https://docs.microsoft.com/visualstudio/ide/customizing-window-layouts-in-visual-studio?view=vs-2019)
  - Save and load custom window layouts
- Vertical tabs
  - You get more space for code
  
#### Symbol navigation

- Go to: ([ctrl+T](https://docs.microsoft.com/visualstudio/ide/go-to?view=vs-2019))
  - Navigates you to anything you type (uses fuzzy matching)
  - "There should be a test named 'Parser Test' somewhere"
- Go to definition / Peek: ([F12/alt+F12](https://docs.microsoft.com/visualstudio/ide/go-to-and-peek-definition?view=vs-2019))
  - "Where was this first created / declared?"
- Go to implementation: (ctrl+F12)
  - "Take me to the place where the functionality lives"
- Go to base: (alt+home)
  - "Take me up a level"
- find-all-references: ([Shift+F12](https://docs.microsoft.com/visualstudio/ide/finding-references?view=vs-2019))
  - "Show me everyone that reads or writes to this"

#### Tools, Options

- Settings de-confuse-o-tron
  - Intellisense for un-imported types
    - Intellisense can complete even more things
  - De-compiler
    - I want to see how this is implemented

## Solving Problem in Visual Studio

### Debugging

- symbols
- default setting you should use
- move execution pointer
- re-attach
- breakpoints
  - breakpoint filters
  - window
  - exception settings
  - "Just My Code"
- watch window
  - search
  - pin
  - expression evaluator
- pin tool tips in editor
- edit-and-continue

### Testing

- Run/debug tests from editor
- run from codelens
- test explorer
  - run options
  - filter tests
  - grouping
- test output
