using UnityEngine;

public class InputPlayerName : MonoBehaviour
{
    public TMPro.TMP_InputField inputName;
    public PlayerNameData playerNameData;

    private void OnDestroy()
    {
        playerNameData.Set(inputName.text);
    }

}
