using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class OculusButtonHandler : MonoBehaviour
{
    public Button Newgame; // Newgame ��ư�� ���� ����

    void Update()
    {
        HandleOVRInput();
    }

    private void HandleOVRInput()
    {
        // B ��ư�� ������ �� Newgame ��ư�� onClick �̺�Ʈ�� ȣ���մϴ�.
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            Debug.Log("B Button Pressed");

            if (Newgame != null)
            {
                // Newgame ��ư�� onClick �̺�Ʈ�� ȣ��
                Newgame.onClick.Invoke();
                Debug.Log("Newgame Button Clicked");
            }
            else
            {
                Debug.LogWarning("Newgame Button reference is not set.");
            }
        }
    }
}
