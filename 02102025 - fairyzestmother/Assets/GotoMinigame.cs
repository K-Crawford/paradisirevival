using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoMinigame : MonoBehaviour
{
    void Start() {
        print("self" + gameObject.name);
    }

    void Update() {
        Debug.Log("Objectdetecting");
    }

    void OnCollisionEnter(Collision collision) {
        print(collision.gameObject.name);
        print(collision.gameObject.tag);
        if (collision.gameObject.CompareTag("grapefruit")) {
            SceneManager.LoadScene("minigame");
        }
    }
    // unnecessary
    private void OnTriggerEnter(Collider other)
    {
        print("maybe" + other.tag);
        if (other.tag == "grapefruit")
        {
            Debug.Log("Triggered by Enemy");
        }
    }
}
