using UnityEngine;

public class FruitInsides : MonoBehaviour
{

    public GameObject tissue;
    public GameObject seed;

    void Start()
    {
        // generate random supporting tissues
        int TissueNum = 5;
        for (int cnt = 0; cnt < TissueNum; cnt++) {
            float x = Random.Range(-4f, 4f);
            float y = Random.Range(-4f, 4f);
            float z = Random.Range(-4f, 4f);
            Vector3 position = new Vector3(x, y, z);
            Quaternion orientation = Random.rotation;
            Instantiate(tissue, position, orientation);
        }
        
        // generate seeds on tissues
        int SeedNum = 2;
        for (int cnt = 0; cnt < SeedNum; cnt++) {
            float x = Random.Range(-4f, 4f);
            float y = Random.Range(-4f, 4f);
            float z = Random.Range(-4f, 4f);
            Vector3 position = new Vector3(x, y, z);
            Quaternion orientation = Random.rotation;
            Instantiate(tissue, position, orientation);
            Instantiate(seed, position, orientation);
        }
    }
}
