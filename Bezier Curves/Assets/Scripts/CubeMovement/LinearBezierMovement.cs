using System.Collections;
using UnityEngine;

namespace CubeMovement
{
    public class LinearBezierMovement : ICubeMovement
    {
        public IEnumerator MoveTo(Transform objectToMove, Vector3 target, float speed)
        {
            float t = 0;
            Vector3 startMovingPosition = objectToMove.position;
            while(t < 1)
            {
                t = Mathf.Clamp01(t + Time.deltaTime * speed);
                objectToMove.position = Bezier.LinearBezier(startMovingPosition, target, t);
                yield return null;
            }
        }
    }
}
