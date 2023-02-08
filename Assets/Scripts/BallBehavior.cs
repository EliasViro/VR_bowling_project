using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    public Material mat1;
    public Material mat2;
    public Material mat3;

    private void Awake()
    {
        int rand = Random.Range(1, 4);
        if (rand == 1)
        {
            gameObject.GetComponent<MeshRenderer>().material = mat1;
        }
        else if (rand == 2)
        {
            gameObject.GetComponent<MeshRenderer>().material = mat2;
        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().material = mat3;
        }
    }

    private void Update()
    {
        if (transform.position.y < -10)
        {
            GameObject.Find("Ballspawn").GetComponent<SpawnBall>().SpawnOneBall();
            Destroy(this);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Foul"))
        {
            GameObject.Find("Ballspawn").GetComponent<SpawnBall>().SpawnOneBall();
            Destroy(gameObject);
        }
    }
}
