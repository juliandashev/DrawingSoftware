Introduction:
------------------------------------------------------------------------------------------------------------------------------------------------------------------------
A C# Windows Form App course project

This projects contains GUI, Model and Processors folders

------------------------------------------------------------------------------------------------------------------------------------------------------------------------
About Model folder:
------------------------------------------------------------------------------------------------------------------------------------------------------------------------
The Model folder contains two subfolders: Base and Shapes

Base is for the abstract base classes
and Shapes folder contains all the shapes created (obvious, right :D).

Each shape has a "Contains" method that is defined to suit the needs of the shape, which means that if the user creates a circle or ellipse when clicking inside the ellipse it can be moved,
but when clicking outside it won't move. Same with Polygons, Splines, etc.


------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Usage:
------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Left panel of the application contains most common shapes that could be added (in my opinion), and on the top menu in tab "Фигури" can be found other shapes as well.

On tab "Манипулации" are some manipulation that could be done to a shape, like chaning fill color, stroke color, size, etc.

Here are some key combinations: 
- Control + C: copies selected figures
- Control + V: pastes copied figures
- Control + A: selectes everything
- Del: deletes selected item/s
- Control + G: groups selected elements
- Control + U: ungroups selected elements
- Disselecting happenes when clicking away from alrady selected primitives

Exit and Save model are still on progress
