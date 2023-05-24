# Tetris
Build Tetris app


The logic of the application:
The game plays on a grid of 20 rows and 10 column. However, we need 2 extra row at the top to handle the spawning of the blocks. so the grid will be 22 rows and 10 column. The 2 extra top grid will have hidden property, so it won't be visible in the real gameplay.
The rows will be indexed from top to bottom and the column will be indexed from left to right. There is the class GameGrid to represent the GameGrid, and the contructor of this class consist of 2 dimensional integer array.
<img width="424" alt="Screenshot" src="https://github.com/cozyGarage/Tetris/assets/9263674/5ec95127-18cc-4e9f-85d5-d0e498f82949">




 The values 0 and 1 used in IsRowFull, IsEmpty, ClearRow, and MoveRowDown should be defined as constants or enums to improve code readability.

![image](https://user-images.githubusercontent.com/9263674/235161818-96b7e451-455f-4b13-bf31-16c4ce698026.png)


