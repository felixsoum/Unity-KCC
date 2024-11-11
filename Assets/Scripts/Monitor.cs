using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Monitor : MonoBehaviour, IInteractable
{
    public Camera monitorCamera;
    public GraphicRaycaster raycaster;
    public TMP_Text monitorText;
    int clickLeft = 5;
    private BeerCan beerCan;

    private void Start()
    {
        monitorText.text = clickLeft.ToString();
        beerCan = FindAnyObjectByType<BeerCan>();
        beerCan.gameObject.SetActive(false);
    }

    public void Interact()
    {
        FindAnyObjectByType<MyPlayer>().SetSecondaryCam(monitorCamera, raycaster);
    }

    public void OnButtonClick()
    {
        if (--clickLeft > 0)
        {
            monitorText.text = clickLeft.ToString();
        }
        else
        {
            monitorText.text = "LOOK BELOW ME!";
            beerCan.gameObject.SetActive(true);
        }
    }
}
