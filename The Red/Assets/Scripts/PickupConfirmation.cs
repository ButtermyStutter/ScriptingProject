using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PickupConfirmation : MonoBehaviour
{
    [SerializeField]
    private AudioClip soundToPlay;
    public AudioSource sourceToPlay;
    public float volume;
    public bool destructible;
    public Image buttonBackground;
    public Image buttonForeground;
    public Text displayMessage;
    public Text displayE;

    private void Awake()
    {
        buttonBackground.gameObject.SetActive(false);
        buttonForeground.gameObject.SetActive(false);
        displayMessage.gameObject.SetActive(false);
        displayE.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerRadar"))
        {
            PlaySoundClip();
            Debug.Log("Sound played!");
        }
    }
    public void PlaySoundClip()
        {
            sourceToPlay.PlayOneShot(soundToPlay, volume);
        }

}
