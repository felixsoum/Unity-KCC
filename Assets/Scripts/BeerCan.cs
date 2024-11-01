using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class BeerCan : MonoBehaviour, IInteractable
{
    public GameObject fakeWall;

    public void Interact()
    {
        Volume volume = FindAnyObjectByType<Volume>();
        if (volume.profile.TryGet<ChromaticAberration>(out ChromaticAberration chromaticAberration))
        {
            chromaticAberration.active = true;
        }

        if (volume.profile.TryGet<LensDistortion>(out LensDistortion listortion))
        {
            listortion.active = true;
        }

        Destroy(fakeWall);
        Destroy(gameObject);
    }
}
