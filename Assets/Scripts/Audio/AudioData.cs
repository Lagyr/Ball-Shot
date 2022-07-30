using UnityEngine;

public class AudioData : MonoBehaviour
{
    public AudioClipData ButtonClip;

    public AudioClipData Release;

    [System.Serializable]
    public struct BasketAudio
    {
        public AudioClipData Net;
        public AudioClipData Hoop;
    }

    public BasketAudio basketAudio;

    public AudioClipData Border;

    public AudioClipData Wall;

    public AudioClipData ScorePerfect;

    public AudioClipData Coin;

    public AudioClipData Gameover;
}
