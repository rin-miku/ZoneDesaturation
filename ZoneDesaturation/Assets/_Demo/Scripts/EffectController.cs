using UnityEngine;

public class EffectController : MonoBehaviour
{
    public float radius;

    private void OnValidate()
    {
        var temps = FindObjectsByType<Renderer>(FindObjectsSortMode.None);
        foreach (Renderer renderer in temps)
        {
            foreach (Material material in renderer.sharedMaterials)
            {
                material.SetFloat("_DesaturationRadius", radius);
            }
        }
    }
}
