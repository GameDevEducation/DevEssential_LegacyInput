using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputDemo1 : MonoBehaviour
{
    public KeyCode KeyToCheckFor = KeyCode.Space;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // check if any key or button was pressed
        if (Input.anyKeyDown)
        {
            Debug.Log("A key/mouse button was pressed this frame");
        }

        // GetKeyDown - returns true on the frame that key is pressed. will not return true again until the key is released and then pressed again
        if (Input.GetKeyDown(KeyToCheckFor))
        {
            Debug.Log("Space pressed");
        }

        // GetKeyUp - returns true on the frame that a key is released. will not return true again until the key is pressed and then released again
        if (Input.GetKeyUp(KeyToCheckFor))
        {
            Debug.Log("Space up");
        }

        // GetKey - returns true every frame that the key is pressed
        if (Input.GetKey(KeyToCheckFor))
        {
            Debug.Log("Space!");
        }

        // check the primary (0), seconary (1) and middle (2) mouse buttons
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse button 0");
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Mouse button 1");
        }
        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("Mouse button 2");
        }

        // read the mouse position and then normalise it so that -1,-1 is the bottom left, 0,0 is the middle of the screen and 1,1 is the top right
        Vector3 mousePosition = Input.mousePosition;
        Vector3 normalisedMousePosition = new Vector3(mousePosition.x / Screen.width, mousePosition.y / Screen.height, 0f) * 2f - new Vector3(1f, 1f, 0f);

        Debug.Log("Raw position: " + Input.mousePosition + " Normalised position: " + normalisedMousePosition);
    }
}
