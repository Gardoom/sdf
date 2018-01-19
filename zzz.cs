using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zzz : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Quaternion rotationZ = Quaternion.AngleAxis(1, Vector2.up);
        transform.rotation *= rotationZ;
    }
}