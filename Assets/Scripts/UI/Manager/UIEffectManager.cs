using Const;
using System;
using UnityEngine;
namespace UIFrame
{
   public class UIEffectManager: MonoBehaviour   
   {
      public void Show(Transform ui)
        {
            if (ui == null)
                return;
            foreach (UIEffectBase effectBase in ui.GetComponentsInChildren<UIEffectBase>(true))
            {
                effectBase.Enter();
            }
        }
        public void Hide(Transform ui)
        {
            if (ui == null)
                return;
            foreach (UIEffectBase effectBase in ui.GetComponentsInChildren<UIEffectBase>(true))
            {
                effectBase.Exit();
            }
        }
        public void AddEffectEnterListener(Transform ui,Action enterComplete)
        {
            foreach (UIEffectBase effectBase in ui.GetComponentsInChildren<UIEffectBase>(true))
            {
                if (effectBase.GetEffectLevel() == UIEffect.VIEW_EFFECT)
                {
                    effectBase.OnEnterComplete(enterComplete);
                }
            }

        }
        public void AddEffectExitListener(Transform ui, Action exitComplete)
        {
            foreach (UIEffectBase effectBase in ui.GetComponentsInChildren<UIEffectBase>(true))
            {
                if (effectBase.GetEffectLevel() == UIEffect.VIEW_EFFECT)
                {
                    effectBase.OnExitComplete(exitComplete);
                }
            }

        }
    }
}
