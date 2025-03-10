using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class Injure : MonoBehaviour
{
    public AudioSource Crash;

    public TextMeshProUGUI CoolDown;

    public TextMeshProUGUI SeedsCollected;

    public TextMeshProUGUI NectarStored;

    void NoNectar() {
        // how to stop all movement (orz)
        print("napping (actually unconscious)");
    }

    void Update() {
        if (Globals.Nectar < 0) {
            /*
            string progress = SeedsCollected.text;
            SeedsCollected.text = "";
            NectarStored.text = "";
            */
            CoolDown.text = "waiting for nectar from Hummingbird";
            // Globals.Nectar = 1200;
            // this does not work
            /*
            Invoke("NoNectar", 50);
            Globals.Nectar = 50000;
            CoolDown.text = "";
            SeedsCollected.text = progress;
            NectarStored.text = "Globals.Nectar: 50000 / 100000";
            */
        } else {
            CoolDown.text = "";
            Globals.Nectar += (int)(10 * Time.deltaTime);
            // Globals.Nectar -= 1;
        }
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("tissue")) {
            Crash.Play(); // ow
            Globals.Nectar -= 50; // heal
            NectarStored.text = "Globals.Nectar: " + Globals.Nectar.ToString() + " / 100000";
        }
    }
}
