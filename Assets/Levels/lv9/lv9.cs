using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lv9 : MonoBehaviour
{
    public float timer;
    public GameObject wave2;
    public float w2time;
    public GameObject wave3;
    public float w3time;
    public GameObject wave4;
    public float w4time;

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
        if (timer > w4time)
        {
            wave4.gameObject.SetActive(true);
        }
    }
}
