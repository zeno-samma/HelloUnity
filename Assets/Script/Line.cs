using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    //public float moveSpeed;
    float xDirection;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //xDirection = Input.GetAxisRaw("Horizontal");
        //float moveStep = moveSpeed * xDirection * Time.deltaTime;
        //Debug.Log(moveStep);
        //Debug.Log(transform.position);
        //transform.position = transform.position + new Vector3(moveStep, 0, 0);

        //float speed = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        //transform.Rotate(0, speed, 0);

        float moveSpeed = 10;
        //Define the speed at which the object moves.

        float horizontalInput = Input.GetAxis("Horizontal");
        //Get the value of the Horizontal input axis.

        //float verticalInput = Input.GetAxis("Vertical");
        //Get the value of the Vertical input axis.
        if ((transform.position.x <= -8f && horizontalInput < 0) || (transform.position.x >= 8f && horizontalInput > 0))
            return;
        transform.Translate(new Vector3(horizontalInput, 0, 0) * moveSpeed * Time.deltaTime);
        //Move the object to XYZ coordinates defined as horizontalInput, 0, and verticalInput respectively.
    }
}
