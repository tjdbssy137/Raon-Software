using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public GameObject[] Cube;
    bool startC = true;

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("SceneManagerObject").GetComponent<ChangeScene>().CanMove == true)
        {
            if (startC)
            {
                Invoke("startCF", 2);
                CubeUp();
            }
            if (!startC)
            {
                Invoke("startCT", 2);
                CubeDown();
            }
        }
    }

    void startCF()
    {
        startC = false;
    }
    void startCT()
    {
        startC = true;
    }

    void CubeUp()
    {
        for (int i = 0; i < Cube.Length; i++)
        {
            if(i%2 != 0)
            {
                Cube[i].transform.position += new Vector3(0, 0.0003f, 0);
            }
            else Cube[i].transform.position -= new Vector3(0, 0.0003f, 0);
        }
    }

    void CubeDown()
    {
        for (int i = 0; i < Cube.Length; i++)
        {
            if (i % 2 != 0)
            {
                Cube[i].transform.position -= new Vector3(0, 0.0003f, 0);
            }
            else Cube[i].transform.position += new Vector3(0, 0.0003f, 0);
        }
    }
}
