# ToyRobotCodeChallenge
Robot Challenge as part of Iress Interview process

## Purpose of the Application.

The following application was created to control a robot, place the robot into a 5 unit square table. And control its movements.
The robot is not allowed to fall from the table, as such the movement is limited to only 5 units (begining with 0,0) and maximum (4,4), Any other movement will be restrained.


## Allowed Commands.

- Place(which receives 3 arguments, X,Y,F) X and Y are Values between 0 and 4, and F only allows strings NORTH, SOUTH, EAST AND WEST.
- Move() requires no parameters and moves the Robot towards the facing value (i.e. moves Y positive if facing north, moves Y negative if facing South).
- Left() requires no parameters and turns the Robot towards the left (i.e. if it was facing North it will turn it West).
- Right() requires no parameters and turns the Robot towards the right (i.e. if it was facing North it will turn it East).
- Report() requires no parameters and reports the current location of the robot in "X,Y,F" format (i.e. 0,0,NORTH).


## Each RobotMovement has a robot object attached to it. so only robotMovement objects should be used.

## Unit testing

Requires NUnit nuget package to run.
