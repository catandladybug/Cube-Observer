using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMilestone : MonoBehaviour, IObserver
{
    [SerializeField] Subject _scoreSubject;

    public GameObject milestone;

    private void OnEnable()
    {
        _scoreSubject.AddObserver(this);
    }

    private void OnDisable()
    {
        _scoreSubject.RemoveObserver(this);
    }
    public void OnNotify()
    {
        milestone.SetActive(true);
    }
}
