# SDL2Droid-CS
### An opera in three parts: SDL2 + SDL2-CS + Xamarin.Android
##### zlib-licensed
##### clone recursively
----

##### TL;DR:
* Run `/SDL2Droid-CS-Native/buildnative.sh`
* Compile `/SDL2Droid-CS-Java/` into `/SDL2Droid-CS-JBindings/Jars/SDL2Droid-CS-Java.jar`
* Change `/SDL2Droid-CS/Bootstrap.cs`, `/SDL2Droid-CS/Resources/` and `/SDL2Droid-CS/MainActivity.cs`
* Compile SDL2Droid-CS using Xamarin.Android (f.e. via Xamarin for Visual Studio).

##### /SDL2Droid-CS-Native/

*What:* SDL2 `Android.mk` makefile and "wrapper" code (SDL_main returning to C# managed land)

*Why:* Xamarin for Visual Studio has got some problems with native libraries.

*Compilation:* Run `buildnative.sh` (cygwin-compatible) from inside SDL2Droid-CS-Native. That's it.

##### /SDL2Droid-CS-Java/

*What:* Original SDL2 SDLActivity.java interoperating with native SDL2 code

*Why:* SDL2's native side is prepared for the JNI bindings in SDLActivity.java - let's just reuse them!

*Compilation:* In your favourite Java IDE, produce a compiled .jar artifact and place it into `/SDL2Droid-CS-JBindings/Jars/`

##### /SDL2Droid-CS/ and /SDL2Droid-CS-JBindings/

*What:* The Mono side of things: Main C# code and SDLActivity bindings.

*Why:* Why not?

*Compilation:*
* Load the solution in Visual Studio with the "Xamarin for Visual Studio" extension installed.
* Modify `/SDL2Droid-CS/Bootstrap.cs` for your main code, `/SDL2Droid-CS/Resources/` for any strings / icons / ... and `/SDL2Droid-CS/MainActivity.cs` for the launch config (f.e. orientation).
* Compile as you would any other Xamarin.Android project.
