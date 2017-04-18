using System;
using DicesCustomControls.Delegates;
using DicesCustomControls.Enums;
using DicesCustomControls.ObjetosDeValor;

namespace DicesCustomControls.Interfaces
{
    public interface IPlayer
    {
        void SetMedia(MediaSource media);
        void Play();
        void Pause();
        void Stop();
        PlayerStatus PlayPause();
        TimeSpan Position { get; set; }
        TimeSpan Duration { get; }
        PlayerStatus Status { get; }
        string Current { get; }

        event PlayerDelegates.PlayerProgressEvent PlayerProgress;
    }
}
