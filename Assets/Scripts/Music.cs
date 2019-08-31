using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip[] song;
    private AudioClip songClip;
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        int index = Random.Range(0, song.Length);
        songClip = song[index];
        audioSource.clip = songClip;
        audioSource.Play();
    }
    void Update()
    {

    }
}