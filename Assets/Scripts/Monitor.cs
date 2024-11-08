using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Monitor : MonoBehaviour, IInteractable
{
    public Camera monitorCamera;
    public TMP_Text monitorText;
    public GraphicRaycaster raycaster;

    int count = 0;

    public void Interact()
    {
        FindAnyObjectByType<MyPlayer>().SetCamera(monitorCamera, raycaster);
    }

    public void OnButtonClick()
    {
        count++;
        monitorText.text = count.ToString();
    }
}
