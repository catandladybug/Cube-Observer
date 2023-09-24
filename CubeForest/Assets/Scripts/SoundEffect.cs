using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour, IObserver
{
    [SerializeField] Subject _playerSubject;

    [SerializeField] AudioClip _fallEffect;
    AudioSource _audioPlayer;

    private void Awake()
    {
        _audioPlayer = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        _playerSubject.AddObserver(this);
    }

    private void OnDisable()
    {
        _playerSubject.RemoveObserver(this);
    }
    public void OnNotify()
    {
        _audioPlayer.clip = _fallEffect;
        _audioPlayer.Play();
    }
}
