using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenObject : MonoBehaviour
{
    private Collider _collider;

    private void Start()
    {
        _collider = GetComponent<Collider>();

        gameObject.layer = LayerMask.NameToLayer("Hidden");
    }

    private void OnBecameVisible()
    {
        _collider.enabled = true;
    }

    private void OnBecameInvisible()
    {
        _collider.enabled = false;
    }
}
