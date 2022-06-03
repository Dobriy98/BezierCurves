using UnityEngine;

public static class Bezier
{
    public static Vector3 LinearBezier(Vector3 p0, Vector3 p1, float t)
    {
        Vector3 point = (1 - t) * p0 + t * p1;
        return point;
    }
    public static Vector3 QuadraticBezier(Vector3 p0, Vector3 p1,Vector3 p2, float t)
    {
        Vector3 point = Mathf.Pow(1f-t, 2f) * p0 + 2f * (1f-t) * t * p1 + Mathf.Pow(t,2)*p2;
        return point;
    }
    public static Vector3 CubicBezier(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
    {
        Vector3 point = Mathf.Pow(1f - t, 3)*p0
                        + 3f*Mathf.Pow(1f-t, 2)*t*p1
                        + 3f*Mathf.Pow(1f-t, 2)* Mathf.Pow(t,2)* p2
                        + Mathf.Pow(t,3)*p3;
        return point;
    }
}
