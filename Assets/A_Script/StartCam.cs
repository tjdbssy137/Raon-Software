using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCam : MonoBehaviour
{
    public GameObject cam;
    float time = 0;
    private Vector3 velocity = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        // 7.6, 8, -23
        cam.transform.position = new Vector3(7.6f, 8f, -25f);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 4f)
        {
            cam.GetComponent<CamMoving>().enabled = true;
            cam.transform.position = Vector3.SmoothDamp(cam.transform.position, new Vector3(-7.4f, 8f, -8.2f), ref velocity, 1.5f);
        }
    }
}
