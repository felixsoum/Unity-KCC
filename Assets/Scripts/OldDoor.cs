using UnityEngine;

public class OldDoor : MonoBehaviour, IInteractable
{
    public GameObject door;

    public void Interact()
    {

        MyPlayer myPlayer = FindAnyObjectByType<MyPlayer>();

        if (myPlayer.HasOldKey)
        {
            GetComponent<Animator>().SetTrigger("Open");
            myPlayer.DestroyOldKey();
        }
        else
        {
            FindAnyObjectByType<SubtitleText>().ShowText("La porte est verouillé", 5f);
        }
    }
}
