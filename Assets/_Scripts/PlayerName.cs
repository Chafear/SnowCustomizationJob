using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public TMPro.TMP_InputField inputName;
    public string text;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public void SetName()
    {
        text = inputName.text;
    }
}
