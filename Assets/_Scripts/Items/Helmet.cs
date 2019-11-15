using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helmet :Item, IWearable
{
    public HelmetData helmetData;

    public void SetPreset()
    {
        this.transform.localScale = Preset.scale;
    }

    public void Init(HelmetData helmetData)
    {
        this.helmetData = helmetData;
        SetPreset();
        Hide();
    }

}
