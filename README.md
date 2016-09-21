# ReSharper Macro - ReplaceFromOtherValue

## Description

This plugin will add new macro for creating [file template](https://www.jetbrains.com/help/resharper/2016.2/Creating_a_File_Template.html). 
This macro will generate new value by replacing some word from another variable. 
See screenshoot for more detail: 

![screenshot](Screenshot.png?raw=true) 

It takes 3 parameter:
1. The first parameter is the referenced variable
2. The second parameter is the word that will be replaced. We can use [Regex.Replace](https://msdn.microsoft.com/en-us/library/system.text.regularexpressions.regex.replace(v=vs.110).aspx). Wheever invalid regex specified, then it will give a value from first parameter instead.
3. The third parameter is replacement word. It also accept regex replacement, just like second parameter. We can also leave it empty for removing purpose.

## Building

To build this project, we need at least Visual Studio 2015 or C# 6.0 capable. 
By using Release configuration, it will build and and create nuget package in build folder.
To use this macro locally, go to `ReSharper` -> `Options`. Under `Environment` section, select `Extension Manager`, create new source and point to `build` folder 
or you can use [this instruction](https://www.jetbrains.com/help/resharper/sdk/Extensions/Deployment/LocalInstallation.html) as well.
