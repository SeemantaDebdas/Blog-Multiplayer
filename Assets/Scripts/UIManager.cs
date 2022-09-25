using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public void StartHost()
    {
        if (NetworkManager.Singleton.StartHost())
        {
            print("Host started");
        }
        else
        {
            print("Host failed to Start");
        }
    }

    public void StartServer()
    {
        if (NetworkManager.Singleton.StartServer())
        {
            print("Server started");
        }
        else
        {
            print("Server failed to Start");
        }
    }

    public void StartClient()
    {
        if (NetworkManager.Singleton.StartClient())
        {
            print("Client started");
        }
        else
        {
            print("Client failed to Start");
        }
    }
}
