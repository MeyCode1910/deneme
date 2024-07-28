using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private FloatingJoystick joystick;
    private Vector3 Input;
    private Rigidbody Rb;

    private void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Input.x = joystick.Horizontal;
        Input.z = joystick.Vertical;
    }
    private void FixedUpdate()
    {
        Rb.MovePosition(transform.position+transform.TransformDirection(Input*speed*Time.fixedDeltaTime));
    }
}
