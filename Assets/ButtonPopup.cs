﻿using UnityEngine;
using System.Collections;
using Vuforia;
using UnityEngine.SceneManagement;

public class ButtonPopup : MonoBehaviour, ITrackableEventHandler
{

    private TrackableBehaviour mTrackableBehaviour;

    private bool mShowGUIButton = false;
    private Rect mButtonRect = new Rect(50,50,200,100); 

    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if(mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED)
        {
            mShowGUIButton = true;
        }
        else
        {
            mShowGUIButton = false;
        }
    }

    void OnGUI()
    {
        if (mShowGUIButton)
        {
            // draw the GUI button
            if (GUI.Button(mButtonRect, "Info"))
            {
                SceneManager.LoadScene("TextScene");


                    // do something on button click 
            }
        }
    }
}