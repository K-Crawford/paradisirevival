using UnityEngine;
using UnityEngine.SceneManagement;  // Allows us to change scenes

public class GrapefruitSceneChanger : MonoBehaviour
{

    public string SceneToGoTo;  // Should be assigned in the inspector
    
    private void OnTriggerEnter(Collider col) {
        print(col.gameObject.name);
        if (col.gameObject.CompareTag("Player")) {
            SceneManager.LoadScene(SceneToGoTo);
        }
    }

}
