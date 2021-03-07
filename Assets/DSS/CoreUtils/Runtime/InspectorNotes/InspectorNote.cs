using UnityEngine;

namespace DSS.CoreUtils.InspectorNotes
{
    public class InspectorNote : MonoBehaviour
    {
        public enum NoteType { None, Info, Warning, Error };

        [SerializeField] private string note = "Note";
        [SerializeField] NoteType type = NoteType.None;

        private void Start()
        {
            Destroy(this);
        }
    }
}