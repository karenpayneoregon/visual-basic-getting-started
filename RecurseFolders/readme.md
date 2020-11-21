# About

Code sample which recursively iterates a folder structure.

### Requires

NuGet package [BetterFolderBrowser](https://www.nuget.org/packages/BetterFolderBrowser/) for selecting folders only thus is optional when using the code in this project in other projects.

### Extract with Git

To extract only projects needed for this code sample rather than entire repository.

- Ensure [Git](https://git-scm.com/book/en/v2/Getting-Started-Installing-Git) is installed
- Create a temp folder e.g. C:\GitExtractions
- Create a batch file
- Place below into the batch file, save
- Run the batch file
- Copy the two project folders into a Visual Studio solution (using VS2019, if earlier add the projects to the solution)
- Perform a NuGet restore packages
- Remove C:\GitExtractions\code folder

```batch
mkdir code
cd code
git init
git remote add -f origin https://github.com/karenpayneoregon/visual-basic-getting-started
git sparse-checkout init --cone
git sparse-checkout add FileHelpers
git pull origin master
:clean-up
del .gitattributes
del .gitignore
del *.md
del *.sln
```


### Visual Studio

Coded in VS2017 and will work in VS2019, not tested in earlier releases of Visual Studio.

### Notes

-  File operations are in [the following class project](https://github.com/karenpayneoregon/visual-basic-getting-started/tree/master/FileHelpers) in this repository.
-  Not coded, disabling the Traverse button, if clicked while running it will restart processing.
-  Generally cancellations are wrapped in the caller but here this is not the case, instead the cancellation is handled in [RecursiveFolders method](https://github.com/karenpayneoregon/visual-basic-getting-started/blob/master/FileHelpers/Operations.vb#L61).
-  The [property Cancelled](https://github.com/karenpayneoregon/visual-basic-getting-started/blob/master/FileHelpers/Operations.vb#L31) in Operations class must be reset on each call to RecursiveFolder which is done in this code sample.
-  Events are hooked up once in form load.

![screen](../assets/recurseFolders.png)
