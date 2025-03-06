using UnityEngine;
using UnityEngine.SceneManagement;

public class ShiftScene : MonoBehaviour
{

    [Header("Grapefruit Radius Assignment")]
    public float GrapefruitRadius;
    
    void ChangeSceneTo(string name) {
        SceneManager.LoadScene(name);
    }

    float CalcDistToPlayer() {
        return Vector3.Distance(transform.position, Camera.main.transform.position);
    }

    void Update() {
        // Debug.Log(CalcDistToPlayer());
        if (CalcDistToPlayer() > 4.9) {
            ChangeSceneTo("main");
        }
    }

    /*
    void OnDrawGizmos() {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, GrapefruitRadius);
    }
    */
}
