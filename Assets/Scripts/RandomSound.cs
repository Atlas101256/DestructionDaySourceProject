using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSound : MonoBehaviour
{

    private AudioSource source;
    public AudioClip[] sounds;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        int randomSound = Random.Range(0, sounds.Length);
        source.clip = sounds[randomSound];
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
