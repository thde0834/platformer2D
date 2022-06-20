using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class TransitionEvent : ScriptableObject
{
    private List<Transition> transitions;

    private void OnEnable()
    {
        transitions = new List<Transition>();
    }

    private void OnDisable()
    {
        transitions = null;
    }

    public void Raise()
    {
        for (int i = transitions.Count - 1; i >= 0; i--)
        {
            transitions[i].OnEventRaised();
        }
    }

    public void RegisterListener(Transition transition)
    {
        if (!transitions.Contains(transition))
        {
            transitions.Add(transition);
        }
    }
    public void UnregisterListener(Transition transition)
    {
        if (transitions.Contains(transition))
        {
            transitions.Remove(transition);
        }
    }
}

