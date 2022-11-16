using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public Light light0;
    public GameObject Parcel;
    float spotAngle = 0;
    float time = 0;

    // Start is called before the first frame update
    private void Start()
    {
        Parcel.SetActive(false);
        Invoke("ParcelDrive", 1.6f);
        Invoke("offLight", 3f);
    }
    private void Update()
    {
        time += Time.deltaTime;
        if (time < 1f) {
            light0.spotAngle += (time / 3f);
        }
    }

    private void ParcelDrive()
    {
        Parcel.SetActive(true);
    }
    public void offLight()
    {
        light0.enabled = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
