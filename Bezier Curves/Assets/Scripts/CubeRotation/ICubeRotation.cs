using System.Collections;
using UnityEngine;

namespace CubeRotation
{
    public interface ICubeRotation
    {
        IEnumerator Rotate(Transform cubeToRotate, Quaternion target, float speed);
    }
}
