using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sGameplayLogic : MonoBehaviour
{
    private int iNumberOfLights = 0;
    private int iNumberLitUp = 0;

    private int iNumberOfClicks = 0;
        
	void Awake ()
    {
        // Loop through all existing lights\
        //{
            // iNumberOfLights += 1;
            
            // if(a light is on by default)
            //{
                // iNumberLitUp += 1;
                // i++;
            //}
        //}
	}

    private void LightOn()
    {
        // iNumberLitUp += 1;
        // Change display on UI

        // if(iNumberLitUp == iNumberOfLights)
            //{
                // Spawn victory image
            //}
    }

    private void LightOff()
    {
        // iNumberLitUp -= 1;
        // Change display on UI
    }

    private void Click()
    {
        // iNumberOfClicks += 1;
    }
}
