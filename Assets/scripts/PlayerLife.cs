using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{

    private GameObject player;
    private Rigidbody2D rb;

  
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
      
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

       
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(player.gameObject);
        }
    }

   

}
