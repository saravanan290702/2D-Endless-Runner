using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeScript1 : MonoBehaviour
{
    public spikeGenerator spikeGenerator;
 
    private Rigidbody2D rb;
    private void Start()
    {
      
    }
    void Update()
    {
        transform.Translate(Vector2.left * spikeGenerator.CurrentSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
         if(collision.gameObject.CompareTag("nextLine2"))
        {
            spikeGenerator.Randomizer();
        }
        if (collision.gameObject.CompareTag("finish2"))
        {
            Destroy(this.gameObject);
        }
     
    }
}
