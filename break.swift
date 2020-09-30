// cerner_2^5_2020
var currentLevel:Int = 1, finalLevel:Int = 2
var isLifeAvailable = true
while (isLifeAvailable) {
    
    if currentLevel > finalLevel {
        print("Game Completed. No level remaining")
        break
    }
    //play game and go to next level
    currentLevel += 1
    print("next level")
}
print("outside of while loop")