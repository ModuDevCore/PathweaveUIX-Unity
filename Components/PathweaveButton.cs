using UnityEngine.UI;
using UnityEngine.EventSystems;
using ModuDevCore.PathweaveUIX.Runtime.Actions;

namespace ModuDevCore.PathweaveUIX.Runtime.UI
{
    public class PathweaveButton : Button
    {
        public PathweaveAction action = new();

        protected override void Awake()
        {
            base.Awake();
        }

        public override void OnPointerClick(PointerEventData eventData)
        {
            base.OnPointerClick(eventData);

            action.InvokeSelected();
        }
    }
}