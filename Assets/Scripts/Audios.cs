using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audios : MonoBehaviour
{
    [SerializeField] AudioClip crash;
    [SerializeField] [Range(0f, 1f)] float vol1;

    [SerializeField] AudioClip jump;
    [SerializeField] [Range(0f, 1f)] float vol2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayCrashClip()
    {
        if(crash != null)
        {
            PlayAudioClip(crash, vol1);
        }
        
    }
    public void PlayJumpClip()
    {
        if (crash != null)
        {
            PlayAudioClip(jump, vol2);
        }
    }

    private void PlayAudioClip(AudioClip soundclip,float volume)
    {
        AudioSource.PlayClipAtPoint(soundclip, Camera.main.transform.position, volume);
    }
}
