using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brokeParticle : MonoBehaviour
{
    public GameObject[] prefab;
    GameObject bomb;
    public AudioClip walls;
    public AudioClip walls2;
    public AudioClip parcel;
    bool activeAudio = true;
    AudioSource audioSource;
    float time = 0;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (!activeAudio)
        {
            time += Time.deltaTime;
            if (time > 2.0f)
            {
                activeAudio = true;
                time = 0;
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("wall"))
        {
            if (activeAudio)
            {
                int temp = Random.Range(0, 2);
                switch (temp)
                {
                    case 0:
                        audioSource.clip = walls;
                        break;
                    case 1:
                        audioSource.clip = walls2;
                        break;
                }
                activeAudio = false;
            }
        }
        if (other.gameObject.CompareTag("Parcel")) audioSource.clip = parcel;
        audioSource.Play();

        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(bomb);
            return;
        }
        else{
            int temp = Random.Range(0, 10);

            switch (temp)
            {
                case 0:
                    bomb = Instantiate(prefab[0], transform.position, transform.rotation);
                    break;
                case 1:
                    bomb = Instantiate(prefab[1], transform.position, transform.rotation);
                    break;
                case 2:
                    bomb = Instantiate(prefab[2], transform.position, transform.rotation);
                    break;
            }
            Destroy(bomb, 1.4f);
        }
        if (other.gameObject.CompareTag("ball"))
        {
            bomb = Instantiate(prefab[3], transform.position, transform.rotation);
        }
        Destroy(bomb, 1.4f);

    }

}
