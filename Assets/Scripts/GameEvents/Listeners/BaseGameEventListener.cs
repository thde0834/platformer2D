using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseGameEventListener
{
    public abstract void OnEventRaised(object item);
}

public abstract class BaseGameEventListener<T> : BaseGameEventListener
{
    public override void OnEventRaised(object item) => OnEventRaised((T) item);
    public abstract void OnEventRaised(T item);

}
