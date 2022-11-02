using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPLook : MonoBehaviour
{
    float speedX = 10f;
    float speedY = 10f;
    float minY = -60;
    float maxY = 60;

    float rotationX;
    float rotationY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotationX += Input.GetAxis("Mouse X") * speedX;
        rotationY += Input.GetAxis("Mouse Y") * speedY;
        if (rotationX < 0){
            rotationX += 360;
        }
        if (rotationX > 360)
        {
            rotationX -= 360;
        }
        rotationY = Mathf.Clamp(rotationY, minY, maxY);
        transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
    }

}
