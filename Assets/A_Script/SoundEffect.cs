using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    public AudioClip[] source;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject)
        {
            if (source.Length >= 2)
            {
                int temp = Random.Range(0, 2);
                switch (temp)
                {
                    case 0:
                        audioSource.clip = source[0];
                        break;
                    case 1:
                        audioSource.clip = source[1];
                        break;
                }
            }
            else
            {
                audioSource.clip = source[0];
            }
            audioSource.Play();
        }
    }
}
