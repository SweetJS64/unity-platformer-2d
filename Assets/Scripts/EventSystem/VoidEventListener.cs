using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VoidEventListener : MonoBehaviour
{
    [SerializeField]
    private VoidEvent _channel = default;

    public UnityEvent OnEventRaised;

    private void OnEnable()
    {
        if (_channel != null)
        {
            _channel.OnEventRaised += Respond;
        }
    }

    private void OnDisable()
    {
        if (_channel != null)
        {
            _channel.OnEventRaised -= Respond;
        }
    }

    private void Respond()
    {
        if (OnEventRaised != null)
        {
            OnEventRaised.Invoke();
        }
    }
}
