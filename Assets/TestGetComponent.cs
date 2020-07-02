using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;

public class TestGetComponent : MonoBehaviour
{
    public GameObject MyComponentHolderPrefab;

    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        var holder = Instantiate(MyComponentHolderPrefab);
        var comp = holder.GetComponentInChildren<MyComponent>();
        Debug.Log($"Got component value: {comp.triset.name}");
        text.text = comp.triset.name;

    }
}
