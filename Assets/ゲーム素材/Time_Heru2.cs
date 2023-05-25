
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeHeru2 : MonoBehaviour
{
    GameObject Time_gauge;
    // Start is called before the first frame update
    void Start()
    {
        this.Time_gauge = GameObject.Find("Time_gauge");

    }

    // Update is called once per frame
    void Update()
    {
        DecreaseTime();
    }
    public void DecreaseTime()
    {
        this.Time_gauge.GetComponent<Image>().fillAmount -= 1f;
       
    }
}
