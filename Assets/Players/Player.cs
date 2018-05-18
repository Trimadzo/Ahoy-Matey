using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;

public class Player : NetworkBehaviour {

    private Vector3 inputValue;
    public float speedScaling = 0.5f;
	
	void Update () {

        if (!isLocalPlayer)
        {
            return;
        }

        inputValue.x = CrossPlatformInputManager.GetAxis("Horizontal") * speedScaling;
        inputValue.y = 0f;
        inputValue.z = CrossPlatformInputManager.GetAxis("Vertical") * speedScaling;

        transform.Translate(inputValue);
    }
}
