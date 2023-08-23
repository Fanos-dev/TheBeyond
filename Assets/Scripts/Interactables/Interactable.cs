using UnityEngine;

namespace Interactables
{
    public abstract class Interactable : MonoBehaviour
    {
        //Add remove an InteractionEvent component to this gameobject
        public bool useEvents;
        [SerializeField]
        //Message displayed to player when looking at interactable
        public string promptMessage;

        public virtual string OnLook()
        {
            return promptMessage;
        }

        //This function will be called from our player
        public void BaseInteract()
        {
            if(useEvents)
                GetComponent<InteractionEvent>().OnInteract.Invoke();
            Interact();
        }
        protected virtual void Interact()
        {
            //empty as it will be overwritten by subclasses
        }
    }
}
