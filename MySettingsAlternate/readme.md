# About

Code sample for alternate to using My.Settings.

- Shows how to read and change items in app.config at runtime
- Option to use My.Setting which has been customized in this project.
- Shows working with a .json file for configuration also.
- Write to an error log file.
- Any unhandled exceptions are handled in ApplicationsEvents.vb only at run time, during debuggings an unhandled exception will not be handled.

## TechNet article

[My.Settings alternate for storing app settings (VB.NET)](https://social.technet.microsoft.com/wiki/contents/articles/54134.my-settings-alternate-for-storing-app-settings-vb-net.aspx)

# Downloading projects

Since there are two project required out of many in this Visual Studio solution and only want the two projects.

1. Git must be installed first.
2. Using Windows Explorer create a new folder for downloading the two projects.
3. Create a batch file.
4. Add the contents below into the batch file and save it.
5. Run the batch file.
6. Once done there will be two project folders.
7. Copy the two folders into your solution.

```bat
mkdir code
cd code
git init
git remote add -f origin https://github.com/karenpayneoregon/visual-basic-getting-started
git sparse-checkout init --cone 
git sparse-checkout add MySettingsAlternate
git sparse-checkout add WinFormHelpers
git pull origin master
```





## Requires

- The following [database script](https://gist.github.com/karenpayneoregon/9bdf1a7d5310ac1d562b2326d79d6038) for data operations.

 
![screenshot](../assets/settingWithJson.png)

(old screenshot but still works)

![screen1](../assets/MyAppAlternateSettings.png)

![screen2](../assets/AppSettings.png)