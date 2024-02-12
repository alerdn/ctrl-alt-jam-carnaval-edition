using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canva : MonoBehaviour
{
    public Animator Animator { get; private set; }
    [SerializeField] private Camera _camera;

    private void Start()
    {
        Animator = GetComponent<Animator>();
    }

    public void ActiveCanva()
    {
        Animator.CrossFadeInFixedTime("Active", .1f);
        _camera.cullingMask = LayerMask.GetMask("Hidden");
    }

    public void DeactiveCanva()
    {
        Animator.CrossFadeInFixedTime("Deactive", .1f);
        _camera.cullingMask = LayerMask.GetMask("Nothing");
    }
}
