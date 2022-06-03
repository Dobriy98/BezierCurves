using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeMovement
{
    public class QuadraticBezierMovement : ICubeMovement
    {
        private Transform _p1;
        public QuadraticBezierMovement(Transform p1)
        {
            _p1 = p1;
        }
        public IEnumerator MoveTo(Transform objectToMove, Vector3 target, float speed)
        {
            if(_p1 == null) yield break;
            float t = 0;
            Vector3 startMovingPosition = objectToMove.position;
            while(t < 1)
            {
                t = Mathf.Clamp01(t + Time.deltaTime * speed);
                objectToMove.position = Bezier.QuadraticBezier(startMovingPosition, _p1.position, target, t);
                yield return null;
            }
        }
    }
}
