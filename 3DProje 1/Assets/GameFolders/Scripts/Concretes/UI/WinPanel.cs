using Proje1.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Proje1.UI
{
    public class WinPanel : MonoBehaviour
    {
      public void YesClicked()
        {

            GameManager.Instance.LoadLevelScene(1);
        }
    }

}

