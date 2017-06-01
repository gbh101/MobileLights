using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sMainMenuLogic : MonoBehaviour
{
    // CoDA Prefab
    public GameObject ConfirmationBox;

    public void PlayGame()
    {
        SceneManager.LoadScene("BlankScene");
        // Load play space
    }

    public void HowToPlay()
    {
        // Load HTP Screen
    }

    public void QuitGame()
    {
        // Creates a CoDA dialog box from prefab
        Instantiate(ConfirmationBox, new Vector3(0,0,-20), Quaternion.identity);
    }
}
