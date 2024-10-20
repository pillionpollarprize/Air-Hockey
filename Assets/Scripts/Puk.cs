using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puk : MonoBehaviour
{
    public AudioClip clip;
    private AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = clip;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        audioSource.pitch = Random.Range(0.95f, 1.1f);
        audioSource.Play();
    }
}