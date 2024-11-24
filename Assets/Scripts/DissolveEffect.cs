using UnityEngine;

public class DissolveEffect : MonoBehaviour
{
    public Material dissolveMaterial;
    public float speed = 1.0f;

    void Update()
    {
        float threshold = Mathf.PingPong(Time.time * speed, 1.0f);
        dissolveMaterial.SetFloat("_DissolveThreshold", threshold);
    }
}