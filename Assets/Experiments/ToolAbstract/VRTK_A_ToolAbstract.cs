using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//VRTK Addon: Tool Abstract



public abstract class VRTK_A_ToolAbstract : MonoBehaviour
{

    [SerializeField]
    protected VRTK.VRTK_InteractableObject interactableObject;



    protected virtual void OnEnable()
    {
        interactableObject.InteractableObjectGrabbed += ObjectGrabbedEvent;
        interactableObject.InteractableObjectTouched += ObjectUngrabbedEvent;
        interactableObject.InteractableObjectTouched += ObjectTouchedEvent;
        interactableObject.InteractableObjectUntouched += ObjectUnouchedEvent;
        interactableObject.InteractableObjectUsed += ObjectUsedEvent;
        interactableObject.InteractableObjectUnused += ObjectUnusedEvent;
    }

    protected virtual void OnDisable()
    {
        interactableObject.InteractableObjectGrabbed -= ObjectGrabbedEvent;
        interactableObject.InteractableObjectTouched -= ObjectUngrabbedEvent;
        interactableObject.InteractableObjectTouched -= ObjectTouchedEvent;
        interactableObject.InteractableObjectUntouched -= ObjectUnouchedEvent;
        interactableObject.InteractableObjectUsed -= ObjectUsedEvent;
        interactableObject.InteractableObjectUnused -= ObjectUnusedEvent;
    }



    private void ObjectGrabbedEvent(object sender, VRTK.InteractableObjectEventArgs e)
    {
        OnObjectGrabbed();
    }

    private void ObjectUngrabbedEvent(object sender, VRTK.InteractableObjectEventArgs e)
    {
        OnObjectUngrabbed();
    }

    private void ObjectTouchedEvent(object sender, VRTK.InteractableObjectEventArgs e)
    {
        OnObjectTouched();
    }

    private void ObjectUnouchedEvent(object sender, VRTK.InteractableObjectEventArgs e)
    {
        OnObjectUntouched();
    }

    private void ObjectUsedEvent(object sender, VRTK.InteractableObjectEventArgs e)
    {
        OnObjectUsed();
    }

    private void ObjectUnusedEvent(object sender, VRTK.InteractableObjectEventArgs e)
    {
        OnObjectUnused();
    }



    protected virtual void OnObjectGrabbed() { }
    protected virtual void OnObjectUngrabbed() { }
    protected virtual void OnObjectTouched() { }
    protected virtual void OnObjectUntouched() { }
    protected virtual void OnObjectUsed() { }
    protected virtual void OnObjectUnused() { }

}
