using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ItemView : MonoBehaviour
{
    public TextMeshProUGUI itemName;
    public void Init(string itemName)
    {
        this.itemName.text = itemName;
    }
}
