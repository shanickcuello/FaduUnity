using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Player>())
        {
            var currentScene = SceneManager.GetActiveScene().buildIndex; //dame el numero de la escena actual
            SceneManager.LoadScene(0); // cargame esta escena
        }
    }
}
