﻿using System.Threading.Tasks;
using PretiaArCloud.Networking;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace PretiaArCloud.Samples.ShooterSample
{
    public class AuthenticationSceneController1 : MonoBehaviour
    {
        [SerializeField] private int level = 2;
        [SerializeField]
        private Button _startButton = default;

        [SerializeField]
        private GameObject _errorPrompt = default;

        private NetworkManager _networkManager => NetworkManager.Instance;

        private void OnEnable()
        {
            _startButton.onClick.AddListener(Login);
        }

        private void OnDisable()
        {
            _startButton.onClick.RemoveListener(Login);
        }

        private async void Login()
        {
            try
            {
                if (await _networkManager.ConnectAsync())
                {
                    string guest = $"{SystemInfo.deviceUniqueIdentifier}_{System.DateTime.Now.Second}";
                    var (statusCode, token, displayName) = await _networkManager.GuestLoginAsync(guest);

                    if (statusCode == NetworkStatusCode.Success)
                    {
                        if(level == 2){
                        PlayerPrefs.SetString(Constants.ACCESS_TOKEN_KEY, StringEncoder.Instance.GetString(token));
                        SceneManager.LoadScene(Constants.MULTIPLAYER_SCENE);
                        }
                        else if(level == 1){
                        PlayerPrefs.SetString(Constants.ACCESS_TOKEN_KEY, StringEncoder.Instance.GetString(token));
                        SceneManager.LoadScene(Constants.MULTIPLAYER_SCENE1);                            
                        }

                    }
                    else
                    {
                        Debug.LogError($"Failed to login: {statusCode}");
                        _errorPrompt.SetActive(true);
                    }
                }
            }
            catch
            {
                _errorPrompt.SetActive(true);
                throw;
            }
        }
    }
}