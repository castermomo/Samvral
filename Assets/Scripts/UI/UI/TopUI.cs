using UnityEngine;
namespace UIFrame
{
   public abstract class TopUI: UIBase   
   {
      protected override void Init()
        {
            layer = Const.UILayer.TOP_UI;
        }
   }
}
