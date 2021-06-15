using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputDemo2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // while the Jump input is pressed output the value of horizontal and vertical axes
        if (Input.GetButton("Jump"))
        {
            Debug.Log(Input.GetAxis("Horizontal") + ", " + Input.GetAxis("Vertical"));
        }

        Debug.Log("Mouse: " + Input.GetAxis("Mouse X") + ", " + Input.GetAxis("Mouse Y") + ", " + Input.GetAxis("Mouse ScrollWheel"));

        // demonstrate what happens if the axis or button doesn't exist
        // if (Input.GetButton("ThingThatDoesNotExist"))
        // {

        // }
    }
}
