using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BUttonPause : MonoBehaviour
{
    //the buttonPauseMenu
    public GameObject ingameMenu;

    public void OnPause()//点击“Pause”时执行此方法
    {
        Time.timeScale = 0;
        ingameMenu.SetActive(true);
    }

    public void OnResume()//点击“Resume”时执行此方法
    {
        Time.timeScale = 1f;
        ingameMenu.SetActive(false);
    }

    public void OnRestart()//点击“restart”时执行此方法
    {
        //Loading Scene0
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
