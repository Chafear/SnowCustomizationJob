using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ItemManager : MonoBehaviour
{
    public ILookup<ItemData, GameObject> items;

    void Start()
    {
        var itemsTemp = new List<KeyValuePair<ItemData, GameObject>>();
        Avatar avatar = GetComponent<Avatar>();

        HelmetData[] helmetsDatas = Resources.LoadAll<HelmetData>(METADATA.HELMETS_PATH);
        SkiesData[] skiesDatas = Resources.LoadAll<SkiesData>(METADATA.SKIES_PATH);

        foreach (HelmetData helmetData in helmetsDatas)
        {
            var i = Instantiate(helmetData.helmetPrefab, avatar.helmetSlot.transform);
            i.GetComponent<Helmet>().Init(helmetData);
            itemsTemp.Add(new KeyValuePair<ItemData, GameObject>(helmetData, i));
        }

        foreach (SkiesData skiesData in skiesDatas)
        {
            var i = Instantiate(skiesData.skiLeftPrefab, avatar.skiesLSlot.transform);
            i.GetComponent<Skies>().Init(skiesData, SkiesAlingmenet.Left);
            itemsTemp.Add(new KeyValuePair<ItemData, GameObject>(skiesData, i));

            i = Instantiate(skiesData.skiRightPrefab, avatar.skiesRSlot.transform);
            i.GetComponent<Skies>().Init(skiesData, SkiesAlingmenet.Right);
            itemsTemp.Add(new KeyValuePair<ItemData, GameObject>(skiesData, i));
        }

        items = itemsTemp.ToLookup(kvp => kvp.Key, kvp => kvp.Value);
    }

}
