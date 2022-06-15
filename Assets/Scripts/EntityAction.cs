using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EntityActionEnum
{
    Walk, Jump, Attack
}

public abstract class EntityAction : ScriptableObject
{
    public abstract EntityActionEnum EntityActionEnum { get; }
    public abstract void Perform();
}

[CreateAssetMenu(fileName = "Walk", menuName = "EntityActions/Walk")]
public class Walk : EntityAction
{
    public override sealed EntityActionEnum EntityActionEnum => EntityActionEnum.Walk;

    public override void Perform()
    {
        throw new System.NotImplementedException();
    }

}