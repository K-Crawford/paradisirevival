using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderHell : MonoBehaviour
{
    /*
    void OnCollisionEnter(Collision collision) {
        print(collision.gameObject.name);
        print(collision.gameObject.tag);
        if (collision.gameObject.CompareTag("Player")) {
            SceneManager.LoadScene("main");
        }
    }
    */

    void Start() {
        print("self" + gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        print("collide" + other.name);
        print("collide" + other.tag);
        //if (other.gameObject.CompareTag("fairy")) {
            SceneManager.LoadScene("minigame");
        //}
    }
}
