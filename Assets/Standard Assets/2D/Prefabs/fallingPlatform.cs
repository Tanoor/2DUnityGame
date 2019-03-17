using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingPlatform : MonoBehaviour
{
    public Vector3 basePosition;
    public Quaternion baseRotation;
    public AudioClip audio;
    private bool hasPlayed = false;
    public float x;
    public float y;
    public float z;

    // Start is called before the first frame update
    void Start()
    {
        basePosition = transform.position;
        x = transform.rotation.x;
        y = transform.rotation.y;
        z = transform.rotation.z;
    }

    void OnTriggerEnter2D (Collider2D other) 
    {
        if (other.gameObject.tag == "Player")
        {
            if(hasPlayed == false)
            {
                GetComponent<AudioSource>().PlayOneShot(audio);
                hasPlayed = true;
            }
            transform.GetComponent<Rigidbody2D>().isKinematic = false;
        }

    }

    // Update is called once per frame
    public void Reset()
    {
        Debug.Log("Reseting...");
        transform.position = basePosition;
        baseRotation = new Quaternion(x, y, z, 1);
        transform.rotation = baseRotation;
        transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        hasPlayed = false;
    }
}
