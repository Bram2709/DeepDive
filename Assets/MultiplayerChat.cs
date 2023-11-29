using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fusion;
using TMPro;

public class MultiplayerChat : MonoBehaviour
{

    public TMP_Text _messages;
    public TMP_Text input;
    public string usernameInput;
    public string username = "Default";

    public void SetUsername()
    {
        usernameInput = username;
    }
  
    public void CallMessageRPC()
    {
        string message = input.text;
        RPC_SendMessage(message, username);
    }

    [Rpc(RpcSources.All, RpcTargets.All)]
    public void RPC_SendMessage(string username, string message, RpcInfo rpcInfo = default)
    {
        _messages.text += $"{username}: {message}\n";
    }

}
