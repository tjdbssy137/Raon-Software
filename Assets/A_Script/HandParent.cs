using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandParent : MonoBehaviour
{
    public GameObject tool;
    public GameObject Crashtool;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("tool"))
        {
            //Debug.Log("Ãæµ¹");
            //other.transform.parent = this.gameObject.transform;
            Destroy(tool);
            Crashtool.SetActive(true);
        }
    }
}
