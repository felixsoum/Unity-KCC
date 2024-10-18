using UnityEngine;

public class OldKey : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        FindAnyObjectByType<MyPlayer>().CollectOldKey();
        Destroy(gameObject);
    }
}
