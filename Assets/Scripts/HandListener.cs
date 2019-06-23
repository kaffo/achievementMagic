using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class HandListener : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*(if (handToTrack == null)
        {
            Debug.LogError(this.name + " on " + this.gameObject + " has not been setup correctly!");
            this.enabled = false;
            return;
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        if (SteamVR_Input.__actions_Default_in_MagicWindow.GetStateDown(SteamVR_Input_Sources.Any))
        {
            
        }
    }
}
