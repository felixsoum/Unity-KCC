using UnityEngine;

public class Keypad : MonoBehaviour
{
    public GameObject key;
    public int[] combination = new int[4];
    public Light greenLight;
    int currentIndex;
    bool isFinished;

    internal void OnPress(int number)
    {
        if (isFinished)
        {
            return;
        }

        if (number == combination[currentIndex])
        {
            if (++currentIndex == combination.Length)
            {
                isFinished = true;
                key.SetActive(true);
                greenLight.enabled = true;
            }
        }
        else
        {
            currentIndex = 0;
        }
    }
}
