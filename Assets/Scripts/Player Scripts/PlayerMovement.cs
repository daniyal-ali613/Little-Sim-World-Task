using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    [SerializeField] float radius = 5f;
    [SerializeField] Transform shop;
    Vector2 movement;
    private float trans;
    float distanceToTarget = Mathf.Infinity;
    public DialogueTrigger trigger;

    private void Start()
    {
        trans = transform.localScale.x;
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");


        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        distanceToTarget = Vector3.Distance(shop.position, transform.position);

        if(distanceToTarget <= radius)
        {
            trigger.TriggerDialogue();
        }

        if(movement.x <= 0.0f)
        {
            trans = -1;
        }

        else
        {
            trans = 1;
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);

    }
}
