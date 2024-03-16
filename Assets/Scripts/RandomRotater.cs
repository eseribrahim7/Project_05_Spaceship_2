using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotater : MonoBehaviour
{
    Rigidbody physic;
    public int speed;

    void Start()
    {
        physic = GetComponent<Rigidbody>();

        //Debug.Log(Random.insideUnitSphere);
        physic.angularVelocity = Random.insideUnitSphere * speed;
    }


}
