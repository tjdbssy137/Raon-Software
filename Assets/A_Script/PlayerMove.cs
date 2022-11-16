using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject forearm;
    public GameObject arm;
    public GameObject hand;

    private int Next = 0;
    private Vector3 V3, headPosVec;
    private float turnspeed = 7f;

    public GameObject[] Heads;
    float delayTime = 0;
    float PosY = 0;

    // Update is called once per frame
    void Update()
    {
        MoveArm();
        MoveHead();
        delayTime += Time.deltaTime;
        if(delayTime >= 2)
        {
            HeadChangeClose();
        }if(delayTime >= 2.5f)
        {
            HeadChangeOpen();
            delayTime = 0;
        }
    }

    private void MoveHead()
    {
        PosY = Input.GetAxis("Mouse X");
        headPosVec = new Vector3(0, PosY, 0);
        float hpr = Heads[2].transform.rotation.eulerAngles.y;
        Heads[2].transform.Rotate(headPosVec * 0.7f);
    }
    private void MoveArm()
    {
        V3 = new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0);
        if (Input.GetMouseButtonDown(0)) //if (Input.GetKeyDown(KeyCode.Space))
        {
            Next++;
            if (Next > 3) Next = 1;
        }
        switch (Next)
        {
            case 1:
                forearm.transform.Rotate(V3 * turnspeed);
                break;
            case 2:
                arm.transform.Rotate(V3 * turnspeed);
                break;
            case 3:
                V3 = new Vector3(0, Input.GetAxis("Mouse Y"), 0);
                hand.transform.Rotate(V3 * turnspeed);
                break;
        }
    }

    private void HeadChangeOpen()
    {
        Heads[0].SetActive(true);
        Heads[1].SetActive(false);
    }
    private void HeadChangeClose()
    {
        Heads[1].SetActive(true);
        Heads[0].SetActive(false);
    }
}
