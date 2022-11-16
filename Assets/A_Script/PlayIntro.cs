using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayIntro : MonoBehaviour
{
    public GameObject bg;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("getOff", 14.5f);
    }

    public void getOff()
    {
        bg.SetActive(false);
    }
}
