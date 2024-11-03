using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class BeerCan : MonoBehaviour, IInteractable
{
    public GameObject fakeWall;
    bool isDrank;

    public void Interact()
    {
        if (isDrank)
        {
            return;
        }

        ApplyDrunkEffect(true);
        Invoke(nameof(SoberUp), 5f);
    }

    void Update()
    {
        if (isDrank)
        {
            var volume = FindAnyObjectByType<Volume>();
            var profile = volume.profile;
            LensDistortion lensDistortion;
            if (profile.TryGet(out lensDistortion))
            {
                var intensity = lensDistortion.intensity;
                intensity.value = Mathf.Sin(Time.time) * 0.5f;
                lensDistortion.intensity = intensity;
            }
        }
    }

    private void ApplyDrunkEffect(bool isOn)
    {
        fakeWall.SetActive(!isOn);
        isDrank = isOn;

        var volume = FindAnyObjectByType<Volume>();

        if (volume.profile.TryGet(out ChromaticAberration chromaticAberration))
        {
            chromaticAberration.active = isOn;
        }

        if (volume.profile.TryGet(out LensDistortion lensDistortion))
        {
            lensDistortion.active = isOn;
        }
    }

    void SoberUp()
    {
        ApplyDrunkEffect(false);
    }
}
