using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPins : MonoBehaviour
{
    public GameObject pin;
    public GameObject scoreManager;
    public GameObject pinSpawn1;
    public GameObject pinSpawn2;
    public GameObject pinSpawn3;
    public GameObject pinSpawn4;
    public GameObject pinSpawn5;
    public GameObject pinSpawn6;
    public GameObject pinSpawn7;
    public GameObject pinSpawn8;
    public GameObject pinSpawn9;
    public GameObject pinSpawn10;

    private void Awake()
    {
        SpawnTenPins();
    }

    public void DestroyPins()
    {
        GameObject[] pins = GameObject.FindGameObjectsWithTag("Pin");
        foreach (GameObject pin in pins)
        {
            Destroy(pin);
        }
    }

    public void SpawnTenPins()
    {
        DestroyPins();
        scoreManager.GetComponent<ScoreManager>().WipeScore();
        Instantiate(pin, pinSpawn1.transform);
        Instantiate(pin, pinSpawn2.transform);
        Instantiate(pin, pinSpawn3.transform);
        Instantiate(pin, pinSpawn4.transform);
        Instantiate(pin, pinSpawn5.transform);
        Instantiate(pin, pinSpawn6.transform);
        Instantiate(pin, pinSpawn7.transform);
        Instantiate(pin, pinSpawn8.transform);
        Instantiate(pin, pinSpawn9.transform);
        Instantiate(pin, pinSpawn10.transform);
    }
}
