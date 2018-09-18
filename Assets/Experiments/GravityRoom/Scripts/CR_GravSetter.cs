using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Controllables;

public class CR_GravSetter : MonoBehaviour {

    [SerializeField]
    private VRTK_BaseControllable controllable;

    private float initialGrav;



    private void Awake()
    {
        initialGrav = Physics.gravity.y;
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
        Physics.gravity = new Vector3(0, initialGrav * e.value, 0);
    }

}
