using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanControl : MonoBehaviour
{
    private float windy_Y = 0.0f;
    private float windy_Z = 0.0f;
    private float easy = 0.015f;
    // Start is called before the first frame update
    void Start()
    {
        WindPower();
    }

    // Update is called once per frame
    void Update()
    {
        Wind();
        Invoke("WindPower", 2);
    }
    public void WindPower()
    {
        windy_Y = Random.Range(-30.0f, 30.0f);
        windy_Z = Random.Range(-70.0f, 70.0f);
    }
    public void Wind()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(0, windy_Y * easy, windy_Z * easy));
    }
}
