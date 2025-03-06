using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoMinigame : MonoBehaviour
{
    void Start() {
        print("self" + gameObject.name);
    }

    // void Update() {
    //    Debug.Log("Objectdetecting");
    // }

    private void OnTriggerEnter(Collider other) {
        print("maybe" + other.tag);
        if (other.tag == "grapefruit") {
             SceneManager.LoadScene("minigame");

        }
    }
}
