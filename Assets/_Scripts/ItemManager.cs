using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ItemManager : MonoBehaviour
{
 
    //
    // тут я сделал такой мини обжект пул
    // айтемы пресоздаются заранее и скрываются
    // я использовал лукап чтобы не придумывать велосипедов и хранить все обьекты вместе и получать к ним доступ по скриптбобжекту с их данными
    // так можно использовать 1 ключ на пару лыж
    //
 

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
