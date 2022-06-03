using CubeMovement;
using CubeRotation;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Inputs
{
    public class InputPanel : MonoBehaviour, IPointerDownHandler
    {
        [SerializeField] private MainCube mainCube;
        private Camera _mainCam;
        private void Start()
        {
            _mainCam = Camera.main;
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            if (Physics.Raycast(InputRay(), out var hit))
            {
                mainCube.MoveWithRotation(hit.transform, new CubicBezierMovement(mainCube.p1,mainCube.p2), new RotateTowards());
            }
        }

        private Ray InputRay() => _mainCam.ScreenPointToRay(Input.mousePosition);
    }
}
