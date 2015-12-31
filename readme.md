Language:  C# and C++

Description
This program uses the XBox Joystick to control machinery.  You can find the youtube video
of the program in action at;

https://www.youtube.com/watch?v=G6K_yqSxG3M

Hardware:
Motion Controllers:  JR Kerr
JoyStick:            Microsoft
XYZ Table:           Generic.
Mechanical Pulleys:  Stock Drive

DLL used:
The DLLs used can also be another project.  A lot of the programming effort was used to
create the DLLs.  To simplify the project the DLL are provided without the code.

nmclib.dll - This is a native C++ DLL that communicates betweem the Computer and the Motion Controllers.
PathLib.dll - This is also a native C++ DLL that plans the path motion for the Motion Controllers.  
It is not used for this project.
stageLib.dll - This is a native C++ DLL that moves the XYZ stage.
stageCLR.dll - This is a .NET DLL that wraps the staglib.dll.

The Joystick software is open source.
Author - Jean Phillipe Steimetz





