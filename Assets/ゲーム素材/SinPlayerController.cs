
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SinPlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.RightArrow))
        {


            transform.Translate(0, 0.03f, 0);


        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(0, -0.03f, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(-0.03f, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0.03f, 0, 0);
        }
    }
}
