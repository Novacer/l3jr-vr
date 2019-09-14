
namespace GoogleVR.HelloVR
{
    using UnityEngine;
    using UnityEngine.EventSystems;
	using UnityEngine.UI;

    /// <summary>Controls interactable teleporting objects in the Demo scene.</summary>
    [RequireComponent(typeof(Collider))]
    public class ObjectController : MonoBehaviour
    {
        /// <summary>
        /// The material to use when this object is inactive (not being gazed at).
        /// </summary>
        public Material inactiveMaterial;

        /// <summary>The material to use when this object is active (gazed at).</summary>
        public Material gazedAtMaterial;

        private Vector3 startingPosition;
        private Renderer myRenderer;

        /// <summary>Sets this instance's GazedAt state.</summary>
        /// <param name="gazedAt">
        /// Value `true` if this object is being gazed at, `false` otherwise.
        /// </param>
        public void SetGazedAt(bool gazedAt)
        {
            if (inactiveMaterial != null && gazedAtMaterial != null)
            {
                myRenderer.material = gazedAt ? gazedAtMaterial : inactiveMaterial;
                return;
            }
        }

        /// <summary>Calls the Recenter event.</summary>
        public void Recenter()
        {
#if !UNITY_EDITOR
            GvrCardboardHelpers.Recenter();
#else
            if (GvrEditorEmulator.Instance != null)
            {
                GvrEditorEmulator.Instance.Recenter();
            }
#endif  // !UNITY_EDITOR
        }

        /// <summary>Open/Close the description box for a point of interest.</summary>
        /// <param name="eventData">The pointer click event which triggered this call.</param>
        public void TeleportRandomly(BaseEventData eventData)
        {
            // Only trigger on left input button, which maps to
            // Daydream controller TouchPadButton and Trigger buttons.
            PointerEventData ped = eventData as PointerEventData;
            if (ped != null)
            {
                if (ped.button != PointerEventData.InputButton.Left)
                {
                    return;
                }
            }
			
			foreach (Transform childContainer in transform) {
				GameObject child = childContainer.gameObject;
				child.SetActive(!child.active);
			}
		
        }

        private void Start()
        {
            startingPosition = transform.localPosition;
            myRenderer = GetComponent<Renderer>();
            SetGazedAt(false);
			
			this.setChildActive(false);
			
        }
		
		private void setChildActive(bool active) {
			foreach (Transform child in transform) {
				child.gameObject.SetActive(active);
			}
		}
		
		private void setChildTextMessage(string message) {
			foreach (Transform child in transform) {
				Text oldText = child.GetComponentInChildren<Text>();
				oldText.text = message;
			}
		}
    }
}
