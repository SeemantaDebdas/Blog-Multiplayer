using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Netcode;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI debugText = null;
    public void StartHost()
    {
        if (NetworkManager.Singleton.StartHost())
        {
            debugText.text = "Host started";
        }
        else
        {
            debugText.text = "Host failed to Start";
        }
    }

    public void StartServer()
    {
        if (NetworkManager.Singleton.StartServer())
        {
            debugText.text = "Server started";
        }
        else
        {
            debugText.text = "Server failed to Start";
        }
    }

    public void StartClient()
    {
        if (NetworkManager.Singleton.StartClient())
        {
            debugText.text = "Client started";
        }
        else
        {
            debugText.text = "Client failed to Start";
        }
    }
}
