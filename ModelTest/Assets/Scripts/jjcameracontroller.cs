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

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            lerp += Time.deltaTime / duration;
            focalLength = Mathf.Lerp(mid, zoom, lerp);
            camera.focalLength = focalLength;
        }

        if (zoomin)
        {
            lerp += Time.deltaTime / duration;
            focalLength = Mathf.Lerp(mid, zoom, lerp);
            camera.focalLength = focalLength;
        }


        transform.LookAt(target);
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Prey")
        {
            zoomin = true;
        }

    }
}
