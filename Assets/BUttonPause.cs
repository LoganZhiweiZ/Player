using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BUttonPause : MonoBehaviour
{
    //the buttonPauseMenu
    public GameObject ingameMenu;

    public void OnPause()//�����Pause��ʱִ�д˷���
    {
        Time.timeScale = 0;
        ingameMenu.SetActive(true);
    }

    public void OnResume()//�����Resume��ʱִ�д˷���
    {
        Time.timeScale = 1f;
        ingameMenu.SetActive(false);
    }

    public void OnRestart()//�����restart��ʱִ�д˷���
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
