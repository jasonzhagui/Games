using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    int health = 0;
    public Text scoreOut;
    public AudioClip cookieSound;
    AudioSource _audioSource;
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cookie"))
        {
            health+=10;
            scoreOut.text = health.ToString();
            _audioSource.clip = cookieSound;
            _audioSource.Play();
            Destroy(other.gameObject);
        }

        if (other.CompareTag("badCookie"))
        {
            health -= 10;
            scoreOut.text = health.ToString();
            _audioSource.clip = cookieSound;
            _audioSource.Play();
            Destroy(other.gameObject);
        }
    }
}
