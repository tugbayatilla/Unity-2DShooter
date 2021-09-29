# Unity-2DShooter

2D Shooter Assignment
## Overview
> In this assignment, you will complete the 2D Shooter project. 
In part 1 of this assignment you will follow along with a tutorial to create a 2D Shooter and then in part 2, 
you will modify the game to transform it into your own.

## Instructions
- Follow along with the videos that accompany this lesson to build the basis of your game.

- Modify what you created in the tutorial to transform it into your own game. The game should have at least three significant modifications from the tutorial. See the list possible modifications below.

- Come up with a new name for your game and change the UI in the game to reflect the new name.

- Play your game several times and make sure there are no bugs (code issues), flaws in gameplay, or look-and-feel issues. If there are, fix them.

- Make sure to include all necessary scenes in the Unity "Build Settings..."

- Ideally create Windows, MacOS, and WebGL builds of the project (but at least 2 out of 3). NOTE: For WebGL, make sure to select "Decompression Fallback" in the "Publishing Settings" within "Player Settings" prior to building WebGL. Some computer configurations have trouble building to WebGL, particularly if you use non-English characters in your file structure. If this is the case, Windows and MacOS builds will suffice.

- Test that your build works. NOTE: Ideally you can test on all platforms but you should test at least one (Windows or Mac). NOTE: It is difficult to test WebGL games locally due to security features in the browser. You can test WebGL once you submit the build to itch.io below.

- Create a ZIP compressed archive of each of the build folders. To create a zip archive in Windows, you can right-click on a folder then select "Send To->Compressed (zipped) Folder" from the contextual menu. To create a zip archive in MacOS, you can right-clicking on a folder and then select "Compress" from the contextual menu.

- Create a page on itch.io for your game.

- Optionally include a cover image.

- Include the builds created above. For Windows and Mac builds, make sure to select "Executable" and select the corresponding platform. For WebGL, make sure to click "This file will be played in the browser". 

- Include a description of your actual modifications to the game (at least 3) AND your game credits ("Created by ...").

- Set the "Release Status" to "Released".

- Set the Pricing to "No Payment"

- Save the page and click "View page"

- Make sure the screenshots show by clicking on "Edit Theme" and set the "Screenshots" layout to "Sidebar" and save.

- Click "Edit Game" again and set the Visibility to "Public". You can also check "Unlisted in search & browse".

- Make any other desired modifications.

- Save the page and then click "View page" to bring up what your players will see.

- S​ubmit the itch.io URL to the peer review assignment in Module 4. You are responsible for ensuring that you've submitted correctly according to these instructions. Test your submission on another computer if possible.

## M​odification Suggestions

- The game should have at least three significant modifications beyond what you put together in part 1, across the following categories:

- Design Modifications (these are more design intensive), such as:
  - Create a complete interesting, comprehensive, and coherent level. 

- Add multiple additional levels and tie them in to create a logical progression in your game. (NOTE: Each level should be unique in some way, such as different type of challenges for the player.)
  - Modify the out-of-game menus in some significant and meaningful way.

- Aesthetic (Visual/Audio) Modifications (these are more art intensive), such as:
  - Reskin the existing graphics in some significant way, such as change the player or an enemy to a completely different character.

- Add additional significant and coherent graphical elements to the game, such as new enemies or environmental challenges, complete with animated states.

  - Replace sound effects in the game to update the sound design of the game. (NOTE: You will need to change ALL the sound effects for this to be significant. Don't just change one.)

  - Add custom music to your game. (NOTE: Custom meaning you created the music with a tool such as Garage Band or Fruity Loops. If you just swap out the music for another track you find, this is not considered a significant change ... though you can do it without it counting as a significant modification.)

  - Gameplay Modifications (these are more system/programming intensive), such as:
    - Add new player abilities, such as modified controls, additional moves, or additional power ups.

- Add new enemies with their own behavior. (NOTE: This can be considered two modifications if you create unique behavior AND create the art and animation.)

- Add new obstacles and challenges. (NOTE: This can be considered two modifications if you create unique behavior AND create the art and animation.)

- Modify the in-game GUI in some significant way.

- You can use the examples above or come up with your own modifications. Be creative. Push yourself. This is your chance to differentiate your game, make something portfolio worthy, and impress us your fellow learners.

## Steps

- create new 2d project
- install assets package from coursera
- download and install input system from unity registery in package manager in window menu
- set input system as default input system in edit_projectsettings_inputsystempackage should be "process events in dynamic update"
- create player using sprites. drag drop sprites, automatically create animation and rename the objects as player
- open animation window - window menu, Animation, Animation
- open animator window - window menu, Animation, Animator - state diagram for last selected objects
- add inputmanager from prefabs to the scene
- add health and demage script to player
- set effects for scripts
- add straight shooter for an enemy to test
- add rigidbody2d to player for physics
- change some properties in rigitbody
- add polygon collider2d to player
- change the polygon to fit he player
- set shooter script to player
- change properties in shooter script
- create gameobject for projectileholder
- set projectileholder tp shooter script
- create gameobject for playerfireeffect
- add audiosource to playerfireeffect
- set playerfire audioclip to audiosource in playerfireeffect
- add timed object destroyer to playerfireeffect
- make playerfireeffect as prefabs
- set playerfireeffect prefab in shooting script fire effect in player
- remove playerfireeffect from the scene - because we have prefab now
- change the tag of the player to player
- make player as prefab so we can use it in different lavels
- remove main camera from the scene
- add prefab camera from the prefabs
- rename the camera as  main camera
- info: alway keep the game object in z:0
- info: because it is 2d, camera projection is orthographic
- change background color to black in camera
- set the changes to prefab, click override and set apply all
- change the size 5 in prefabs camera
- change the main camera name to large camera
- change the size of the camera to 8
- create a prefab from large camera
- rename the prefabs main camera to small camera
- set player as target in camera controller script in large camera
- add background assert to the level 1 scene
- info: sorting layers is important because engine renders with the order
- go to layers, create background layer, change the sorting layer and make it first layer
- select the sorting laeyer as background in background game object
- copy and paste to cover all background
- add wallofastreoids to the scene
- create empty gameobject as environment
- move every env object into the environment game object
- add gamemanager from prefabs to the level 1 scene
- add uimanager from prefabs to the level 1 scene
- eventsystem: [3:30](Game Loop Setup 1 Management and UI)
- set UIInputActions assets into the eventsystem gameobject inpus systtem component, action assets
- add text into the canvas
- change the font and location
- set score:0
- info: problem when you change the scale in game view because text is out of bounds everytime.
- change the pivot of the text ui object
- info: promlem solve: anchpr of the ui object is importatnt
- using the swift and alt keys to change the position and location of the anchor
- make the text ui element top-left anchor
- dublicate text and name if high score test
- change text
- add score display script to ui text element
- add hogh score scriptto ui high score element
- add image ui element to scene
- change image source to UIBackdrop asset
- change name of image as Pause screen
- resize the image to fill enough the screen
- add child text object insode image to display pouse text
- info: engine renders the elements in scene starting from top to bottom.
- anchor the text in image at top or any location u want
- change the text as Paused
- add button and to continue the game
- change image source of the button to UIButton_0
- chnage button transition to sprite swap
- set all except disabled sprite as IOButton_1
- add highlight fix script to button component
- rename button to unpouse button
- set button onlick, UIManager, TogglePause method
- change canvas scaler ui scale mode to scale with screen size
- add gameoverscreen prefab into the scene under canvas
- copy mainmenu button from gameoverscreen to pase screen and align
- add gameoverscreen to uimanager pages
- change gameover page index in gamemanager
- change game victory page index in gamemanager (victory page will be added soon)
- add level win screen from prefabs to scene under canvas
- add the levelwinscreen to uimanager pages list
- remove the visibility of levelwinscreen and gameoverscreen
- create  a new scene named MainMenu
- add the scenes to the scenes list in settings
- add mainmenu prefab to mainmenu scene
- rename the canvas as InGameUICanvas
- make prefab from InGameUICanvas
- create new gameobject in mainmenu as name it as MainMenuMusic
- add audio source to mainmenumusic
- set menu music as audioclip and make it loop,
- go to level1 scene
- create new gameobject in level1 as name it as MainMenuMusic
- add audio source to level1music
- set menu music as audioclip and make it loop,
- add more levels
- goto mainmenu prefab and expand it
- make visible levelselect object
- duplicate level1 to create other levels
- set level buttons to levels - LoadlLevelByName
- info: don't forget the scenes are in build settings in project
- change levelwinscreen, from mainmenu to level2 to load next screen
- make the last change for every level / these levels are static, how to create a dynamic levels?
- little bit code
- build and publishing
- add screenshotutility to main menu to get screenshot in game
- update player setting 
- change default icon
- check decompres option in webgl 
- zip the builds




























