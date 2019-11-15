using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemView : MonoBehaviour
{
    public TextMeshProUGUI itemName;
    public Image itemImage;

    public void Init(string itemName, Sprite itemImage)
    {
        this.itemName.text = itemName;
        this.itemImage.sprite = itemImage;
    }
}
