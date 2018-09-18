using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Controllables;

public class CR_LightSetter : MonoBehaviour {

    [SerializeField]
    private VRTK_BaseControllable controllable;
    [SerializeField]
    private Light[] lights;

    private float[] initialIntensities;



    private void Awake()
    {
        initialIntensities = new float[lights.Length];

        for (int i = 0; i < lights.Length; ++i)
        {
            initialIntensities[i] = lights[i].intensity;
        }
    }

    private void OnEnable()
    {
        controllable.ValueChanged += OnValueChanged;
    }

    private void OnDisable()
    {
        controllable.ValueChanged -= OnValueChanged;
    }

    private void OnValueChanged(object sender, ControllableEventArgs e)
    {
        Debug.Log(e.value);
        for(int i = 0; i < lights.Length; ++i)
        {
            lights[i].intensity = Mathf.Lerp(initialIntensities[i], 0f, e.value);
        }
    }

}
