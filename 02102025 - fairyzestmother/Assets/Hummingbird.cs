using UnityEngine;

public class Flight : MonoBehaviour {
    public Transform Head;
    public Transform LeftHand;
    public Transform RightHand;
    public float speed = 0.5f; // the speed of the player
    void Update() {
    // Movement
        Quaternion rotation = Head.transform.rotation;
        // print(transform.position + " | " + rotation);
        Vector3 direction = rotation * Vector3.forward;
        Vector3 distance = LeftHand.transform.position - RightHand.transform.position;
        // print(distance.magnitude); // this determines the speed of the player
        speed = Mathf.Min(Mathf.Max(0.1f, distance.magnitude), 0.9f);
        transform.position += direction * speed * Time.deltaTime;
        // no actual collision detection (nevermind that)

    // Teleportation
        float xHalfSidelength = 4.5f;
        float yHalfSidelength = 4.5f;
        float zHalfSidelength = 4.5f;
        /*
        // teleportation when people try to leave the boundaries
        if (Mathf.Abs(transform.position.x) > xHalfSidelength) {
            transform.position = new Vector3(0, transform.position.y, transform.position.z);
        }
        if (Mathf.Abs(transform.position.y) > yHalfSidelength) {
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        }
        if (Mathf.Abs(transform.position.z) > zHalfSidelength) {
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        }
        */
        // random teleportation back into the boundaries to throw people off
        if ((Mathf.Abs(transform.position.x) > xHalfSidelength) || (Mathf.Abs(transform.position.y) > yHalfSidelength) || (Mathf.Abs(transform.position.z) > zHalfSidelength)) {
            float xValue = Random.Range(-4f, 4f);
            float yValue = Random.Range(-4f, 4f);
            float zValue = Random.Range(-4f, 4f);
            transform.position = new Vector3(xValue, yValue, zValue);
            print(transform.position);
        }
    }
}

/*
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;
using UnityEngine.InputSystem;
 
 
public class HummingbirdController : MonoBehaviour
{
    public InputActionReference customToggleReference;
    private InputAction toggleReference;
    public Transform leftHand;
    public Transform head;
    public float flyingSpeed;
    private bool isFlying;
    private bool hasAlreadyBeenTriggered;


    private void Start()
    {
        toggleReference = customToggleReference.action;
        toggleReference.started += ToggleJetpackAction;
        toggleReference.canceled += ToggleJetpackAction;
        toggleReference.Enable();
    }
 
 
    private void Update()
    {
        if (toggleReference.ReadValue<float>() > 0f)
        {
            Thrust();
        }
    }
 
 
    private void ToggleJetpackAction(InputAction.CallbackContext context)
    {
        if (!hasAlreadyBeenTriggered)
        {
            hasAlreadyBeenTriggered = true;
            isFlying = !isFlying;
        }
    }
 
 
    private void Thrust()
    {
        if (isFlying && Globals.Nectar > 0)
        {
            Vector3 flyDirection = leftHand.transform.position - head.transform.position;
            RaycastHit hit;
            if (Physics.Raycast(head.position, flyDirection, out hit, flyingSpeed * Time.deltaTime, LayerMask.NameToLayer("Floor")) && hit.transform.CompareTag("Floor")
    || Physics.Raycast(leftHand.position, flyDirection, out hit, flyingSpeed * Time.deltaTime, LayerMask.NameToLayer("Floor")) && hit.transform.CompareTag("Floor"))
            {
                return;
            }
            transform.position += flyDirection.normalized * Time.deltaTime * flyingSpeed;
        }
    }
 
}
*/