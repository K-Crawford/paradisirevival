using UnityEngine;

public class ClimbAlong : MonoBehaviour
{

    // using the grip buttons to climb
    // https://www.youtube.com/watch?v=1JZ62Us3RI0

}

/*
Some ChatGPT code that does not work at all

using UnityEngine;

public class PlayerContact : MonoBehaviour
{
    private Rigidbody rb;
    public Transform objectToStayInContactWith;
    
    private Vector3 lastVelocity;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("Player does not have a Rigidbody attached.");
        }
    }

    private void FixedUpdate()
    {
        // Update the last velocity before physics step
        lastVelocity = rb.velocity;

        // If the player is in contact with the object, maintain contact logic
        if (objectToStayInContactWith != null)
        {
            Vector3 directionToObject = objectToStayInContactWith.position - transform.position;

            // Ensure that the player stays close to the object by adjusting position
            // You can modify the distance threshold to adjust the "contact" distance
            if (directionToObject.magnitude > 0.1f)
            {
                // Move the player towards the object while maintaining velocity
                Vector3 contactPosition = objectToStayInContactWith.position - directionToObject.normalized * 0.1f;
                transform.position = contactPosition;
            }
        }

        // Apply the player's velocity to maintain movement while staying in contact with the object
        rb.velocity = lastVelocity;
    }

    private void OnCollisionStay(Collision other)
    {
        // Ensure player stays in contact with the object only
        if (other.gameObject.CompareTag("ContactObject"))
        {
            // When in contact, set the objectToStayInContactWith to this object
            objectToStayInContactWith = other.transform;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        // If the player exits contact with the object, clear the reference
        if (other.gameObject.CompareTag("ContactObject"))
        {
            objectToStayInContactWith = null;
        }
    }
}
*/