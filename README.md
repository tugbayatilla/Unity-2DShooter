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

### Setup Player Health & Damage

- Set 'Health Script' to the 'Player'. Assets -> Scripts -> Health&Damage -> Health.
- INFO: TeamId means, which team the object belongs to, so it might NOT take damage from the same team. Do not change this, keep it as 0.
- Change 'Use Lives' property as true (checked).
- Set 'Death Effect' with 'PlayerDeathEffect' from Assets -> Prefabs -> Effects -> Player.
- Set 'Hit Effect' with 'PlayerHitEffect' from Assets -> Prefabs -> Effects -> Player.
- INFO: to be able to test this 2 effects, we need to add an enemy to the screen.
- Add an enemy 'StraightShooter' game object to the Leve1 scene (3.11,3.59,0). Assets -> Prefabs -> Enemies -> IndividualEnemies -> StationaryEnemies.
- INFO: Player location is (0,0,0).
- INFO: Run the game to test. But no hit to the player.
- INFO: Because there is no physics applied to the player.
- INFO: Unity has 2 physics engine. 2D and 3D.
- INFO: Use 2D physics components all the time in 2D games.
- Add new 'Rigidbody 2D' component to the 'Player'.
- INFO: * Now our player will be effected by physics.
- INFO: If you run the game, 'Player' gameobject will drop from the game screen becase 'Gravity Scale' property has set as 1.
- Change the 'Gravity Scale' in 'Rigidbody 2D' component in 'Player' gameobject from 1 to 0.
- INFO: if you run the game, now Player is not dropping but still not getting hit from the enemy.
- INFO: because 'Rigidbody 2D' is only a part of the physics puzzle.
- INFO: other part is the 'Collider 2D' component.
- INFO: if you go the the enemy, you can see the 'Collider 2D' component as green line on it.
- INFO: We will apply the same component to the 'Player' now.
- Change 'Collusion Detection' in 'Rigidbody 2D' component from 'Discrete' to 'Continues'. it makes collusion detection more smoothly.
- Change 'Sleeping Mode' in 'Rigidbody 2D' component from 'Start Awake' to 'Never Sleep'. It makes 'Rigidbody' always active.
- Add 'Polygon Collider 2D' component to the 'Player' gameobject.
- Select 'Edit Collider' property in 'Polygon Collider 2D' in 'Player'
- Reshape the borders of the collider in 'Scene Window' to fit it best.
- INFO: run the game and try to get it, now the player explodes.

### Setup Player Fighting Back

- INFO: we has to fight back.
- Add 'ShootingController script' to the 'Player'. Assets -> Scripts -> ShootingProjectiles.
- INFO: ProjectilePrefab property (mandatory) is used for the projectiles that we want to fire in the 'ShootingController' compponent in the 'Player'.
- INFO: ProjectileHolder property (optional) is used for keeping all the projectiles in a gameobject to make the scene clean in the 'ShootingController' compponent in the 'Player'.
- Set 'Is Player Controlled' to true.
- Set 'Player_Projectile' prefab to 'Projectile Prefab' property in the  'ShootingController script' component. Assert -> Prefabs -> Projectiles -> Player_Projectile.
- INFO: run the game, now we can fire the projectiles with mouse left click.
- INFO: when you fire the projectiles, you can see a lot of projectiles in the scene. 
- INFO: lets make them organized.
- Create new empty 'GameObject' named as 'ProjectileHolder' in the scene.
- INFO: Now our hierarchy view is not flooded by projectiles.
- Create new empty 'GameObject' named as 'PlayerFireEffect' in the scene.
- Add 'AudioSource' component to the 'PlayerFireEffect' gameobject.
- Add 'Timed Object Destroyer' script to the 'PlayerFireEffect' gameobject.
- INFO: The most important property on 'AudioSource' is 'AudioClip' property.
- Set 'PlayerFire' sound to the 'AudioClip' property in the 'AudioSource' component in the 'PlayerFireEffect' gameobject.
- Make prefab the 'PlayerFireEffect' gameobject. Simply Drag&Drop the 'PlayerFireEffect' gameobject to the 'Prefabs' folder. Assets -> Prefabs -> Effects -> Player.
- Set 'PlayerFireEffect' prefab to the 'Fire Effect' in the 'ShootingController script' component in the 'Player' gameobject.
- Delete the 'PlayerFireEffect' gameobject from the scene. (becauae we have this objects as prefab now.)
- INFO: now you hear the file sound effect everytime when you fire.
- Change the 'Player' 'Tag' property from 'Untagged' to 'Player'. it will be important in the future.
- Create a folder named as 'Player'. Assets -> Prefabs -> Player. 
- Make prefab the 'Player' gameobject. Drag&Drop to the prefabs folder. Assets -> Prefabs -> Player. 
- INFO: Now we can use player prefab in other levels.

### Setup Cameras To Frame the Action

- INFO: we have a camera named 'Main Camera' is already setup in prefabs. Assets -> Prefabs -> Camera.
- Delete 'Main Camera' gameobject from the scene.
- Add 'Main Camera' prefab from the prefabs. Assets -> Prefabs -> Camera.
- INFO: in 2D games, the 'Transform' of the camrea, 'Rotation' and 'Scale' is not so effective yet, 'Position' is very important.
- INFO: in 2D games, in Camera settings, 'Projection' should be 'Orthographic'.
- Change 'Background' color from blue to black.
- INFO: if you are working on gameobject that has been created from prefab which turns to blue in hierarchy view, and want to change on gameobject and will be effected to all prefabs, you need to select at the top 'override' and then select 'apply all'.
- Rename the camera gameobject in Hierarchy View from 'Main Camera' to 'Large Camera'.
- Make prefab from the 'Large Camera'. Drag&Drop 'Large Camera' to the prefab folder and select 'Original Prefab' in popup menu. Assets -> Prefabs -> Camera.
- Rename the camera in prefabs assets from 'Main Camera' to 'Small Camera'. Assets -> Prefabs -> Camera.
- Change the camera 'Size' from 8 to 5 in 'Small Camera' prefab. 
- INFO: There is a script called 'Camera Controller' added to the camera which controls how the camera moves.
- Set 'Player' gameobject to 'Target' property in 'Camera Controller script' component in 'Large Camera' gameobject.
- Change 'Camera Movement Sytle' property from 'Locked' to 'Free' in 'Camera Controller script' component in 'Large Camera' gameobject.
- INFO: run the game, and the camera follows the player.
  
### Setup Level Environment Sprites

- INFO: we are going to make the level little bit interasting.
- INFO: we are going to use Environment sprites. Assets -> Art -> Environment.
- Add 'B_CompleteSpaceBackground' sprite from prefabs to 'Scene View'. Assets -> Art -> Environment -> Background.
- INFO: this action will automatically add a new gameobject with the same name with the sprite, and add a new 'Sprite Renderer' component into the gameobject.
- INFO: we have a layer issue in here. In Game View, we do not see the Player and the Enemy anymore. Because all gameobjects are using 'Default' in 'Sorting Layer'.
- INFO: 'Sorting Layer' is the rendering order on the game view by the unity engine.
- Select the 'Layers' dropdown menu at the top-right corner of the Unity Editor.
- Select 'Edit Layers...' at the bottom of the opened menu.
- Expand 'Sorting Layers' and click plus(+) button to add new layer.
- Rename the new layer as 'Background'.
- Change the order of the layer. Move the 'Background' to the top, so it will be the first layer that will be rendered by Unity Engine.
- Change the 'Sorting Layer' property from 'Default' to 'Background' in the 'Sprite Renderer' component in the 'B_CompleteSpaceBackground' gameobject.
- INFO: now in 'Game View', you can see the 'Player' and the 'Enemy' again.
- ISSUE: the background is not covering all background.
- INFO: Scaling the background is not a solution because it will not cover enough area and also the quality of the images will dramatically drop.
- INFO: we will create more backgrounds.
- Duplicate 'Main Menu Button' in the  the 'B_CompleteSpaceBackground' gameobject in 'Hierarchy View'.INFO: gameobject.
- Move 'Main Menu Button (1)' to the 'Pause Screen' gameobject.
- Rename 'Main Menu Button (1)' to the 'Main Menu Button'
- Change 'Main Menu Button' gameobject in the 'Pause Screen' position to (0,-43,0).
- Add : we gameobject to the 'Pages' in 'UIManager' gameobject.
- Change 'Game Over  Page Index' from 0 to 1. (1 is the index of 'GameOverScreen' index in the Pages in 'UIManager').
--- Change 'Game Victory  Page Index' from 0 to 2. (2 is the index of 'GameVictoryScreen' index in the Pages in 'UIManager'). 
- 
- Duplicate 'LevelWinu Button' in the  the 'B_CompleteSpaceBackground' gameobject in 'Hierarchy View'.INFO: gameobject.
- Change 'Game Over  Page Index' from 0 to 1. (1 is the index of 'GameOverScreen' index in the Pages in 'UIManager').
- Move  Duplicate 'Main Menu (1)  to the 'Pause Screen' gameobject.
- Rename  Duplicate 'Main Menu (1)  to the Rename  Duplicate 'Main Menu 
- Change Duplicate 'Main Menu  gameobject in the 'Pause Screen' position to (0,-43,0).
- Add  -  gameobject to the 'Pages' in 'UIManager' gameobject.




- Change 'Game Over  Page Index' from 0 to 1. (1 is the index of 'GameOverScreen' index in the Pages in 'UIManager').
--- Change 'Game Victory  Page Index' from 0 to 2. (2 is the index of 'GameVictoryScreen' index in the Pages in 'UIManager'). 
- 
- Move tLevelWincate 'Main Menu Button' in the d gameobject next to the previous background in 'Scene View'.Button' gameobject.
- Change 'Game Over  Page Index' from 0 to 1. (1 is the index of 'GameOverScreen' index in the Pages in 'UIManager').
- INFO: we will also add 'WallOfAsteroids' to be able to restrict the game area.
- Add (4 Times) 'WallOfAsteroids' prefab to the 'Scene View'. Assets -> Prefabs -> Environment & Hazards -> Stationary.
- Make 'WallOfAsteroids' as a square to limit the game area.
- Duplicate 'Main Menu Button' in the  enough 'B_CompleteSpaceBackground' gameobject to cover the background. ()'WallOfAsteroids' gameobject.




- Move 'Main Menu Button (1)' to the 'Pause Screen' gameobject.
- Rename 'Main Menu Button (1)' to the 'Main Menu Button'
- Change 'Main Menu Button' gameobject in the 'Pause Screen' position to (0,-43,0).
- Add  'WallOfAsteroids' gameobject to the 'Pages' in 'UIManager' gameobject.
- Change 'Game Over  Page Index' from 0 to 1. (1 is the index of 'GameOverScreen' index in the Pages in 'UIManager').
--- Change 'Game Victory  Page Index' from 0 to 2. (2 is the index of 'GameVictoryScreen' index in the Pages in 'UIManager'). 
- 
- Duplicate 'LevelWinu Button' in the  enough 'B_CompleteSpaceBackground' gameobject to cover the background. ()'WallOfAsteroids' gameobject.
- Change 'Game Over  Page Index' from 0 to 1. (1 is the index of 'GameOverScreen' index in the Pages in 'UIManager').
- Create new 'Game Object' named 'Background' (0,0,0) in the 'Environments' gameobject to organize 'Hierarchy View'.
- Move all 'B_CompleteSpaceBackground' gameobject that you have into the 'Background' gameobject.
- Create new 'Game Object' named 'Walls' (0,0,0) in the 'Environments' gameobject to organize 'Hierarchy View'.
- Move all 'WallOfAsteroids' gameobject that you have into the 'Background' gameobject.





### Setup Game Loop with Game Manager and UI

- Add 'GameManager' prefab to the Scene. Assets -> Prefabs -> Management.
- INFO: 'GameManager' keeps the state of the game.
- Add 'UIManager' prefab to the Scene. Assets -> Prefabs -> Management.
- Set 'UIManager' gameobject into the 'Ui Manager' property in the 'Game Manager' script in the 'GameManager' gameobject.
- Set 'Player' gameobject into the 'Player' property in the 'Game Manager' script in the 'GameManager' gameobject.
- INFO: run the game, you will see couple of warning messages. "There is no event system in the scene but you are trying to use the UIManager. /nAll UI in Unity requires an Event System to run. /nYou can add one by right clicking in hierarchy then selecting UI->EventSystem."
- Create a 'Canvas' in the scene. 
- INFO: creating a canvas, also creates a 'EventSystem' gameobject automatically.
- INFO: Because we are using 'InputSystem' (we setup the project with this) we need to replace 'Standalone Input Module'. fortunatelly it's easy.
- Select the 'EventSystem' and click the 'Replace with InputSystemUIInputModule' button in the 'Standalone Input Module'.
- Set 'Action Asset' property in 'Input System UI Input Module' script in 'EventSystem' with 'UIInputActions' prefab. Assets -> Prefabs -> Input.
- INFO: now our eventsystem must be setup correctly.
- INFO: 'Canvas Scaler' in Canvas is the most important part. Because in different resolutions the application react differently.
- INFO: we are going to add score and high score into the canvas.
- Create new 'Text' gameobject name as 'Score text' in the Canvas.
- Change the 'Text' property to 'Score: 0' in 'Text' gameobject.
- Change the 'Font' property to 'manaspc' in 'Text' gameobject.
- Change the 'Color' property to white in 'Text' gameobject.
- Move the 'Text' gameobject to top-left corver of the canvas.
- ISSUE: if you change the ratio of the screen in the 'Game View' to different aspects, you can see 'Text' gameobject might be out of canvas.
- INFO: all of because of the anchor to the parent object. we need to set it correctly.
- Change the 'Rect Transform' from 'middle-center' to 'top-left'. you can use 'Shift' and 'Alt' keyboard keys as helpers.
- INFO: you can see the cross marking set to the top-left corner instead of center of the canvas.
- Duplicate 'Main Menu Button' in the  'Score text' gameobject and rename as 'High Score text'. you can gameobject.
- Move 'Main Menu Button (1)' to the 'Pause Screen' gameobject.
- Rename 'Main Menu Button (1)' to the 'Main Menu Button'
- Change 'Main Menu Button' gameobject in the 'Pause Screen' position to (0,-43,0).
- Add : you gameobject to the 'Pages' in 'UIManager' gameobject.
- Change 'Game Over  Page Index' from 0 to 1. (1 is the index of 'GameOverScreen' index in the Pages in 'UIManager').
--- Change 'Game Victory  Page Index' from 0 to 2. (2 is the index of 'GameVictoryScreen' index in the Pages in 'UIManager'). 
- 
- Duplicate 'LevelWinu Button' in the  'Score text' gameobject and rename as 'High Score text'. you can gameobject.
- Change 'Game Over  Page Index' from 0 to 1. (1 is the index of 'GameOverScreen' index in the Pages in 'UIManager').
- Change the 'Text' property of the 'High Score: 0' gameobject.

### Setup End Game UI and Pause Screen





- Add 'ScoreDisplay' script to 'Score text' gameobject. Assets -> Scripts -> UI.
- INFO: 'ScoreDisplay' scripts updates the score display when the GameManager tells it to.
- Set 'Score text' gameobject to 'Display Text' property in the 'ScoreDisplay' scripts in the 'Score text' gameobject. (set itself in the script)
- INFO: run the game, now you can see the score when you destroy the enemy. 
- Set 'High Score text' gameobject to 'Display Text' property in the 'HighScoreDisplay' scripts in the 'High Score text' gameobject. (set itself in the script)
- INFO: run the game, now you can see the high score value that we have already obtained earlier.
- ISSUE: now when you click the escape key, the game pauses yet there is no screen to show this.
- Create new 'Image' gameobject in the 'Canvas'.
- Change the 'Source Image' from 'None' to 'UIBackdrop' in the 'Image' component in the 'Image' gameobject. Assets -> Art -> UI Elements -> Backdrop.
- Rename the 'Image' gameobject to 'Pause Screen' on the scene.
- Resize the 'Pause Screen' to W:340, H:340.
- Add 'Text' gameobject in the 'Pause Screen' for title of the game.
- Rename 'Text' gameobject to 'Title text' in the 'Pause Screen'.
- Anchor 'Title text' gameobject to top-center.
- Change 'Title text' gameobject position to (0,-21,0).
- Change 'Title text' gameobject properties, Text as 'Paused', Font as 'manaspc', Font Size as '36', Alignment as 'Center-Center', Horizontal and Vertical Overflow as 'Overflow'.
- Add 'Button' gameobject in the 'Pause Screen' for unpausing the game.
- Rename 'Button' gameobject to 'Un-Pause Button' in the 'Pause Screen'.
- Change 'Un-Pause Button' gameobject 'Text' gameobject Text to 'Un-Pause', Font as 'manaspc'.
- Change 'Un-Pause Button' gameobject 'Source Image' property to 'UIButton_0' in the 'Image' component. Assets -> Art -> UI Elements -> Buttons.
- Change 'Un-Pause Button' gameobject 'Transition' property to 'Sprite Swap' in the 'Button' component.
- Change 'Un-Pause Button' gameobject 'Highlighted Sprite' property to 'UIButton_1' in the 'Button' component. Assets -> Art -> UI Elements -> Buttons.
- Change 'Un-Pause Button' gameobject 'Press Sprite' property to 'UIButton_1' in the 'Button' component. Assets -> Art -> UI Elements -> Buttons.
- Change 'Un-Pause Button' gameobject 'Selected Sprite' property to 'UIButton_1' in the 'Button' component. Assets -> Art -> UI Elements -> Buttons.
- INFO: don't change 'Disabled Sprite' property in the 'Button' component.
- ISSUE: run the game, now you can mouse over the button but it's not so clear clicked and hover. to fix this, there is a script called 'Highlight Fix' by Unity.
- Add 'Highlight Fix' script to the 'Un-Pause Button' gameobject.
- Add OnClick Event to 'Un-Pause Button' gameobject.
- Set UIManager as Object in the 'Un-Pause Button' gameobject.
- Select xxx as UIManager.TogglePause function in the 'Un-Pause Button' gameobject.
- ISSUE: run the game, now pause button works as expected, yet pause screen always stays on the screen.
- INFO: we are going to setup UIManager pages.
- Add 'UI Page' script to 'Pause Screen' gameobject.
- Set 'Un-Pause Button' gameobject to 'Default Selected' property in the 'UI Page' script to 'Pause Screen' gameobject.
- Set 'Pause Screen' gameobject in the 'Element 0' property in the 'UI Manager' script in the 'UIManager' gameobject.
- Change the 'Page Page Index' from 1 to 0 (because the 'Pause Screen index is 0').
- Change the visibility to false of the 'Pause Screen' gameobject.
- INFO: run the game, now you can click escape key to pause the game and click unpause button to unpause.
- ISSUE: when we change the 'Aspect Ratio' of the game to 5:4, 5:3 or other, the 'Pause Screen' gameobject will not scale correctly.
- Change 'UI Scale Mode' from 'Constant Pixel Size' to 'Scale With Screen Size' in the 'Canvas Scaler' in the 'Canvas'.
- Change 'Match' from 0 to 0.5 in the 'Canvas Scaler' in the 'Canvas'.
- INFO: now we can change the 'Aspect ratio' and the 'Pause Screen' gameobject will adapt the ratio.

### Setup Game Loop In-Game UI and Main Menu
 
- Add 'GameOverScreen' prefab in the Canvas. Assets -> Prefabs -> UI -> UIPages.
- Duplicate 'Main Menu Button' in the 'GameOverScreen' gameobject.
- Move 'Main Menu Button (1)' to the 'Pause Screen' gameobject.
- Rename 'Main Menu Button (1)' to the 'Main Menu Button'
- Change 'Main Menu Button' gameobject in the 'Pause Screen' position to (0,-43,0).
- Add 'GameOverScreen' gameobject to the 'Pages' in 'UIManager' gameobject.
- Change 'Game Over Page Index' from 0 to 1. (1 is the index of 'GameOverScreen' index in the Pages in 'UIManager').
- Add 'LevelWinScreen' prefab in the Canvas. Assets -> Prefabs -> UI -> UIPages.
- Add 'LevelWinScreen' gameobject to the 'Pages' in 'UIManager' gameobject.
- Change 'Game Victory Page Index' from 0 to 2. (2 is the index of 'LevelWinScreen' index in the Pages in 'UIManager'). 
- INFO: UIManager Page Order so far should be, 'PauseScreen', 'GameOverScreen', 'LevelWinScreen'.
- Create a scene names 'MainMenu' in the Scenes assets. Assets -> Scenes.
- INFO: 'MainMenu' should ne exacly as here. no space, no change at all. because this name was used in the scripts.**
- Goto 'File Menu' and select 'Build Settings' and add 'MainMenu' scene to the 'Scenes In Build' list.
- Select 'MainMenu' by double clicking.
- Add 'MainMenu' prefab to the 'MainMenu' scene. Assets -> Prefabs -> UI.
- Select 'Level1' scene again.
- Change 'Enemies To Defeat' from 10 to 3 in the 'GameManager'.
- Add 3 enemies to the 'Scene View'. Assets -> Prefabs -> Enemies.
- INFO: run the game, now you can destroy all the enemies and victory screen will be shown.
- Change 'NextLevelButton' property from "<empty string>" to 'MainMenu' in OnClick event in 'NextLevelButton' gameobject.
- Move 'EventSystem' into the 'Canvas'.
- Rename Canvas to 'InGameUICanvas'.
- Make prefab from 'InGameUICanvas'. Assets -> Prefabs -> UI.

 ### Setup Audio and Music
 
 - Select 'MainMenu' scene.
 - Create new 'GameObject' and name as 'MainMenuMusic'.
 - Add 'AudioSource' component to 'MainMenuMusic' gameobject.
 - Set 'Menu' music to 'AudioClip' property in AudioSource component in the 'MainMenuMusic' gameobject. Assets -> Audio -> Music.
 - Set 'Loop' property to true.
 - Select 'Level1' scene.
 - Create new 'GameObject' and name as 'GameMusic'.
 - Add 'AudioSource' component to 'GameMusic' gameobject.
 - Set 'SongA' music to 'AudioClip' property in AudioSource component in the 'GameMusic' gameobject. Assets -> Audio -> Music.
 - Set 'Loop' property to true.
 
### Setup More Levels

- INFO: if you don't want to do all of the levels from scratch, use level1 prefab.
- Duplicate Level1 asset in Scenes with CTRL+D command. Assets -> Scenes.
- Rename 'Level1 1' to 'Level2'.
- Goto 'File Menu' and select 'Build Settings' and add 'Level2' scene to the 'Scenes In Build' list.
- Select 'Level1' scene.
- Change 'NextLevelButton' function argument from 'MainMenu' to 'Level2' in 'LevelWinScreen' gameobject.
- Repeat all for every new level. 

