using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed;

    private JoystickController joystick;
    void Start()
    {
        joystick = FindObjectOfType<JoystickController>();
    }

    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        transform.position += new Vector3(joystick.direction.x, 0f, joystick.direction.y).normalized * movementSpeed * Time.deltaTime;
    }

}
