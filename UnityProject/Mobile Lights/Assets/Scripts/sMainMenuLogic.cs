using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.UI;

public class sMainMenuLogic : MonoBehaviour
{
    // CoDA Prefab
    public GameObject ConfirmationBox;
    
    // Button Storage
    public Button pgButton;
    public Button htpButton;
    public Button lsButton;
    public Button qgButton;

    public void PlayGame()
    {
        SceneManager.LoadScene("BlankScene");
        // Load play space
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void HowToPlay()
    {
        Debug.Log("This is how you play");
        // Load HTP Screen
    }

    public void QuitGame()
    {
        // Creates a CoDA dialog box from prefab
        Instantiate(ConfirmationBox, new Vector3(0,0,-20), Quaternion.identity);

        // Create Quit Game Event - sConfirmationBoxLogic is listener
        sEventManager.TriggerEvent("Quit Game");
    }

    private void EnableButtons()
    {
        pgButton.interactable = true;
        htpButton.interactable = true;
        lsButton.interactable = true;
        qgButton.interactable = true;
    }

    private void DisableButtons()
    {
        pgButton.interactable = false;
        htpButton.interactable = false;
        lsButton.interactable = false;
        qgButton.interactable = false;
    }
}
