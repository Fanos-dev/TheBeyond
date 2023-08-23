using Interactables;
using UnityEditor;

namespace Editor
{
    [CustomEditor(typeof(Interactable),true)]
    public class InteractableEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            Interactable interactable = (Interactable)target;
            if (target.GetType() == typeof(EventOnlyInteractable))
            {
                interactable.promptMessage = EditorGUILayout.TextField("Prompt Message", interactable.promptMessage);
                EditorGUILayout.HelpBox("EventOnlyInteract can Only use UnityEvents.", MessageType.Info);
                if (interactable.GetComponent<InteractionEvent>() != null) return;
                interactable.useEvents = true;
                interactable.gameObject.AddComponent<InteractionEvent>();
            }
            else
            {
                base.OnInspectorGUI();
                if (interactable.useEvents)
                {
                    if (interactable.GetComponent<InteractionEvent>() == null)
                        interactable.gameObject.AddComponent<InteractionEvent>();
                }
                else
                {
                    //We are not using events,remove component
                    if (interactable.GetComponent<InteractionEvent>() != null)
                    {
                        DestroyImmediate(interactable.GetComponent<InteractionEvent>());
                    }
                }
            }
        }
    }
}
