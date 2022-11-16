using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverControl : MonoBehaviour
{
    public GameObject[] Levers;
    public GameObject[] Gravitys;
    bool tf = false;

    // Update is called once per frame
    void Update()
    {
        if(tf) LeversUP();
        if(!tf) LeversDown();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Crash"))
        {
            if (!tf) tf = true;
            else tf = false;
        }
    }

    private void LeversUP()
    {
        Levers[0].SetActive(true);
        Levers[1].SetActive(false);
       
        for (int i = 0; i < Gravitys.Length; i++)
        {
            Gravitys[i].GetComponent<FanControl>().enabled = true;
            Gravitys[i].GetComponent<Rigidbody>().useGravity = false;

        }
       
    }
    private void LeversDown()
    {
        Levers[1].SetActive(true);
        Levers[0].SetActive(false);
        for (int i = 0; i < Gravitys.Length; i++)
        {
            Gravitys[i].GetComponent<FanControl>().enabled = false;
            Gravitys[i].GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
