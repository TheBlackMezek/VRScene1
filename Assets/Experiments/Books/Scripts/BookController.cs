using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookController : MonoBehaviour {

    [SerializeField]
    private float closeThreshold;
    [SerializeField]
    private bool startsClosed;

    [SerializeField]
    private VRTK.VRTK_InteractableObject interactable;
    [SerializeField]
    private VRTK.Controllables.PhysicsBased.VRTK_PhysicsRotator frontRotator;

    private bool closed;



    private void Awake()
    {
        frontRotator.ValueChanged += OnValueChanged;
        interactable.InteractableObjectUsed += OnBookUsed;
    }

    private void Start()
    {
        closed = startsClosed;
        if (closed)
        {
            frontRotator.SetValue(180f);
        }
        frontRotator.isLocked = startsClosed;
    }

    private void OnValueChanged(object sender, VRTK.Controllables.ControllableEventArgs e)
    {
        if (e.value >= closeThreshold)
        {
            closed = true;
            frontRotator.SetValue(180f);
            frontRotator.isLocked = true;
        }
    }

    private void OnBookUsed(object sender, VRTK.InteractableObjectEventArgs e)
    {
        if(closed)
        {
            closed = false;
            frontRotator.isLocked = false;
        }
    }

}
