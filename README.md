# Igneaalis and Alex446377 Unity Project

  - [Requirements | Требования](#requirements--требования)
  - [Useful links | Полезные ссылки](#useful-links--полезные-ссылки)
    - [Git](#git)
    - [Android](#android)
    - [.NET](#net)
      - [C#](#c)
    - [Unity](#unity)

## Requirements | Требования

* Git

* GitHub

* GitHub Desktop

* .gitignore

* Markdown (for GitHub)

___

* .NET Framework

* .NET Framework 4.8

* .NET Framework 4.8 SDK

* .NET Framework 4.7.1 SDK

* .NET Core 3.1.5

* .NET Core 3.1.301 SDK

* .NET Standard 2.0

___

* VS Code

* VS Code extensions:
  * C#
  * C# FixFormat Fixed
  * Debugger for Unity
  * Explorer Exclude
  * GitHub
  * GitHub Pull Requests and Issues
  * Instal .VSIX
  * Unity Code Snippets
  * Unity Tools

OR

* Microsoft Visual Studio Community 2019
___

* Unity Hub:
  * Unity 2019.4.1f1 (LTS)
     * Android Build Support
     * iOS Build Support
     * Windows Build Support (IL2CPP)

* Unity assets:
  * VSCode

* Developer mode + USB enabled (Android feature)

* Unity Remote 5

* Project Settings (Android):
  * Player
      * Other Settings
         * Identification
            * Minimum API Level 19 (Android 4.4 'KitKat')
            * Target API Level 28 (Android 9.0 'Pie')
         * Configuration
            * Scripting Backend Mono (Windows and Android) and IL2CPP (iOS)
            * API Compatibility Level .NET Standard 2.0

___

* sdkmanager (configure PATH in Windows): Preferences -> External Tools -> Android -> Android SDK Tools installed with Unity (recommended) -> <kbd>Copy Path</kbd>. <kbd>Win</kbd> + <kbd>Pause Break</kbd> -> Additional System Settings -> Variables -> System variables -> Path -> <kbd>Add</kbd> -> <kbd>Ctrl</kbd> + <kbd>V</kbd>.
  * --list
     * Installed packages:
        * build-tools;28.0.3
           * 28.0.3
        * platform-tools
           * 28.0.1
        * platforms;android-28
           * 6
        * tools
           * 26.1.1

## Useful links | Полезные ссылки

### Git

* **[Git workflow | Git рабочий цикл](https://docs.github.com/en/github/using-git)**

* [Markdown](https://guides.github.com/features/mastering-markdown/)

___

### Android

* [Android API](https://habr.com/ru/company/otus/blog/466367/)

* [sdkmanager](https://developer.android.com/studio/command-line/sdkmanager)

* [sdkmanager practical using | sdkmanager практическое применение](https://stackoverflow.com/questions/37505709/how-do-i-download-the-android-sdk-without-downloading-android-studio)

#### sdkmanager get-list.bat

* Don't forget to add sdkmanager to Path and set %ANDROID_HOME% variable.

```batch
sdkmanager --list --sdk_root=%ANDROID_HOME% > C:\logfile.txt
pause
```

___

### .NET

* [.NET Core vs .NET Standard](https://gosha20777.github.io/code/2018/02/22/dotnetcore/)

#### C#

  * [Data structures | Структуры данных](https://habr.com/ru/post/339656/)
  
  * [Design Patterns in C# part 1 | Шаблоны в C# часть 1](https://www.exceptionnotfound.net/introducing-the-daily-design-pattern/)
  
  * [Design Patterns in C# part 2 | Шаблоны в C# часть 2](https://www.dofactory.com/net/design-patterns)
  
  * [Coroutines | Корутины](https://habr.com/ru/post/216185/)
  
  * [Streamline coroutines | Оптимизация корутин](https://habr.com/ru/post/442622/)

  * [Preprocessor directives | Директивы препроцессора](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/preprocessor-directives/)

___

### Unity

* **[Unity Documentation | Unity документация](https://docs.unity3d.com/Manual/index.html)**

* [Platform dependant compilation | Платформо-зависимая компиляция](https://docs.unity3d.com/Manual/PlatformDependentCompilation.html)

* [Protect Unity Apps | Защита приложений Unity](https://habr.com/ru/post/266345/)

* [Change Unity Target Framework](https://gamedev.stackexchange.com/questions/166401/use-a-different-target-framework-version-in-a-unity-c-project-other-than-4-6)

* **[Hexagonal Grid | Шестиугольное замощение](https://www.youtube.com/watch?v=bcPqdCSGCls)**

___

### Visual Studio Community 2019

* [Using Visual Studio Tools for Unity](https://docs.microsoft.com/ru-ru/visualstudio/cross-platform/using-visual-studio-tools-for-unity?view=vs-2019)
