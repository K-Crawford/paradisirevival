using UnityEngine;
using TMPro;

public class CollectSeeds : MonoBehaviour
{
    // public TextMeshProUGUI CollectedSeeds;

    // void OnTriggerEnter(Collider collision){
    //     if (collision.gameObject.name == "Seed") {
    //         // CollectedSeeds += 1;
    //         gameObject.SetActive(false);
    //     }
    // }

    // <summary>
    // Should be called when the player grabs onto the seed
    // using the grip button.
    // </summary>
    public void OnGrabSeed() {
        Globals.CollectedSeeds += 1;
        gameObject.SetActive(false);
    }

}
