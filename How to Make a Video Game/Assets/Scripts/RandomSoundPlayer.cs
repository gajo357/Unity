using System.Collections.Generic;
using UnityEngine;

public class RandomSoundPlayer : MonoBehaviour
{
    private AudioSource audioSource;

    [SerializeField]
    private List<AudioClip> soundClips = new List<AudioClip>();

    [SerializeField]
    private float soundTimerDelay = 3f;

    private float _soundTimer = 0f;

    // Use this for initialization
    private void Start ()
    {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	private void Update ()
    {
        _soundTimer += Time.deltaTime;
		
        if(_soundTimer >= soundTimerDelay)
        {
            // reset the timer
            _soundTimer = 0f;

            // play a random sound
            AudioClip randomSound = soundClips[Random.Range(0, soundClips.Count - 1)];
            audioSource.PlayOneShot(randomSound);
        }
	}
}
