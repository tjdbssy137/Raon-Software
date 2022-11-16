using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public GameObject hour;
    public GameObject min;
    Vector3 VRxh, VRxm;

    // Update is called once per frame
    void Update()
    {
    if(GameObject.Find("SceneManagerObject").GetComponent<ChangeScene>().CanMove  == true)
        {

            VRxh = new Vector3(0, -30, 0);
            VRxm = new Vector3(0, -18, 0);

            min.transform.Rotate(VRxm * 0.02f);
            hour.transform.Rotate(VRxh * 0.002f);

        }
    }
}
