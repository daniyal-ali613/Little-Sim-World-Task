using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothesAnimation : MonoBehaviour
{
    public Animator animator;
    private Vector2 movement;

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");


        this.animator.SetFloat("Horizontal", movement.x);
        this.animator.SetFloat("Vertical", movement.y);
        this.animator.SetFloat("Speed", movement.sqrMagnitude);
    }
}
