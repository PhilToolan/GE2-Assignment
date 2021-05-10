using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jjcameracontroller : MonoBehaviour
{
    public Camera camera;
    public float focalLength = 50.0f;
    private float lerp = 0f;
    private float duration = 0.3f;
    private float mid = 50f;
    private float zoom = 100f;
    public Transform target;
    public bool zoomin = false;
    public bool zoomout = false;
    private bool count = false;

    private float waitTime = 3.0f;
    private float timer = 0.0f;

    public GameObject camera1;
    public GameObject camera2;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            zoomin = false;
            zoomout = true;
        }

        if (zoomin)
        {
            lerp += Time.deltaTime / duration;
            focalLength = Mathf.Lerp(mid, zoom, lerp);
            camera.focalLength = focalLength;

        } else if (zoomout)
        {
            lerp += Time.deltaTime / duration;
            focalLength = Mathf.Lerp(zoom, mid, lerp);
            camera.focalLength = focalLength;
        }

        if (count)
        {
            timer += Time.deltaTime;

            if (timer > waitTime)
            {
                SwitchCamera();
            }
        }

        transform.LookAt(target);
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Prey")
        {
            zoomin = true;
            count = true;
        }

    }

    public void SwitchCamera()
    {
        camera2.SetActive(true);
        camera1.SetActive(false);
    }
}
