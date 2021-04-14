using Const;
using UnityEngine;
using DG.Tweening;
using Util;

namespace UIFrame
{
   public class GameNameEffect: UIEffectBase
   {
        public override void Enter()
        {
            base.Enter();
            float time = 2;
            transform.DOKill();
            transform.RectTransform().DOKill();
            transform.DOScale(Vector3.one, time);
            transform.RectTransform().DOAnchorPos(new Vector2(920f, 470f), time).OnComplete(() => _onEnterComplete?.Invoke());

        }

        public override void Exit()
        {
            float time = 1;
            transform.DOKill();
            transform.RectTransform().DOKill();
            transform.DOScale(Vector3.one * 2, time);
            transform.RectTransform().DOAnchorPos(_defaultAncherPos, time).OnComplete(() => _onExitComplete?.Invoke());
            

        }
        public override UIEffect GetEffectLevel()
        {
            return UIEffect.VIEW_EFFECT;
        }

      
   }
}
