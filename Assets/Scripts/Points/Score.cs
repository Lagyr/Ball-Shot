using UnityEngine;

public class Score : Point
{
    [SerializeField] private Audio _audio;

    private int _combo = 0;

    public int Combo { get => _combo; }

    private bool _wasPerfectThrow;

    private void IncreaseCombo()
    {
        _combo++;
        PlaySound();
    }

    public void StopCombo()
    {
        _wasPerfectThrow = false;
        _combo = 0;
    }

    public override void IncreaseOn(int value)
    {
        if (!_wasPerfectThrow)
        {
            _wasPerfectThrow = true;
        }
        else
        {
            IncreaseCombo();
        }

        base.IncreaseOn(value + _combo);
           
    }

    private void PlaySound()
    {       
        AudioClip clip = AudioManager.instance.Data.ScorePerfect.Clip;
        float volume = AudioManager.instance.Data.ScorePerfect.Volume;
     
        _audio.Play(clip, volume);
    }
}
