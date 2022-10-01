using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject backPack;

    private void Start()
    {
        gameObject.GetComponent<BoxCollider>().isTrigger = true;
        gameObject.AddComponent<Grabeable>();
        
    }


    void Update() //una vez por frame
    {
        Move();
        
        RaycastHit hit;
        if (Physics.Raycast(transform.position,transform.forward, out hit, 10)) //rayo desde mi para adelante. por 10 unidades de lejania
        {
            print(hit.collider.gameObject.name);
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<Grabeable>() != null)// si tiene el script
        {
            if (Input.GetKey(KeyCode.E))
            {
                other.gameObject.transform.parent = backPack.transform;
                other.gameObject.transform.localPosition = Vector3.zero;
            }
        }
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.W)) // SI APRIETO LA W 
        {
            transform.position += transform.forward * Time.deltaTime; // ME  MUEVO PARA ADELANTE
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime; // ME  MUEVO PARA atras
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Time.deltaTime;
        }
    }

}