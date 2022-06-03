using System.Collections;
using UnityEngine;

namespace CubeMovement
{
    public class CubicBezierMovement : ICubeMovement
    {
        private Transform _p1;
        private Transform _p2;

        public CubicBezierMovement(Transform p1, Transform p2)
        {
            _p1 = p1;
            _p2 = p2;
        }
        public IEnumerator MoveTo(Transform objectToMove, Vector3 target, float speed)
        {
            if(_p1 == null || _p2 == null) yield break;
            float t = 0;
            Vector3 startMovingPosition = objectToMove.position;
            while(t < 1)
            {
                t = Mathf.Clamp01(t + Time.deltaTime * speed);
                objectToMove.position = Bezier.CubicBezier(startMovingPosition, 
                                                                        _p1.position,
                                                                        _p2.position,
                                                                        target, t);
                yield return null;
            }
        }
    }
}
