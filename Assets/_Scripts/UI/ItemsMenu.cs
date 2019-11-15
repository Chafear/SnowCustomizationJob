using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class ItemsMenu : MonoBehaviour
{
    public GameObject helmetsParent, skiesParent, itemViewPrefab;
    public GameObject UI;

    void Start()
    {
        GetComponent<AnimationUtility>().Animate(UI, .7f, new Vector3(-1005f, 0, 0),2);
        var helmets = Resources.LoadAll<HelmetData>(METADATA.HELMETS_PATH);
        var skies = Resources.LoadAll<SkiesData>(METADATA.SKIES_PATH);

        foreach (HelmetData helmetData in helmets)
        {
            var helmetVeiw = Instantiate(itemViewPrefab, helmetsParent.transform);
            helmetVeiw.GetComponent<ItemView>().Init(helmetData.name,helmetData.icon);
            helmetVeiw.GetComponent<Button>().onClick.AddListener(() => GetComponent<Avatar>().EquipHelmet(helmetData));
        }

        foreach (SkiesData skiesData in skies)
        {
            var skiesVeiw = Instantiate(itemViewPrefab, skiesParent.transform);
            skiesVeiw.GetComponent<ItemView>().Init(skiesData.name,skiesData.icon);
            skiesVeiw.GetComponent<Button>().onClick.AddListener(() => GetComponent<Avatar>().EquipSkies(skiesData));
        }
    }

}
