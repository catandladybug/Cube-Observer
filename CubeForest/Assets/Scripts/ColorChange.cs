using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour, IObserver
{
    [SerializeField] Subject _collisionSubject;

    Renderer ren;

    public void Start()
    {
        ren = GetComponent<Renderer>();
    }

    private void OnEnable()
    {
        _collisionSubject.AddObserver(this);
    }

    private void OnDisable()
    {
        _collisionSubject.RemoveObserver(this);
    }
    public void OnNotify()
    {
        ren.material.color = Color.black;
    }
}
