using System;
using System.Collections;
using System.Collections.Generic;
using RocketChallange.Abstracts.Utilities;
using UnityEngine;

namespace RocketChallange.Managers
{
    public class SoundManager : SingletonThisObject<SoundManager>
    {
        private AudioSource[] _audioSource;
        private void Awake()
        {
            SingletonThisGameObject(this);

            _audioSource = GetComponentsInChildren<AudioSource>();
        }

        public void PlaySound(int index)
        {
            if (!_audioSource[index].isPlaying)
            {
                _audioSource[index].Play();
            }
        }
        
        public void StopSound(int index)
        {
            if (_audioSource[index].isPlaying)
            {
                _audioSource[index].Stop();
            }
        }
    }
}
