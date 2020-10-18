# About Format package listing

Execute in Package manager console: **Get-Package | ft -AutoSize** then run this project to get a formatted GitHub markdown table suitable for a readme.md file.

Currently the base code has been written and test leaving remaining work to create the table into a StringBuilder to present.

> This version although coded in C# works only with VB.NET projects. This behavior can be changed in Operations.BuilderPackageTable()