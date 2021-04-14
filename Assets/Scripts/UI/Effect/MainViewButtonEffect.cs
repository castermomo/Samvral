using Const;
using UnityEngine;
using Util;
using DG.Tweening;
namespace UIFrame
{
   public class MainViewButtonEffect: UIEffectBase
   {
        public override void Enter()
        {
            base.Enter();
            transform.RectTransform().DOKill();
            transform.RectTransform().DOAnchorPos(Vector2.down * 425, 1);
        }
        public override void Exit()
        {
            transform.RectTransform().DOAnchorPos(_defaultAncherPos, 1);
        }

        public override UIEffect GetEffectLevel()
        {
            return UIEffect.OTHERS_EFFECT;
        }

      
   }
}
