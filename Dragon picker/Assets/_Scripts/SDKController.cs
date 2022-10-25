using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using YG;

public class SDKController : MonoBehaviour
{
    public TextMeshProUGUI textBox;
    public UnityEvent authEvent;

    public void AuthorizationSuccessfull()
    {
        textBox.text = $"Authorization successfull(name -  {YandexGame.playerName})";
    }

    public void AuthorizationFailed()
    {
        textBox.text = "Authorization failed";
    }
}
