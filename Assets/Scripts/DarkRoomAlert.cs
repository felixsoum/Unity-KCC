using UnityEngine;

public class DarkRoomAlert : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var character = other.GetComponent<MyCharacterController>();
        if (character != null && !character.hasFlashlight)
        {
            FindAnyObjectByType<SubtitleText>().ShowText("Il fait trop noir ici... faudrait que je trouve une source de lumière.");
        }
    }
}
