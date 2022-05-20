using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
  

    
    void Update()
    {
       transform.position += new Vector3 (-5 * Time.deltaTime,0);
        if(transform.position.x < -50.61342f)
        {
            transform.position = new Vector3(50.61342f, transform.position.y);
        }
    }
}