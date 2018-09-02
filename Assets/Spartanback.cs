﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class Spartanback : MonoBehaviour
{


    private bool mShowGUIButton = true;
    private Rect mButtonRect = new Rect(50, 380,200,100);

    void OnGUI()
    {
        if (mShowGUIButton)
        {
            // draw the GUI button
            if (GUI.Button(mButtonRect, "Back"))
            {
                SceneManager.LoadScene("ar2");


                // do something on button click 
            }
        }
    }
}
