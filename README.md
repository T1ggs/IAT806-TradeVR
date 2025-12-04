This is a unity project, meaning a majority of programming is done in C#.

I am confident that I have fulfilled the Course Project Requirements, in a reasonable manner for the selected format. For your convenience, if you don't feel like installing the Unity Editor, you can simply look only at 'SCRIPTS' folder within 'Assets'.

1) Inheritance is demonstrated in ScubaPart.cs (an abstract class), with 3 child classes, which inherit its partName string field. Due to how the unity editor functions, all child classes also inherit but not necessarily express the XRGrabInteractable and XRSocketInteractable trait.

2) Abstraction is demonstrated within SceneTransition.cs and ScubaPart.cs, where the FadeOut() function is exported to an external script, or when usePart() is undefined until utilised in any of the child .cs classes, which in this case output a Debug.Log.

3) Overloading is demonstrated in LoadProgress.cs when the output of Load() can take the form of a sentence containing int values (currentStep, currentLevel) or a string ("No save file!", "No save file!"), that print either way on the UIPanel without issue.

4) Overriding is demonstrated within the child classes of ScubaPart.cs, which replace the original usePart() function to print their own unique Debug.Log entries.

5) Polymorphism is achieved when the child classes of ScubaPart.cs are assigned to different gameObjects whilst under the parent class ": ScubaPart"

6) File Processing is achieved by implementing the File.WriteAllText or File.ReadAllText, which creates/overwrites the .json file, containing a series of stored values that were serialised and made compatible thus. Information can then be extracted from this .json file for other interactions

7) Exception Catching was implemented but not necessarily demonstrated in LoadProgress.cs with 'try' and 'catch', which create a failstate to fallback to.

8) Java and Processing libraries were not accessed within the unity project.
