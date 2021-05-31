using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class game : MonoBehaviour
{
    public float time;
    public Text timertext;
    public GameObject win;

    public void Start()
    {
        Time.timeScale = 1;
    }

    private void FixedUpdate()
    {
        //time -= time.deltaTime;
        timertext.text = time.ToString();
    }

    void Update()
    {
        if (time > 0) //when time is greater than
        {
            time -= Time.deltaTime;
        }
        if (time < 0) //when time is less than
        {
            Time.timeScale = 0;
                win.gameObject.SetActive(true); //displays win screen
        }
    }
}
