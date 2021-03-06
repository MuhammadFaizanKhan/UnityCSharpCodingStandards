 بسم الله الرحمن الرحيم

# UnityCSharpCodingStandards (in progress)
Coding Standards for C# and Unity3d Projects

# Table of Contents

## Coding Standards
1. ### [Naming](https://github.com/MuhammadFaizanKhan/UnityCSharpCodingStandards#naming-1)
2. ### [Comments](https://github.com/MuhammadFaizanKhan/UnityCSharpCodingStandards/blob/master/README.md#comments)
3. ### [Coding Style](https://github.com/MuhammadFaizanKhan/UnityCSharpCodingStandards/blob/master/README.md#coding-style-1)
4. ### [Coding Sequence](https://github.com/MuhammadFaizanKhan/UnityCSharpCodingStandards/blob/master/README.md#coding-sequence-1)
5. ### [Script Basic Template](https://github.com/MuhammadFaizanKhan/UnityCSharpCodingStandards#basic-template)
6. ### [Refrences](https://github.com/MuhammadFaizanKhan/UnityCSharpCodingStandards/blob/master/README.md#references)


 

**Unity/C# Coding Standards and Naming Convention**
**What is:** The document will provide you about the general guideline of coding and unity project organization.
**Why:** We are want to make our code based consistent and easily maintainable.  
There are two part of the document, the one is dealing with coding (Currently in Progress) the other one is dealing with project organization (will stared in future- InnShaALLAH).

# Coding Standards
## Naming:
1.	Never use Spaces in names.
2.	Use camelCase for variable and method parameters
	```csharp
	public GameObject activeCam;//right
	public GameObject ActiveCam;//wrong
	```
3.	Use PascalCase for methods, namespace, class, struct, properties, Enum  name.
	```csharp
	//Right
	public class CamController : MonoBehaviour  
	{  
	   //...  
	} 
	//wrong
	public class Cam_Controller : MonoBehaviour
	{  
	   //...
	}
	```

4.	Use PascalCase for custom file- and folder names, like this: UtilityClasses, ProjectIcons. Do not use spaces, underscores, or hyphens, with one exception (see Naming Different Aspects of the Same Thing).
5.	Use namespace for Project specific classes.
6.	Write descrtipive, pronounceable and easily remembered names. Like '''MiniMapUIController''' instead '''CtrlUIMM'''
6.	User abbreviation for unity UI Controls referencing in code. Like use BtnVersionSwitch not ButtonVersionSwitch. Here are some common abbreviations

|Abbreviations	|Standard UI Controls|
|---------------|---------------|
|btn	|Button|
|tgl	|Toggle|
|ddl	|DropDownList|
|img	|Image|
|lbl	|Label|
|pnl	|Panel|
|	|InputField|
|tbl	|Table|
	
|Abbreviations	|Programming Constructs|
|---------------|---------------|
|cls		|Class		|
|Dlg		|Delegate|
|EventHanlder	|EventHanlder|
|I		|Interface|

|Abbreviations	|GameObjects or MonoBehaviour Construcuts|
|---------------|---------------|
|Cam	|Camera|
|PP	|PostProcess|
|go	|GameObject|
|gos	|GameObjects|
|Pos	|Position|
|Rot	|Rotation|
|Euler	|Euler|
|Lgh	|Light|
	

7.	Keep the most common descriptor on the left: like.
	```csharp
	public Vector3 posX;//right
	public Vector3 xPos;//wrong
	```

8.	Some names form a sequence. Use numbers in these names, for example, PathNode0, PathNode1. Always start with 0, not 1.
9.	Write descriptive name like BtnPressed() instead Pressed().
10.	Prefix temporary objects with a double underscore and add Backup string after it __Player_Backup. Like __MainScene_Backup or Gameobject Backup __CameraController_Backup or a method backup __ActiveCamera_Backup.
11.	For inspector, Use Header[] for a collection of variable or a variable required more explanation.
12.	Events are associated with actions. Therefore, events are name with verbs: TiggerOccured, ButtonClicked, SceneLoaded etc
13.	If a method run in response of an event use EventHandler as suffix. ClickEventHandler, TriggerEventHandler

## Comments:
1.	Must add summary of the class the show three things: Author, Purpose, Decencies, Create Date
	```csharp
	/// <summary>
	/// Author: Ali
	/// Create Date: 2021-02-02
	/// Purpose: Control multiple camera and its switching
	/// Dependencies (if any): CameraScript, CameraUI_Link, ScriptReference
	/// </summary>
	public class CameraController : MonoBehaviour
	```
2. Always comment on top not at the end of the line.
	```csharp
	//currently active camera position
	public Vector3 camActivePos;//right
	
	public Vector3 camActivePos; //currently active camera position. //This is wrong
	```
	
3. It is better to add comments for each variable but must add comment on those varaiable that required some extra explanation. 

## Coding Sequence:
1.	Declare member variable at the top of the class and if the member is static then, place it on top most.
2.	User specific #Regions for placing the code. The sequence will be Vars Region, UnityEvents Region, Custom Methods, and Custom EventHandlers. See the TemplateScript in the project.

## Coding Style:
1.	Must mention access modified even if the variable is private.
2.	Don use public variable if they are not required to access from other classes. User Serialized filed.
3.	Use louse coupling approaches in coding.

## Script Basic Template
Please check script samples of the project.
```csharp

using UnityEngine;

namespace CodingStandards
{
    /// <summary>
    /// Author: Muhammad Faizan Khan
    /// Create Date: 23-02-2021
    /// Purpose: To demonstrate basic strucutre of a script for MonoBehaviour
    /// </summary>
    public class ScriptTemplate : MonoBehaviour
    {

        // Here you can define your all variables and properties or static declarations
        #region Vars

        [SerializeField] //Make SerializeField if you want to show the variable only on the inspector
        private Camera camActive;


        #endregion

        //All Unity Related Events will be written in this Region. If Your script is not using any unity events then remove it (specially Update Event)
        #region UnityEvents
        void Start()
        {

        }

        void Update()
        {

        }

        #endregion UnityEvents

        ///These are the methods that you will called 
        #region CustomMethods
        void MovementOnKeys()
        {

        }
        #endregion CustomMethods

        //Method that will be used as events
        #region CustomEventsMethod
        ///Login button click will fire this event
        public void BtnLoginClicked()
        {

        }

        #endregion CustomEventsMethod

    }
}
```

# UI:
1. Disable the canvas if you are not using it.
2. Disable the UI element if it outside of the screen.

# References:
1.	https://www.c-sharpcorner.com/UploadFile/8a67c0/C-Sharp-coding-standards-and-naming-conventions/
2.	https://forum.unity.com/threads/unity-terminology-acronyms-translations.132458/
3.	http://devfun-lab.com/1645
4.	https://www.gamasutra.com/blogs/HermanTulleken/20160812/279100/50_Tips_and_Best_Practices_for_Unity_2016_Edition.php
	
