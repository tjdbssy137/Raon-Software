using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleCamMove : MonoBehaviour
{

    public GameObject cam;
    private Vector3 velocity = Vector3.zero;
    bool turnB = true;

    // Update is called once per frame
    void Update()
    {
        //-10.3 ~ 6.5
        if(turnB)
        {
            cam.transform.position = Vector3.SmoothDamp(cam.transform.position, new Vector3(6.5f, 9f, -7.7f), ref velocity, 2.5f);
            if(cam.transform.position.x > 6.4f) turnB = false;
        }

        else if (!turnB)
        {
            cam.transform.position = Vector3.SmoothDamp(cam.transform.position, new Vector3(-10.3f, 9f, -7.7f), ref velocity, 2.5f);
            if(cam.transform.position.x < -10.25f) turnB = true;
        }
    }
}
