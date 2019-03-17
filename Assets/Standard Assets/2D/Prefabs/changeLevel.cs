using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeLevel : MonoBehaviour
{
    public string level = "Enter level name";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Application.LoadLevel(level);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
