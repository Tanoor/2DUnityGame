﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killEnnemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == "Player") 
        {
            Debug.Log ("Ennemy killed");
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
