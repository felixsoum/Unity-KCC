using UnityEngine;

public class KeypadPuzzle : MonoBehaviour
{
    public Light greenLight;
    public Light redLight;
    public int[] code;
    public GameObject key;

    int currentIndex;
    private bool isFinished;
    float redLightTimer;

    private void Start()
    {
        key.SetActive(false);
    }

    internal void OnPress(int number)
    {
        if (isFinished)
            return;

        if (code[currentIndex] == number)
        {
            if (++currentIndex == code.Length)
            {
                isFinished = true;
                greenLight.enabled = true;
                key.SetActive(true);
            }
        }
        else
        {
            redLight.enabled = true;
            Invoke(nameof(TurnOffRedLight), 1f);
            currentIndex = 0;
        }
    }

    void TurnOffRedLight()
    {
        redLight.enabled = false;
    }
}
