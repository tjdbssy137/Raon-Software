using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndAnimation : MonoBehaviour
{
    public GameObject ToolArm;
    public GameObject Parcell;
    public GameObject LeftArm;

    float time = 0;
    void Update()
    {
        time += Time.deltaTime;
        if(time>2) 
            GameObject.Find("Main Camera").GetComponent<Animator>().enabled = true;

        if (time > 4)
        {
            ToolArm.SetActive(false);
            LeftArm.SetActive(true);
            Parcell.SetActive(false);
        }
    }
}
