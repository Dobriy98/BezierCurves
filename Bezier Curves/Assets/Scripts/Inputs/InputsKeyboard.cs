using UnityEngine;

namespace Inputs
{
    public class InputsKeyboard : MonoBehaviour
    {
        public delegate void Handler();
        public event Handler OnSpaceEvent;
        void Update()
        {
            if (Input.GetKey(KeyCode.Space))
            {
                OnSpaceEvent?.Invoke();
            }
        }
    }
}
