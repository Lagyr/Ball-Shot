using UnityEngine;

public class Settings : MonoBehaviour
{
    public SoundSetting SoundSetting;
    public VibrationSetting VibrationSetting;

    public void OnSoundClicked()
    {
        SoundSetting.Switch();
        Save();
    }

    public void OnVibrationClicked()
    {
        VibrationSetting.Switch();
        Save();
    }
    public void Save()
    {
        SaveManager.instance.Save();
    }
}