# Tetris
Build Tetris app


The logic of the application:
The game plays on a grid of 20 rows and 10 column. However, we need 2 extra row at the top to handle the spawning of the blocks. so the grid will be 22 rows and 10 column. The 2 extra top grid will have hidden property, so it won't be visible in the real gameplay.
The rows will be indexed from top to bottom and the column will be indexed from left to right. There is the class GameGrid to represent the GameGrid, and the contructor of this class consist of 2 dimensional integer array.
<img width="424" alt="Screenshot" src="https://github.com/cozyGarage/Tetris/assets/9263674/5ec95127-18cc-4e9f-85d5-d0e498f82949">

Here we demonstrate how many type of the block in the game and how we register in on the game grid array.

<img width="349" alt="Screenshot 2023-05-25 at 0 20 07" src="https://github.com/cozyGarage/Tetris/assets/9263674/e0d659ab-103e-4706-9a8b-c6a2a7dffac6">

here is how we use id to mark those blocks. Emptry cell will be present with value zero, cyan tile present with value 1, blue tile present with value 2, orange tile has value 3, yellow tile has value 4, green tile has value 5, purple tile has value 6, red tile has value 7. The current block will be not register the value until it is unmovable or the game is over

<img width="348" alt="Screenshot 2023-05-25 at 0 20 21" src="https://github.com/cozyGarage/Tetris/assets/9263674/94ab7645-f44f-407a-8fea-7c26a29afd7a">

The GameGrid class is 2 dimensional array. It has row and collumn. and an indexer to provide easy access for the array.
In the construcor of the class, we will take in 2 parameter. in the way, we can modify the gamegrid, or create many different object of GameGrid for many different game mode for expamle.



 The values 0 and 1 used in IsRowFull, IsEmpty, ClearRow, and MoveRowDown should be defined as constants or enums to improve code readability.

![image](https://user-images.githubusercontent.com/9263674/235161818-96b7e451-455f-4b13-bf31-16c4ce698026.png)


