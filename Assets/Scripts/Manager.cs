using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Manager
{

}

public abstract class Manager<T> : Manager where T : class
{
    protected static Lazy<T> instance;

    public static T getInstance 
    { 
        get 
        { 
            if (instance == null)
            {
                instance = new Lazy<T>(() => Activator.CreateInstance(typeof(T), true) as T);
            }

            return instance.Value; 
        } 
    }

}
