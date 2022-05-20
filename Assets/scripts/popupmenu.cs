using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class popupmenu : MonoBehaviour
{
    public GameObject menu;
    GameObject player;
    private void Start()
    {
      menu.gameObject.SetActive(false);
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        if(!player)
        {
            menu.gameObject.SetActive(true);
        }
    }
}
