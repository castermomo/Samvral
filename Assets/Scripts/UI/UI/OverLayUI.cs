using UnityEngine;
namespace UIFrame
{
   public abstract class OverLayUI: UIBase
   {
        protected override void Init()
        {
            layer = Const.UILayer.OVERLAY_UI;
        }
    }
}
 