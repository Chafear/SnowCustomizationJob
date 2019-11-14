using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerName : MonoBehaviour
{
    public TextMeshProUGUI playerName;
    // Start is called before the first frame update
    void Start()
    {
        var name = GameObject.FindGameObjectWithTag("DATA").GetComponent<PlayerNameData>().Get();
        if(name == "")
        {
            name = METADATA.PLAYER_NAME_PLACEHOLDER;
        }
        playerName.text = name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
