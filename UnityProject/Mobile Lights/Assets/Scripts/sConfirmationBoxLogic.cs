using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class sConfirmationBoxLogic : MonoBehaviour
{
    // Stores this game object's canvas
    private Canvas canvas;
    // For storing the Main Camera of the current scene
    private Camera targetCam;
    // For storing the source of the CoDA
    private string buttonSource = "Default Source";

    private void Awake()
    {
        canvas = gameObject.GetComponent<Canvas>();
        targetCam = GameObject.Find("Main Camera").GetComponent<Camera>();

        // Sets the camera that the canvas will project itself onto
        if (targetCam != null)
        {
            canvas.renderMode = RenderMode.ScreenSpaceCamera;
            canvas.worldCamera = targetCam;
        }

        // Create "Disable Buttons" event
        // sMainMenuLogic and sGameplayCanvasLogic are listeners
        sEventManager.TriggerEvent("Disable Buttons");
    }

    // Starts listening to determine source of CoDA
    private void OnEnable()
    {
        sEventManager.StartListening("Quit Game", QuitGame);
        sEventManager.StartListening("Main Menu", MainMenu);
        sEventManager.StartListening("Level Select", LevelSelect);
        sEventManager.StartListening("Reset Level", ResetLevel);
    }

    // Stops all listening
    private void OnDisable()
    {
        sEventManager.StopListening("Quit Game", QuitGame);
        sEventManager.StopListening("Main Menu", MainMenu);
        sEventManager.StopListening("Level Select", LevelSelect);
        sEventManager.StopListening("Reset Level", ResetLevel);
    }

    public void YesButton()
    {
        // Quit the Game
        if(buttonSource == "QuitGame")
        {
            Application.Quit();
            Debug.Log("Quit Game");
        }
        // Go to Main Menu
        else if (buttonSource == "MainMenu")
        {
            SceneManager.LoadScene("scMainMenu");
        }
        // Go to Level Select
        else if (buttonSource == "LevelSelect")
        {
            SceneManager.LoadScene("scLevelSelect");
        }
        // Reset the current level
        else if (buttonSource == "ResetLevel")
        {
            Debug.Log("Level has been reset");
            // Resets the board state to its initial setting
            // Maintains # of clicks through reset
        }
        // Scene Not Covered: Throw Error Message
        else
        {
            Debug.Log("This case is not covered: " + buttonSource);
        }
    }

    public void NoButton()
    {
        // Stops all Listening
        sEventManager.StopListening("Quit Game", QuitGame);
        sEventManager.StopListening("Main Menu", MainMenu);
        sEventManager.StopListening("Level Select", LevelSelect);
        sEventManager.StopListening("Reset Level", ResetLevel);
        
        // Destroys the confirmation box
        Destroy(gameObject);

        // Create "Enable Buttons" event
        // sMainMenuLogic and sGameplayCanvasLogic are listeners
        sEventManager.TriggerEvent("Enable Buttons");
    }


    /***** For setting how the "Yes Button" reacts *****/
    private void QuitGame()
    {
        buttonSource = "QuitGame";
    }

    private void MainMenu()
    {
        buttonSource = "MainMenu";
    }

    private void LevelSelect()
    {
        buttonSource = "LevelSelect";
    }

    private void ResetLevel()
    {
        buttonSource = "ResetLevel";
    }
    /***************************************************/
}
