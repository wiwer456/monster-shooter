using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadContr : MonoBehaviour
{
     //повороты головой и телом по мышке
    public Transform playerBody;
    float xRotation = 0f;
    void Start()
    {
        
    }


    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * 2f;
        float mouseY = Input.GetAxis("Mouse Y");

        playerBody.Rotate(0, mouseX, 0);
        xRotation -= mouseY;
        transform.localRotation = Quaternion.Euler(xRotation,0,0);

    }
}
