using UnityEngine;
using Const;
using Util;
using DG.Tweening;
using UnityEngine.SceneManagement;
namespace UIFrame
{
   public class StartGameView: BasicUI
   {
        public override UiId GetUiId()
        {
            return UiId.StartGame;
        }
        public void Start()
        {          
            transform.Find("Buttons/Continue").RectTransform().AddBtnListenr(()=> { });
            transform.Find("Buttons/Easy").RectTransform().AddBtnListenr(()=> { SceneManager.LoadScene("Level01"); });
            transform.Find("Buttons/Normal").RectTransform().AddBtnListenr(()=> { });
            transform.Find("Buttons/Hard").RectTransform().AddBtnListenr(()=> { });
        }
    }
}
