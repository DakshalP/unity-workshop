# Editor Changes
*All the changes we made in the **Unity** editor, listed.*

## Step 1: Creating Game Objects
* Opened Unity and made a project
* Renamed the level
* Created a cube, reset its transform coordinates, scaled it up
* Created the ball and alley materials
* Changed the skybox to a solid color
* Imported the bowling pin, gave it a material

## Step 2: Player Movement and Camera Follow
* Create PlayerMovement script
    * Learn how to do Debug.Log()
    * Learn how to use f at the end of floating point numbers (Example: 10.0f)
* Create FollowPlayer script

## Step 3: Handling Pin Collisions
* Pin Controller Script
    * Introduce `GetComponent<>` and `OncollisionEnter`
    * Handle pin collision and check if it tipped

## Step 4: Keeping Track of Score
* Create a UI Text element (Right-Click > UI > Text)
* GameManager Script
* Use `FindObjectOfType<Gamemanager>` to call the add point method

## Step 5: End-Game Functionality
* Use the SceneManagement library
* Load the current scene to restart
* Load the next scene to move on to the next level
    * Use the build index of the next level
