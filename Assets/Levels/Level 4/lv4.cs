using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lv4 : MonoBehaviour
{
    public float timer;
    public GameObject wave2;
    public float w2time;
    public GameObject wave3;
    public float w3time;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > w2time)
        {
            wave2.gameObject.SetActive(true);
        }

        if (timer > w3time)
        {
            wave3.gameObject.SetActive(true);
        }
    }
}
