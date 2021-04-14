using Const;
using UnityEngine;
using UnityEngine.UI;
using Util;

namespace UIFrame
{
    public class MainMenuView : BasicUI
    {
        public override UiId GetUiId()
        {
            return UiId.MainMenu;
        }

        public void Start()
        {
            //transform.GetComponent<RectTransform>().GetComponent<Button>().onClick.AddListener();
            //transform.RectTransform().AddBtnListenr();
            transform.Find("Buttons/StartGame").RectTransform().AddBtnListenr(()=> { RootManager.Instance.Show(UiId.StartGame); });
            transform.Find("Buttons/DOJO").RectTransform().AddBtnListenr(()=> { });
            transform.Find("Buttons/Help").RectTransform().AddBtnListenr(()=> { });
            transform.Find("Buttons/ExitGame").RectTransform().AddBtnListenr(()=> { Application.Quit(); });
        }

    }
}
