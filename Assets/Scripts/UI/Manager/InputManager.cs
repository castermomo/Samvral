using UnityEngine;
namespace UIFrame
{
   public class InputManager: MonoBehaviour   
   {
      public void Start()      
      {
      }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                RootManager.Instance.Back();
            }
        }
    }
}
