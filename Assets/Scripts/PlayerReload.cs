using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerReload : MonoBehaviour, IPointerDownHandler
{
    private SavePlayer player;

    public void OnPointerDown(PointerEventData eventData) // ������������
    {
        if (player != null)
        {
            // �����������ҵ���Ծ����
            player.UICheck();
        }
    }

    public void UpdatePlayersRef(SavePlayer newPlayer) => player = newPlayer;
}
