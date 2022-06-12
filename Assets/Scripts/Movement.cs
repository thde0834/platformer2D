using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public static class Movement
{
    private static Vector2 workspace;

    public static void SetVelocityX(Rigidbody2D rb, float velX)
    {
        workspace.Set(velX, rb.velocity.y);
        rb.velocity = workspace;
    }

    public static void SetVelocityY(Rigidbody2D rb, float velY)
    {
        workspace.Set(rb.velocity.x, velY);
        rb.velocity = workspace;
    }
}