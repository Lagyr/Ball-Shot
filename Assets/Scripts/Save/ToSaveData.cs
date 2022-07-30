using System.Collections.Generic;
using UnityEngine;

public class ToSaveData : MonoBehaviour
{
    [Header("Data to save")]
    [SerializeField] private PointData _pointData;
    [SerializeField] private BackGroundColorMode _backGroundColorMode;
    [SerializeField] private Settings _settings;

    public void SaveData(SavedData data)
    {
        data.SavePointData(_pointData);

        data.DarkMode = _backGroundColorMode.DarkMode;

        data.SoundOn = _settings.SoundSetting.Get();
        data.VibrationOn = _settings.VibrationSetting.Get();

    }

    public void LoadData(SavedData data)
    {
        _pointData.Record.Set(data.Record);
        _pointData.Coins.Set(data.Coins);

        _backGroundColorMode.Set(data.DarkMode);

        _settings.SoundSetting.Set(data.SoundOn);
        _settings.VibrationSetting.Set(data.VibrationOn);

    }
}

[System.Serializable]
public class SavedData
{
    public int Coins;
    public int Record;

    public void SavePointData(PointData pointData)
    {
        Record = pointData.Record.Value;
        Coins = pointData.Coins.Value;
    }

    public bool DarkMode;
    public bool SoundOn;
    public bool VibrationOn;

    [System.Serializable]
    public struct Vect3
    {
        public float x, y, z;

        public Vect3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
