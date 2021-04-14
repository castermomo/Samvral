using System;
using UnityEngine;
using UnityEngine.UI;

namespace Util
{
    //拓展方法工具类
   public static class ExtendUntil
   {
     public static void AddBtnListenr(this RectTransform rect,Action action)
        {           
                var button = rect.GetComponent<Button>() ?? rect.gameObject.AddComponent<Button>();

                button.onClick.AddListener(()=>action());            
        }
        public static RectTransform RectTransform(this Transform transform)
        {
            var rect = transform.GetComponent<RectTransform>();
            if(rect != null)
            {
                return rect;
            }
            else
            {
                Debug.LogError("can not find RectTransform");
                return null;
            }
        }
   }
}
