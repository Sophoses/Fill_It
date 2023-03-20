using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkAnim : MonoBehaviour
{
    float time;
    private Text text;
    public GameObject blinkText;

    void Start()
    {
        text = blinkText.GetComponent<Text>();
    }


    void Update()
    {
        if(time < 0.5f)
        {
            text.color = new Color(1.0f, 0.0f, 0.0f, 1 - time);
        }
        else
        {
            text.color = new Color(1.0f, 0.0f, 0.0f, time);
            {
                if(time > 1f)
                {
                    time = 0;
                }
            }
        }
        time += Time.deltaTime;
    }
}
