using UnityEngine;
public class Avatar : MonoBehaviour
{
    public GameObject helmetSlot, skiesLSlot, skiesRSlot;
    ItemData currentHelmet, currentSkies;

    public void EquipHelmet(HelmetData helmetData)
    {
        if (currentHelmet != helmetData)
        {
            if (currentHelmet!=null)
            {
                UnEquipHelmet();
            }
            currentHelmet = helmetData;
            var items = GetComponent<ItemManager>().items;
            foreach (var item in GetComponent<ItemManager>().items[currentHelmet])
            {
                item.GetComponent<Helmet>().Show();
            }
        }
    }

    public void EquipSkies(SkiesData skiesData)
    {
        if(currentSkies != skiesData)
        {
            if (currentSkies != null)
            {
                UnEquipSkies();
            }
            currentSkies = skiesData;
            var items = GetComponent<ItemManager>().items;
            foreach (var item in GetComponent<ItemManager>().items[currentSkies])
            {
                item.GetComponent<Skies>().Show();
            }
        }
    }

    public void UnEquipHelmet()
    {
        var items = GetComponent<ItemManager>().items;
        foreach (var item in GetComponent<ItemManager>().items[currentHelmet])
        {
            item.GetComponent<Helmet>().Hide();
        }
    }

    public void UnEquipSkies()
    {
        
        var items = GetComponent<ItemManager>().items;
        foreach (var item in GetComponent<ItemManager>().items[currentSkies])
        {
            item.GetComponent<Skies>().Hide();
        }
    }

}
