using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    public GameObject battle;
    public GameObject final;
    public GameObject exp;
    public GameObject weap;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "MainCharacters")
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
        }
        if (col.gameObject.tag == "ArrivalCamera")
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
        }
        if (col.gameObject.tag == "DialogueCamera")
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
        }
        if (col.gameObject.tag == "EnemyFleet")
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
        }
        if (col.gameObject.tag == "GoodFleet")
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
        }
        if (col.gameObject.tag == "ClashCamera")
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
            battle.SetActive(true);
        }
        if (col.gameObject.tag == "303")
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
        }
        if (col.gameObject.tag == "Attack")
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
        }
        if (col.gameObject.tag == "SuperWeapon")
        {
            camera1.SetActive(false);
            camera2.SetActive(true);
        }
        if (col.gameObject.tag == "Final")
        {
            camera1.SetActive(false);
            battle.SetActive(false);
            final.SetActive(false);
            exp.SetActive(false);
            weap.SetActive(false);


            camera2.SetActive(true);
        }

    }
}