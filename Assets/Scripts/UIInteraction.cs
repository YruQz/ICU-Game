using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIInteraction : MonoBehaviour, IPointerDownHandler
{
    private Fevent eve;

    public void OnPointerDown(PointerEventData eventData) // ������������
    {
        if (eve != null)
        {
        // �����������ҵ���Ծ����
            eve.UIInteraction();
        }
    }

    public void UpdatePlayersRef(Fevent newEve) => eve = newEve;
}
