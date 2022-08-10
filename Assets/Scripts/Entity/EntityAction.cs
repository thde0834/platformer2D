using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Entity/Actions/Action")]
public class EntityAction : ScriptableObject
{
    public void Perform()
    {
        Debug.Log("Performed");
    }
    
    public void Cancel()
    {
        Debug.Log("You've been banned from Twitter.");
    }
}
