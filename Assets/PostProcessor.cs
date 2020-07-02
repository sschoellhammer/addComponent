using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEditor;
using UnityEngine;

public class PostProcessor : AssetPostprocessor
{
    private void OnPostprocessModel(GameObject g)
    {
        if (assetImporter.GetType() == typeof(ModelImporter))
        {
            
            foreach (var renderer in g.GetComponentsInChildren<Renderer>())
            {
                Debug.Log(renderer.name);
                //renderer.gameObject.AddComponent<MyComponent>();
            }
            //g.AddComponent<MyComponent>();
            
        }
    }
    
    
    public void OnPostprocessGameObjectWithUserProperties(
        GameObject g,
        string[] incomingPropertyNames,
        object[] incomingValues)
    {
        var propertyName = "myattr";
        if (((IList) incomingPropertyNames).Contains(propertyName))
        {
            Debug.Log("myAttr");
            g.AddComponent<MyComponent2>();
        }
    }
    
}