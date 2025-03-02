using UnityEngine;

public class Injure : MonoBehaviour
{
    public AudioSource crash;
    public int nectar;
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("tissue")) {
            crash.Play(); // ow
            nectar -= 5; // heal
        }
    }
}
