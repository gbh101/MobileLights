using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sConfirmationBoxLogic : MonoBehaviour
{
    // Stores this game object's canvas
    private Canvas canvas;
    // For storing the Main Camera of the current scene
    private Camera targetCam;
    // For storing the current scene
    private Scene scene;

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

        // For use determining what the "Yes Button" does
        scene = SceneManager.GetActiveScene();
    }

    public void YesButton()
    {
        // Main Menu: Quit the Game
        if(scene.name == "scMainMenu")
        {
            Application.Quit();
            Debug.Log("Quit Game");
        }
        // Scene Not Covered: Throw Error Message
        else
        {
            Debug.Log("This case is not covered: " + scene.name);
        }
    }

    public void NoButton()
    {
        // Destroys the confirmation box
        Destroy(gameObject);
    }
}
