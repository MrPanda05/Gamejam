using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    Animator anim;

    internal string currentState;


    internal const string idle = "Idle";
    internal const string IdleUp = "IdleUp";
    internal const string IdleRight = "IdleRight";
    internal const string IdleLeft = "IdleLeft";
    internal const string Walking = "Walking";
    internal const string WalkingUp = "WalkingUp";
    internal const string WalkingRight = "WalkingRight";
    internal const string WalkingLeft = "WalkingLeft";

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    internal void ChangeAnimationState(string newState)
    {
        if (currentState == newState) return;

        anim.Play(newState);

        currentState = newState;
    }

}
