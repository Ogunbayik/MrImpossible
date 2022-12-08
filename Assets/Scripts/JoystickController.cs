using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickController : MonoBehaviour
{
    [SerializeField]
    private RectTransform circle;
    [SerializeField]
    private RectTransform knob;
    [SerializeField]
    private float radius;

    private Vector3 mousePosition;
    [HideInInspector]
    public Vector3 direction;
    void Start()
    {
        JoystickActivate(false);
    }

    void Update()
    {
        JoystickMovement();
    }

    private void JoystickMovement()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePosition = Input.mousePosition;

            circle.position = mousePosition;
            knob.position = mousePosition;

            JoystickActivate(true);
        }
        else if (Input.GetMouseButton(0))
        {
            knob.position = Input.mousePosition;
            direction = knob.position - circle.position;

            knob.position = circle.position + Vector3.ClampMagnitude(direction, circle.sizeDelta.y * radius);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            direction = Vector3.zero;
            JoystickActivate(false);
        }
    }

    private void JoystickActivate(bool activate)
    {
        knob.gameObject.SetActive(activate);
        circle.gameObject.SetActive(activate);
    }
}
