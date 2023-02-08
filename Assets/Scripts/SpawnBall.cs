using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject ball;
    public GameObject ballSpawn;

    private void Awake()
    {
        SpawnOneBall();
    }

    public void SpawnOneBall()
    {
        Instantiate(ball, ballSpawn.transform);
    }
}
