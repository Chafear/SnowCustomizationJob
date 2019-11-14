using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class ItemsMenu : MonoBehaviour
{
    //HelmetData[] helmets;
    public GameObject helmetsParent, skiesParent, itemViewPrefab;
    public GameObject UI;

    void Start()
    {
        StartCoroutine(Entry());
        var helmets = Resources.LoadAll<HelmetData>(METADATA.HELMETS_PATH);
        var skies = Resources.LoadAll<SkiesData>(METADATA.SKIES_PATH);

        foreach (HelmetData helmetData in helmets)
        {
            var helmetVeiw = Instantiate(itemViewPrefab, helmetsParent.transform);
            helmetVeiw.GetComponent<ItemView>().Init(helmetData.name);
            helmetVeiw.GetComponent<Button>().onClick.AddListener(() => GetComponent<Avatar>().EquipHelmet(helmetData));
        }

        foreach (SkiesData skiesData in skies)
        {
            var skiesVeiw = Instantiate(itemViewPrefab, skiesParent.transform);
            skiesVeiw.GetComponent<ItemView>().Init(skiesData.name);
            skiesVeiw.GetComponent<Button>().onClick.AddListener(() => GetComponent<Avatar>().EquipSkies(skiesData));
        }
    }
    IEnumerator Entry()
    {
        float smoothTime = .7f;

        Vector3 velocity = Vector3.zero;
        Vector3 targetPosition = UI.transform.position;
        UI.transform.position = new Vector3(UI.transform.position.x-1005f, UI.transform.position.y, UI.transform.position.z);
        yield return new WaitForSeconds(2);

        while (transform.position != targetPosition)
        {
            UI.transform.position = Vector3.SmoothDamp(UI.transform.position, targetPosition, ref velocity, smoothTime);
            yield return new WaitForFixedUpdate();
        }
    }
}
