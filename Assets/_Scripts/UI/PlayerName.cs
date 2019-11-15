using UnityEngine;
using TMPro;
public class PlayerName : MonoBehaviour
{
    public TextMeshProUGUI playerName;

    void Start()
    {
       
        var name = GameObject.FindGameObjectWithTag("DATA")?.GetComponent<PlayerNameData>().Get();
        if(name == "")
        {
            name = METADATA.PLAYER_NAME_PLACEHOLDER;
        }
        playerName.text = name;
    }

}
