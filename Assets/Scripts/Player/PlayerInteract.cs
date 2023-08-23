using System;
using Interactables;
using UnityEngine;

namespace Player
{
    public class PlayerInteract : MonoBehaviour
    {
        private Camera cam;
        [SerializeField]
        private float distance = 3f;
        [SerializeField]
        private LayerMask mask;

        private PlayerUI playerUI;

        private InputManager inputManager;
        
        private void Start()
        {
            cam = GetComponent<PlayerLook>().cam;
            playerUI = GetComponent<PlayerUI>();
            inputManager = GetComponent<InputManager>();
        }

        
        private void Update()
        {
            playerUI.UpdateText(String.Empty);
            
            //Create a ray at the center of the camera, shooting outwards
            Transform camTransform = cam.transform;
            Ray ray = new Ray(camTransform.position, camTransform.forward);
            
            Debug.DrawRay(ray.origin, ray.direction * distance);
            RaycastHit hitInfo; //Store collision information

            if (Physics.Raycast(ray, out hitInfo, distance, layerMask: mask))
            {
                if (hitInfo.collider.GetComponent<Interactable>() != null)
                {
                    Interactable interactable = hitInfo.collider.GetComponent<Interactable>();
                    playerUI.UpdateText(interactable.promptMessage);
                    if (inputManager.onFoot.Interact.triggered)
                    {
                        interactable.BaseInteract();
                    }
                }
            }
        }
    }
}
