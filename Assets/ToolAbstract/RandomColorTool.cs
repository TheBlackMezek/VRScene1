using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColorTool : VRTK_A_ToolAbstract {

    private MeshRenderer[] renderers;

    private Color originalColor;



    private void OnValidate()
    {
        renderers = GetComponentsInChildren<MeshRenderer>();
    }

    private void Awake()
    {
        originalColor = renderers[0].sharedMaterial.color;
    }

    private void OnApplicationQuit()
    {
        for (int i = 0; i < renderers.Length; ++i)
        {
            renderers[i].sharedMaterial.color = originalColor;
        }
    }

    protected override void OnObjectUsed()
    {
        Color color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        
        for(int i = 0; i < renderers.Length; ++i)
        {
            renderers[i].sharedMaterial.color = color;
        }
    }

}
