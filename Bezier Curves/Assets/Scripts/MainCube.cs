using CubeMovement;
using CubeRotation;
using Inputs;
using UnityEngine;

public class MainCube : MonoBehaviour
{
    public Transform p1, p2;
    public float speed = 0.3f;
    
    [SerializeField] private InputsKeyboard inputsKeyboard;
    
    private Vector3 _initPosition;
    private Quaternion _initRotation;


    private void Start()
    {
        inputsKeyboard.OnSpaceEvent += MoveWithRotationToInit;
        
        _initPosition = transform.position;
        _initRotation = transform.rotation;
    }

    public void MoveWithRotation(Transform target, ICubeMovement cubeMovement, ICubeRotation cubeRotation)
    {
        StopMotion();
        MoveTo(target.position, cubeMovement);
        RotateCubeTo(target.rotation, cubeRotation);
    }

    public void MoveWithRotation(Vector3 targetPosition, Quaternion targetRotation, ICubeMovement cubeMovement,
        ICubeRotation cubeRotation)
    {
        StopMotion();
        MoveTo(targetPosition, cubeMovement);
        RotateCubeTo(targetRotation, cubeRotation);
    }
    private void MoveWithRotationToInit()
    {
        MoveWithRotation(_initPosition, _initRotation, new LinearBezierMovement(), new RotateTowards());
    }

    public void MoveTo(Vector3 target, ICubeMovement cubeMovement)
    {
        StartCoroutine(cubeMovement.MoveTo(transform, target, speed));
    }

    public void RotateCubeTo(Quaternion target, ICubeRotation cubeRotation)
    {
        StartCoroutine(cubeRotation.Rotate(transform, target, speed));
    }


    private void StopMotion()
    {
        StopAllCoroutines();
    }
}
