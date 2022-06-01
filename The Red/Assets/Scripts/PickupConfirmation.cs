using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupConfirmation : MonoBehaviour
{
    [SerializeField]
    private AudioClip soundToPlay;
    public AudioSource sourceToPlay;
    public float volume;
    public bool destructible;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerRadar"))
        {
            PlaySoundClip();
        }
    }

    
    public void PlaySoundClip()
        {
            sourceToPlay.PlayOneShot(soundToPlay, volume);
        }

}
