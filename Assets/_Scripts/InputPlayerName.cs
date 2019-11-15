using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputPlayerName : MonoBehaviour
{
    public TMPro.TMP_InputField inputName;
    public PlayerNameData playerNameData;
    private void OnDestroy()
    {
        playerNameData.Set(inputName.text);
    }

}
