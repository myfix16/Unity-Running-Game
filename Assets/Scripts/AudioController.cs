using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioClip FirstAudioClip;
    public AudioClip SecondAudioClip;
    public AudioClip ThirdAudioClip;
    public AudioSource Audio;

    // Start is called before the first frame update
    void Start()
    {
        Audio = gameObject.GetComponent<AudioSource>();
        Audio.PlayOneShot(FirstAudioClip);
        Audio.PlayOneShot(SecondAudioClip);
        Audio.PlayOneShot(ThirdAudioClip);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
