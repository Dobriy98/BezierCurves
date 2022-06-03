using System.Collections;
using UnityEngine;

namespace CubeRotation
{
    public class RotateTowards : ICubeRotation
    {
        public IEnumerator Rotate(Transform cubeToRotate, Quaternion target, float speed)
        {
            float t = 0;
            Quaternion startRotation = cubeToRotate.transform.rotation;
            while(t < 1)
            {
                t = Mathf.Clamp01(t + Time.deltaTime * speed);
                
                cubeToRotate.transform.rotation = Quaternion.Lerp(startRotation, target, t);
                yield return null;
            }
        }
    }
}
