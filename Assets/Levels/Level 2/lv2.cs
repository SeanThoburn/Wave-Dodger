using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lv2 : MonoBehaviour
{
    public float timer;
    public GameObject wave2;
    public float w2time;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > w2time)
        {
            wave2.gameObject.SetActive(true);
        }
    }
}
