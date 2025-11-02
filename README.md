# Tetris

[![Build and Release](https://github.com/cozyGarage/Tetris/actions/workflows/build-and-release.yml/badge.svg)](https://github.com/cozyGarage/Tetris/actions/workflows/build-and-release.yml)
[![Deploy to GitHub Pages](https://github.com/cozyGarage/Tetris/actions/workflows/deploy-pages.yml/badge.svg)](https://github.com/cozyGarage/Tetris/actions/workflows/deploy-pages.yml)

## Install app

### Option 1: Download Pre-built Release
1. Visit the [Releases page](https://github.com/cozyGarage/Tetris/releases/latest)
2. Download the latest `Tetris-Release.zip` file
3. Extract the ZIP file
4. Run `Tetris.exe`

**Requirements:**
- Windows 10 or later
- .NET 6.0 Runtime (Desktop) - [Download here](https://dotnet.microsoft.com/download/dotnet/6.0)

### Option 2: Build from Source
1. Clone the repository
2. Open `Tetris.sln` in Visual Studio 2022 or later
3. Build the solution (Ctrl+Shift+B)
4. Run the application (F5)

### Visit our Website
Check out our [GitHub Pages site](https://cozygarage.github.io/Tetris/) for more information and downloads.  

## Demo

https://youtu.be/d-2dKYCpVfw



## Build Tetris app


The logic of the application:
The game plays on a grid of 20 rows and 10 column. However, we need 2 extra row at the top to handle the spawning of the blocks. so the grid will be 22 rows and 10 column. 
The 2 extra top grid will have hidden property, so it won't be visible in the real gameplay.
The rows will be indexed from top to bottom and the column will be indexed from left to right. 
There is the class GameGrid to represent the GameGrid, and the contructor of this class consist of 2 dimensional integer array.

<img width="349" alt="Screenshot" src="https://github.com/cozyGarage/Tetris/assets/9263674/5ec95127-18cc-4e9f-85d5-d0e498f82949">

Here we demonstrate how many type of the block in the game and how we register in on the game grid array.

<img width="349" alt="Screenshot" src="https://github.com/cozyGarage/Tetris/assets/9263674/e0d659ab-103e-4706-9a8b-c6a2a7dffac6">

We use id to mark those blocks. Emptry cell will be present with value zero, cyan tile present with value 1, blue tile present with value 2, orange tile has value 3,
yellow tile has value 4, green tile has value 5, purple tile has value 6, red tile has value 7. The current block will be not register the value until it is unmovable or the game is over

<img width="348" alt="Screenshot" src="https://github.com/cozyGarage/Tetris/assets/9263674/94ab7645-f44f-407a-8fea-7c26a29afd7a">

## GameGrid
The GameGrid class is 2 dimensional array. It has row and collumn. and an indexer to provide easy access for the array.
In the construcor of the class, we will take in 2 parameter. in the way, we can modify the gamegrid, or create many different object of GameGrid for many different game mode for expamle.
GameGrid helps some method to check:
        * Given cell is in grid or not.  
        * Given call is empty or not.  
        * Given row is full or not.  
        * Given row is empty or not.  
        * Clear the row when it is full and down it down.  
        
    



 The values 0 and 1 used in IsRowFull, IsEmpty, ClearRow, and MoveRowDown should be defined as constants or enums to improve code readability.

![image](https://user-images.githubusercontent.com/9263674/235161818-96b7e451-455f-4b13-bf31-16c4ce698026.png)


## Blocks
In Tetris there is 7 blocks in Tetris. We will represent 7 Blocks in the game
![7Blocks](https://github.com/cozyGarage/Tetris/assets/9263674/34bbc698-e9a2-4ed4-8ecd-cba3797ac21e)
Each Block will have 1 rotating point that we use to turn the block Clockwise or Reverse Clockwise
![7Blocks-Rotating](https://github.com/cozyGarage/Tetris/assets/9263674/eae6288d-b642-4770-a754-dee1893b006e)
To rotate each block, we create a 4x4 grid with the center is the center of each block.
![7Blocks-Center](https://github.com/cozyGarage/Tetris/assets/9263674/e84ffc34-fbb3-40e6-93fc-ccb4ae962260)

This class should be an abstract class, each type of blocks will have it own class derived from this parent class.

## Postion
The position class use to represent the current position of moving block on game grid.

## BlockQueue

This class is responsible for picking the next block for the game.
 It's constant a Block array, which an instance should be the random 1 of 7 type of the block
 create the block
 
## GameState
This class control the gameflow:
It consists of




## CI/CD Pipeline

This project uses GitHub Actions for continuous integration and deployment:

### Build and Release Workflow
- **Trigger:** Push to main/master branch, Pull Requests, or manual dispatch
- **Runs on:** Windows Latest
- **Steps:**
  1. Checkout code
  2. Setup .NET 6.0
  3. Restore dependencies
  4. Build the solution in Release configuration
  5. Publish the application
  6. Upload build artifacts

### GitHub Pages Deployment
- **Trigger:** Push to main/master branch or manual dispatch
- **Purpose:** Deploys a landing page with download links and game information
- **URL:** [https://cozygarage.github.io/Tetris/](https://cozygarage.github.io/Tetris/)

### How to Create a Release
1. Create a new tag: `git tag v1.0.0`
2. Push the tag: `git push origin v1.0.0`
3. The workflow will automatically create a GitHub Release with the compiled artifacts


