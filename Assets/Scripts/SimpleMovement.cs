using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public float MoveSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // work out the movement (speed not the distance this frame) based on the input
        Vector3 moveInput = MoveSpeed * (Input.GetAxis("Horizontal") * transform.right + Input.GetAxis("Vertical") * transform.forward);

        // move the character
        transform.position += moveInput * Time.deltaTime;
    }
}
