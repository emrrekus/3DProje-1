using Proje1.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Proje1.UI
{
    public class MenuPanel : MonoBehaviour
    {
        public void StartClicked()
        {
            GameManager.Instance.LoadLevelScene(1);

        }
       public void ExitClicked()
        {
            GameManager.Instance.Exit();
        }
    }

}

