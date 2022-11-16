using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverMove : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Hover;
    bool startH = true;
    bool UpDown = true;
    float[] Size = { 0.002f, 0.005f, 0.003f};

    private void Update()
    {
        if(GameObject.Find("SceneManagerObject").GetComponent<ChangeScene>().CanMove == true) 
        {
            if (startH)
            {
                Invoke("startHF", 11);
                moveR(Hover[0], 5);
                moveR(Hover[1], 8);
                moveF(Hover[2], 10);
            }
            if (!startH)
            {
                Invoke("startHT", 11);
                moveL(Hover[0], 5);
                moveL(Hover[1], 8);
                moveB(Hover[2], 10);
            }
            if (UpDown)
            {
                Invoke("UpDownF", 2);
                HoverUp();
            }
            if (!UpDown)
            {
                Invoke("UpDownT", 2);
                HoverDown();
            }
        }
    }
    void startHF()
    {
        startH = false;
    }
    void startHT()
    {
        startH = true;
    }
    void moveL(GameObject GO, float Speed)
    {
        GO.transform.Translate(Vector3.left * Speed * Time.deltaTime);
    }
    void moveR(GameObject GO, float Speed)
    {
        GO.transform.Translate(Vector3.right * Speed * Time.deltaTime);
    }
    void moveF(GameObject GO, float Speed)
    {
        GO.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }
    void moveB(GameObject GO, float Speed)
    {
        GO.transform.Translate(Vector3.back * Speed * Time.deltaTime);
    }

    void HoverUp()
    {
        for (int i = 0; i < Hover.Length; i++)
        {
            if(i%2 != 0)
            {
                Hover[i].transform.position += new Vector3(0, Size[i], 0);

            }
            else Hover[i].transform.position -= new Vector3(0, Size[i], 0);
        }
    }

    void HoverDown()
    {
        for (int i = 0; i < Hover.Length; i++)
        {
            if (i % 2 != 0)
            {
                Hover[i].transform.position -= new Vector3(0, Size[i], 0);

            }
            else Hover[i].transform.position += new Vector3(0, Size[i], 0);
        }
    }
    void UpDownF()
    {
        UpDown = false;
    }
    void UpDownT()
    {
        UpDown = true;
    }
}
