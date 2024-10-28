using UnityEngine;

public class OldDoor : MonoBehaviour, IInteractable
{
    public GameObject door;

    public void Interact()
    {
        if (FindAnyObjectByType<MyPlayer>().HasOldKey)
        {
            GetComponent<Animator>().SetTrigger("Open");
        }
        else
        {
            FindAnyObjectByType<SubtitleText>().ShowText("La porte est verouillé", 5f);
        }
    }
}
