using UnityEngine;

public class UVReveal : MonoBehaviour
{
    public MeshRenderer meshRenderer;

    private void Update()
    {
        meshRenderer.material.SetVector("_LightPos", transform.position);
        meshRenderer.material.SetVector("_LightDir", transform.forward);
        meshRenderer.material.SetFloat("_LightAngle", Mathf.Deg2Rad * 30f);
    }
}
