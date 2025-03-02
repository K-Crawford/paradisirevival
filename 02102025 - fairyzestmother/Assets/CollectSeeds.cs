using UnityEngine;
using TMPro;

public class CollectSeeds : MonoBehaviour
{
    // public TextMeshProUGUI CollectedSeeds;

    public int CollectedSeeds;
    public TextMeshProUGUI SeedCount;

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
        SeedCount.text = "Seeds Collected: " + CollectedSeeds.ToString() + " / " + FruitInsides.SeedNumber;
    }

}
