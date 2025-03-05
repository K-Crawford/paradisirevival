using UnityEngine;
using TMPro;

public class SeedCountUpdater : MonoBehaviour
{
    
    private TextMeshProUGUI MyText;

    // At the start of the game, gets the text component,
    // stores it in `myText`
    void Awake() {
        MyText = GetComponent<TextMeshProUGUI>();
    }

    void Start() {
        UpdateSeedCount();
        Globals.OnSeedCollected += UpdateSeedCount;  // Subscribing to the event
    }

    void UpdateSeedCount() {
        MyText.text = "Seeds Collected: " + Globals.CollectedSeeds.ToString() + " / " + FruitInsides.SeedNumber;
    }

}
