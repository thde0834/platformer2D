using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] public struct Void 
{
    public static Void ToVoid(object item) => new Void();
}