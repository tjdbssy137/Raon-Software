using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public GameObject useScene;
    public GameObject titleScene;
    public bool CanMove = true;
    public void GoTITLE()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Title");
    }
    public void GoMain()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene("Main");
    }
    public void LoadTitle()
    {
        titleScene.SetActive(true);
        useScene.SetActive(false);
    }
    public void LoadQPage()
    {
        titleScene.SetActive(false);
        useScene.SetActive(true);
    }
    public void BackGame()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        useScene.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Cursor.lockState = CursorLockMode.None;
            useScene.SetActive(true);
            Time.timeScale = 0;
            GameObject.Find("Player3_2").GetComponent<PlayerMove>().enabled = false;
            CanMove = false;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Cursor.lockState = CursorLockMode.Locked;
            SceneManager.LoadScene("Main");
            Time.timeScale = 1;
        }
        if (Time.timeScale == 1)
        {
            CanMove = true;
            GameObject.Find("Player3_2").GetComponent<PlayerMove>().enabled = true;
        }
    }
}
