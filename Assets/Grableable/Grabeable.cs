using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabeable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print("entre");
    }

    private void OnTriggerStay(Collider other)
    {
        print("me mantengo");
    }

    private void OnTriggerExit(Collider other)
    {
        print("sali");
    }
}
