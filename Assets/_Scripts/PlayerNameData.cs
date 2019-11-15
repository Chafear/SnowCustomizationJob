using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNameData : MonoBehaviour
{
    string text;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public void Set(string text)
    {
        this.text = text;
    }
    public string Get( )
    {
        return text;
    }
}
