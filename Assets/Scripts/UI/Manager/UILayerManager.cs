using Const;
using System;
using System.Collections.Generic;
using UnityEngine;
namespace UIFrame
{
   public class UILayerManager: MonoBehaviour   
   {
        private readonly Dictionary<UILayer, Transform> _layerDictionary = new Dictionary<UILayer, Transform>();

        public void Awake()      
      {
            Transform temp = null;
            foreach(UILayer item in Enum.GetValues(typeof(UILayer)))
            {
                //transform.GetComponentInChildren<BasicUI>(true);
                temp = transform.Find(item.ToString());
                if (temp == null)
                {
                    Debug.LogError("can not find Layer" + item + "GameObject");
                    continue;
                }
                else
                {
                    _layerDictionary[item] = temp;
                }
            }
            
      }

    public Transform GetLayerObject(UILayer layer)
        {
            if (_layerDictionary.ContainsKey(layer))
            {
                return _layerDictionary[layer];
               
            }
            else
            {
                Debug.LogError("_layerDictionary did not contains layer:"+layer);
                return null;
            }
            
        }
   }
}
