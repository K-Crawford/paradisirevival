using UnityEngine;
using TMPro;

public class PickSeed : MonoBehaviour
{
    // public TextMeshProUGUI CollectedSeeds;

    public int CollectedSeeds;
    public TextMeshProUGUI SeedsText;

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
        CollectedSeeds += 1;
        gameObject.SetActive(false);
        // SeedsText.text = CollectedSeeds.ToString();
    }

}
