using UnityEngine;

public class Skies : Item, IWearable
{
    public SkiesData skiesData;
    public SkiesAlingmenet alingmenet;
    public void SetPreset()
    {
        if (alingmenet == SkiesAlingmenet.Left)
        {
            transform.localRotation = Quaternion.Euler(Preset.rotationL);
        }
        else
        {
            transform.localRotation = Quaternion.Euler(Preset.rotationR);
        }
    }

    public void Init(SkiesData skiesData, SkiesAlingmenet skiesAlingmenet)
    {
        alingmenet = skiesAlingmenet;
        this.skiesData = skiesData;
        SetPreset();
        Hide();
    }
}
public enum SkiesAlingmenet
{
    Left,
    Right
}
