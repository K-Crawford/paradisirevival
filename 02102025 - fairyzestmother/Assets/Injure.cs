using UnityEngine;
using TMPro;

public class Injure : MonoBehaviour
{
    public AudioSource Crash;

    public static int Nectar;
    public TextMeshProUGUI NectarStored;

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("tissue")) {
            Crash.Play(); // ow
            Nectar -= 5; // heal
            NectarStored.text = "Seeds Collected: " + Nectar.ToString();
        }
    }
}
