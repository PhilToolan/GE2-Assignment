using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendArrivalCamera : MonoBehaviour
{
    public Transform target;
    public float speed = 10;

    private float rotSpeed = 15.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 toPlayer = target.position - transform.position;


        transform.rotation = Quaternion.RotateTowards(transform.rotation,
                Quaternion.LookRotation(toPlayer)
                , rotSpeed * Time.deltaTime
                );

        //transform.Translate(0, 0, speed * Time.deltaTime);



    }
}
