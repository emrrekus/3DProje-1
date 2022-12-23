using Proje1.Managers;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Proje1.UI
{

    public class GameOverObject : MonoBehaviour
    {

        [SerializeField] GameObject _gameOverPanel;

        private void Awake()
        {
            if (_gameOverPanel.activeSelf)
            {
                _gameOverPanel.SetActive(false);
            }

        }
        private void OnEnable()
        {
            GameManager.Instance.OnGameOver += InstanceOnGameOver;
        }
               
        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= InstanceOnGameOver;
        }
        private void InstanceOnGameOver()
        {
            if (!_gameOverPanel.activeSelf)
            {
                _gameOverPanel.SetActive(true);
            }
        }
    }


}

