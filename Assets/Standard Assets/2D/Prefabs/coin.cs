using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    private Score score;
    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.FindGameObjectWithTag("Player").GetComponent<Score>();
    }

    void OnTriggerExit2D (Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            score.coins += 1;
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
