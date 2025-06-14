using DG.Tweening;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

public class Decal : MonoBehaviour
{
    private DecalProjector decalProjector;
    private Material decalMaterial;

    private void Start()
    {
        decalProjector = GetComponent<DecalProjector>();
        decalProjector.material = Instantiate(decalProjector.material);
        decalMaterial = decalProjector.material;

        DecalAnimation();
    }

    private void DecalAnimation()
    {
        decalProjector.fadeFactor = 0.3f;
        decalMaterial.SetFloat("_EmissionIntensity", 70f);

        DOVirtual.Float(70f, 100f, 1f, (value) => { decalMaterial.SetFloat("_EmissionIntensity", value); })
            .OnComplete(() => 
            {
                DOVirtual.Float(100f, 0f, 2f, (value) => { decalMaterial.SetFloat("_EmissionIntensity", value); })
                .SetEase(Ease.Linear);

                DOVirtual.Float(0.3f, 0f, 3f, (value) => { decalProjector.fadeFactor = value; })
                .OnComplete(() => { Destroy(gameObject); })
                .SetEase(Ease.Linear)
                .SetDelay(1f);
            })
            .SetEase(Ease.Linear);
    }
}
