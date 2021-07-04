using System;
using TMPro;
using UnityEngine;


    public class UIManager : MonoBehaviour
    {
        public GameObject Opening;
        public GameObject InGame;
        public GameObject EndGame;
        public TextMeshProUGUI _currentScore;
        public TextMeshProUGUI _bestScore;
        public PlayerView view;


        public void changeScene(PlayerModel.Scenes scene)
        {
            view.currentScene = scene;

            switch (scene)
            {
                case PlayerModel.Scenes.Opening:
                    Opening.SetActive(true);
                    InGame.SetActive(false);
                    EndGame.SetActive(false);
                    break;
                case PlayerModel.Scenes.InGame:
                    Opening.SetActive(false);
                    InGame.SetActive(true);
                    EndGame.SetActive(false);
                    break;
                case PlayerModel.Scenes.EndGame:
                    Opening.SetActive(false);
                    InGame.SetActive(false);
                    EndGame.SetActive(true);
                    break;
            }
        }
    }