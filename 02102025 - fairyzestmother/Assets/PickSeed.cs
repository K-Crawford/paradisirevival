using UnityEngine;

public class PickSeed : MonoBehaviour
{
    // public TextMeshProUGUI CollectedSeeds;

    void OnTriggerEnter(Collider collision){
        if (collision.gameObject.name == "Seed") {
            // CollectedSeeds += 1;
            gameObject.SetActive(false);
        }
    }
}
