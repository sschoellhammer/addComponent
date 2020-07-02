using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEditor;
using UnityEngine;
using UnityEngine.Animations;

public class PostProcessor : AssetPostprocessor
{
    /*
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
    }*/
    
    
    public void OnPostprocessGameObjectWithUserProperties(
        GameObject g,
        string[] incomingPropertyNames,
        object[] incomingValues)
    {
        var propertyName = "myattr";
        if (((IList) incomingPropertyNames).Contains(propertyName))
        {
            Debug.Log("myAttr");
            var c = g.AddComponent<MyComponent>();
            c.data = new MyComponent.Data(10);
            
            c.triset = new MyComponent.TriSelectionSet("bra", new List<int> {0,2,3,4});
            Debug.Log(c.triset.name);
            //EditorUtility.SetDirty(c);
            //EditorUtility.SetDirty(g);
        }
    }
    
}