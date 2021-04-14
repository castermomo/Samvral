using UnityEngine;
using Const;
using System;

namespace UIFrame
{
   public class RootManager: MonoBehaviour
   {
        public static RootManager Instance { get; private set; } 

        private UIManager _uiManager;
        private UIEffectManager _effectManager;
        private UILayerManager _layerManager;
        private InputManager _inputManager;

        private void Awake()
        {
            Instance = this;
            _uiManager = gameObject.AddComponent<UIManager>();
            _effectManager = gameObject.AddComponent<UIEffectManager>();
            _layerManager = gameObject.AddComponent<UILayerManager>();
            _inputManager = gameObject.AddComponent<InputManager>();

            _uiManager.AddGetLayerObjectListener(_layerManager.GetLayerObject);

        }

        private void Start()
        {
            Show(UiId.MainMenu);
        }


        public void Show(UiId id)
        {
            var uiPara = _uiManager.Show(id);
            ExcuteEffect(uiPara);
        }   

        public void Back()
        {
            var uiPara = _uiManager.Back();
            ExcuteEffect(uiPara);
        }

        private void ExcuteEffect(Tuple<Transform, Transform> uiPara)
        {
            _effectManager.Show(uiPara.Item1);
            _effectManager.Hide(uiPara.Item2);
        }
    }
}
