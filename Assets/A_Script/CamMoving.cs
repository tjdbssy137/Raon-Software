using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMoving : MonoBehaviour
{
    float Speed = 10.0f;
    float distance = -5.0f;
    float SmoothTime = 0.2f;
    float time = 0;
    public GameObject sc;

    private Vector3 velocity = Vector3.zero;
    private float wheelspeed = 9.0f;

    Vector3 current;
    
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 3.5f)
        {
            sc.GetComponent<StartCam>().enabled = false;
            GetComponent<AudioSource>().enabled = true;
        }
        CMove();
        current = transform.position;
        Zoom();
    }
    private void CMove()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
        }
        //-8.8~5.5
    }
    private void Zoom()
    {
        distance += Input.GetAxis("Mouse ScrollWheel") * wheelspeed;
        
        if(current.x > 4.2f && current.x < 8.1f)
        {
            if (distance < -28.0f) distance = -28.0f;//이게 뒤로 감
            if (distance > 1.5f) distance = 1.5f;
        }
        else
        {
            if (distance < -15.0f) distance = -15.0f;//이게 뒤로 감
            if (distance > 2.5f) distance = 2.5f;

            if (current.x < -6.0f) current.x = -6.0f; //좌우 이동 통제
            if (current.x > 8.1f) current.x = 8.1f;

        }

        Vector3 reverseDistance = new Vector3(current.x, 8f, distance); // 카메라가 바라보는 앞방향은 Z축. 이동량에 따른 Z 축방향의 벡터를 구함.
        transform.position = Vector3.SmoothDamp(transform.position, transform.rotation * reverseDistance, ref velocity, SmoothTime);
    }
}