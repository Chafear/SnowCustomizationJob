using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public void Show()
    {
        GetComponent<MeshRenderer>().enabled = true;
    }
    public void Hide()
    {
        GetComponent<MeshRenderer>().enabled = false;
    }
}
