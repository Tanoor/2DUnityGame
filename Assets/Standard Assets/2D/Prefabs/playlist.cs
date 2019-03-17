using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playlist : MonoBehaviour
{
    Object[] myMusic;

    void Awake()
    {
        myMusic = Resources.LoadAll("Playlist", typeof(AudioClip));
        if(myMusic.Length != 0) {
            GetComponent<AudioSource>().clip = myMusic[0] as AudioClip;
        } 
    }
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(!GetComponent<AudioSource>().isPlaying)
        {
            playRandomMusic();
        }
    }

    void playRandomMusic() {
        if(myMusic.Length != 0) {
            GetComponent<AudioSource>().clip = myMusic[Random.Range(0, myMusic.Length)] as AudioClip;
            GetComponent<AudioSource>().Play();
        } 
    }
}
