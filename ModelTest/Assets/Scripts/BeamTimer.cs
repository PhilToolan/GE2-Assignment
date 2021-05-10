using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamTimer : MonoBehaviour
{
    public float waitTime = 1.0f;
    private float timer = 0.0f;
    public GameObject beam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.deltaTime;

        if (timer > waitTime)
        {
            beam.SetActive(true);
        }
    }
}
