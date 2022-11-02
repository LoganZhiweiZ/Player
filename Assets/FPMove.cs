using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPMove : MonoBehaviour
{
    float speed = 5f;
    private CharacterController characterController;
    // Start is called before the first frame update
    void Start()
    {
        characterController = this.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        Vector3 movement = new Vector3(x, 0, z);
        movement = transform.TransformDirection(movement);

        Vector3 newMovement = new Vector3(movement.x, 0, movement.z);
        characterController.Move(newMovement);
    }
}
