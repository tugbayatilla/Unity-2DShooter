# Unity-2DShooter

## Coursera Videos Steps

### Setup Project

- Missing

### Visual Presentation Of Player

- Create a new Scene in folder Scenes.
- Name the scene as 'Level1'.
- Open 'Level1' scene.
- Delete SampleScene from Scenes folder.
- INFO: Starting player creation.
- Expand folder structure, Assets -> Art -> Player -> Player Sprites.
- Drag&Drop 3 player sprites to Level1 scene.
- INFO: Unity will automatically create animation for us.
- Select Assets -> Art -> Animations -> Player folder.
- Set name as PlayerIdle.anim.
- Same the file.
- INFO: 2 assets has been created in Assets -> Art -> Animations -> Player folder. 'Player Sprites_0'(first sprite in sprites that we had dragged in) and PlayerIdle.
- Rename 'Player Sprites_0' to 'Player' in Assets.
- Rename also 'Player Sprites_0' to 'Player' in Level1 scene.
- INFO: when Player in Level1 Scene selected, you can see 'Sprite Renderer' component. This component shows that what and how sprite being displayed.
- Open the 'Animation' window from the top menu. Window -> Animation -> Animation.
- Dock the 'Animation' to screen, so you can see all the time.
- Run the game and zoom in 'Scene View' to check the spaceship lights are blinking, then stop the game.
- Select the 'Player' gameobject from the 'Hierarchy View'. [shortly Player]
- INFO: you can see the animation if you click the play button on the animation window that you have docked earlier.
- Open the 'Animator' window from the top menu. Window -> Animation -> Animator.
- Dock the 'Animator' to screen, so you can see all the time.
- Select (if not selected) the 'Player' gameobject from the 'Hierarchy View'. [shortly Player]
- INFO: Animator shows the 'State Diagram' of the last selected 'Animator'. In this case, 'Player' gameobject because it has 'Animator' component in it.
- INFO: 'Player Animator' component has been automatically created when we have drag&drop the sprites.
- INFO: inside the animator 'PlayerIdle State' selected, in 'Inspector', you can see 'Motion' property which shows the selected 'Animation', which is in our case 'PlayerIdle Animation'.

### Setup controls of the player

- Set (drag&drop) 'Controller script' Assets -> Scripts -> Player -> Controller.cs to the 'Player' gameobject.
- INFO: If you run the game, player does not respond to any key compination yet.
- INFO: you can see an error at toolbar in Unity. (NullReferenceException: object reference not set ...)
- INFO: you can get detail information from console. Window -> General -> Console.
- Drag&Drop 'InputManager' to the Level1 Scene. Assets -> Prefabs -> Input -> InputManager.
- INFO: now, keyboard is working and we are controlling the Player gameobject.
- INFO: 'InputManager' is collecting input information.




























