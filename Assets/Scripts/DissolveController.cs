using UnityEngine;

public class DissolveController : MonoBehaviour
{
    [Header("Dissolve Settings")]
    public Material dissolveMaterial;
    public string dissolveProperty = "_DissolvePercentage";
    public float dissolveTime = 1.0f;

    private float dissolveProgress = 0.0f;
    private bool isDissolving = false;

    private void Start()
    {
        if (dissolveMaterial == null)
        {
            Debug.LogError("Dissolve Material is not assigned!");
            return;
        }

        dissolveMaterial.SetFloat(dissolveProperty, 0.0f);
    }

    private void Update()
    {
        if (isDissolving)
        {
            dissolveProgress += Time.deltaTime / dissolveTime;

            dissolveMaterial.SetFloat(dissolveProperty, dissolveProgress);

            if (dissolveProgress >= 1.0f)
            {
                Destroy(gameObject);
            }
        }
    }

    public void StartDissolve()
    {
        isDissolving = true;
        dissolveProgress = 0.0f;
    }
}