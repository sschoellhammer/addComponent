using System;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class MyComponent : MonoBehaviour
    {
        [Serializable]
        public class Data
        {
            public int Value;

            public Data(int value)
            {
                Value = value;
            }
        }
        
        [Serializable]
        public class TriSelectionSet
        {
            public string name;
            public List<int> indices;

            public TriSelectionSet(string _name, List<int> _indices)
            {
                name = _name;
                indices = _indices;
            }
        }

        //public List<TriSelectionSet> TriSelections;
        
        public Data data;
        public TriSelectionSet triset;
        
        private void Awake()
        {
            if (Application.isPlaying)
            {
                Debug.Log($"Value: {data.Value}");
                    Debug.Log(triset.name);
                    Debug.Log(triset.indices.Count);
                
            }
        }
    }
}