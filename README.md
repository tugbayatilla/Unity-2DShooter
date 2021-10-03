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
  