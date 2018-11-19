using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (Camera.main.fieldOfView <= 90)
                Camera.main.fieldOfView += 2;
        }
        
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (Camera.main.fieldOfView > 10)
                Camera.main.fieldOfView -= 2;
        }
	}
}
