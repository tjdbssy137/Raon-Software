using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoxRole : MonoBehaviour
{
    public GameObject Box_1;
    public GameObject Parcel;
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Parcel"))
        {
            Box_1.SetActive(false);
            Parcel.SetActive(true);
            Player.GetComponent<PlayerMove>().enabled = false;
            GameObject.Find("forearm(Right)").GetComponent<Animator>().enabled = true;
            this.GetComponent<SphereCollider>().enabled = false;
            GameObject.Find("SceneManagerObject").GetComponent<EndAnimation>().enabled = true;
        }
    }
}