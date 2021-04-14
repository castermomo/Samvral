using UnityEngine;
using System;
using Const;

namespace UIFrame
{
   public abstract class BasicUI: UIBase
   {
       

        protected override void Init()
        {
            layer = Const.UILayer.BASIC_UI;
        }

    }
}
