using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class sGameplayCanvasLogic : MonoBehaviour
{
    // CoDA Prefab
    public GameObject ConfirmationBox;

    // Button Storage
    public Button rlButton;
    public Button htpButton;
    public Button lsButton;
    public Button mmButton;

    // Starts listening to determine source of CoDA
    private void OnEnable()
    {
        sEventManager.StartListening("Enable Buttons", EnableButtons);
        sEventManager.StartListening("Disable Buttons", DisableButtons);
    }

    // Stops all listening
    private void OnDisable()
    {
        sEventManager.StopListening("Enable Buttons", EnableButtons);
        sEventManager.StopListening("Disable Buttons", DisableButtons);
    }

    public void ResetLevel()
    {
        // Bring up CoDA to Reset level
        Instantiate(ConfirmationBox, new Vector3(0, 0, -20), Quaternion.identity);

        // Create "Reset Level" event - sConfirmationBoxLogic is listener
        sEventManager.TriggerEvent("Reset Level");
    }

    public void HTP()
    {
        // Instantiate the HTP canvas
    }

    public void LevelSelect()
    {
        // Bring up CoDA to Level Select scene
        Instantiate(ConfirmationBox, new Vector3(0, 0, -20), Quaternion.identity);

        // Create "Level Select" event - sConfirmationBoxLogic is listener
        sEventManager.TriggerEvent("Level Select");
    }

    public void MainMenu()
    {
        // Bring up CoDA to Main Menu scene
        Instantiate(ConfirmationBox, new Vector3(0, 0, -20), Quaternion.identity);

        // Create "Main Menu" event - sConfirmationBoxLogic is listener
        sEventManager.TriggerEvent("Main Menu");
    }

    private void EnableButtons()
    {
        rlButton.interactable = true;
        htpButton.interactable = true;
        lsButton.interactable = true;
        mmButton.interactable = true;
}

    private void DisableButtons()
    {
        rlButton.interactable = false;
        htpButton.interactable = false;
        lsButton.interactable = false;
        mmButton.interactable = false;
    }
}
