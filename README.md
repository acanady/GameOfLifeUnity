# GameOfLifeUnity

As a way of practicing my Unity skills I decided to implement Conways Game of Life in Unity 3D.

### The Board
The game board is made up of many instantiated cube primitives, these cubes resemble one cell of the game board.
There are 3 preset sizes (small : 10x10, medium: 30x30, and large: 50x50) any more than that many cubes on screen at once causes
frame rate issues. 

Here's a look at the blank board from a top down view at its largest size.

![](/gifs/board.gif)

The user needs to be able to select the squares and turn them either on or off (alive or dead). I accomplished this via mouseclick
by sending out a ray and checking to see if that ray collided with the cell. I borrowed some of the code form my I3 Dev Test project
and added highlighting for when the cells are hovered over. You can see my initial attempt here.

![](/gifs/bugged_selection.gif)

It kind of works but in some cases when I click on a cell it doesnt change back to white and  requires multiple clicks to do so.
I fiddled around with the highlighting code and realized  it was an issue with the cell when it was being hovered over, I 
changed up the code to remember the cells original non_highlighted color and to reference that when toggling the color. Here's
the improved version in all it's glory.

<<<<<<< HEAD
![](fixed_selection.gif)

### Camera dynamic fov adustment
The camera also changes it's height dynamically to fit the the proper board size onto the screen. Initially, the camera position was hard set for the small, medium, and large sizes. After a few hours of fiddling with values, researching, and using frustrum size calculations from the [Unity Doc](https://docs.unity3d.com/Manual/FrustumSizeAtDistance.html), I was able to get the camera to correctly position itself. With this upgrade the board can now support any sizes from 1 - 100.
=======
![](/gifs/fixed_selection.gif)
>>>>>>> 0414809c81b4cfe9fccbb815a4c27a166ea36cea
