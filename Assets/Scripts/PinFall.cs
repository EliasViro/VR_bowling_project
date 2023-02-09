using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinFall : MonoBehaviour
{
    private bool fallen = false;
    void Update()
    {
        if ((transform.rotation.x > 0.40f  || transform.rotation.x < -0.40f || transform.rotation.z > 0.40f || transform.rotation.z < -0.40f) && fallen == false)
        {
            fallen = true;

            GameObject.Find("ScoreCanvas").GetComponent<ScoreManager>().IncreaseScore();
        }
    }
}
