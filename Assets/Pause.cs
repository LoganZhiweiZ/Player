using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public bool movePause;
    // Start is called before the first frame update
    void Start()
    {
        movePause = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && movePause == false)
        {
            Time.timeScale = 0;
            movePause = true;
        }
        else if(Input.GetKeyDown(KeyCode.Tab) && movePause == true)
        {
            Time.timeScale = 1;
            movePause = false;
        }
    }
}
