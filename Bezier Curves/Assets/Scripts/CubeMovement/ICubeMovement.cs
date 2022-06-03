using System.Collections;
using UnityEngine;

namespace CubeMovement
{
    public interface ICubeMovement
    {
        IEnumerator MoveTo(Transform objectToMove, Vector3 target, float speed);
    }
}
