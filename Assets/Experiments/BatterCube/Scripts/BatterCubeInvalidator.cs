using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatterCubeInvalidator : MonoBehaviour {

    [SerializeField]
    private string invalidTag;
    [SerializeField]
    private string heldTag;
    [SerializeField]
    private Material invalidMaterial;
    [SerializeField]
    private VRTK.VRTK_InteractableObject interactable;
    [SerializeField]
    private Renderer rndr;



    private void Awake()
    {
        interactable.InteractableObjectGrabbed += OnGrabbed;
        interactable.InteractableObjectUngrabbed += OnReleased;
    }

    private void OnGrabbed(object sender, VRTK.InteractableObjectEventArgs e)
    {
        gameObject.tag = heldTag;
        rndr.sharedMaterial = invalidMaterial;
    }

    private void OnReleased(object sender, VRTK.InteractableObjectEventArgs e)
    {
        gameObject.tag = invalidTag;
    }

}
