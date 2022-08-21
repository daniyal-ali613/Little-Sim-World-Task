using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    public Transform shop;
    DialogueTrigger dialogueTrigger;
    public float radius;
    public bool movePlayer;
    public AudioSource waterSplash;
    public  Transform water;
    public float minDist;

    public List <GameObject> clothes = new List<GameObject>();
    public List<Sprite> shirt = new List<Sprite>();
    public List<Sprite> pant =  new List<Sprite>();
    public List<Sprite> cap =   new List<Sprite>();
    float dist;
    Vector2 movement;


    void Start()
    {
       movePlayer = true;
       dialogueTrigger =  FindObjectOfType<DialogueTrigger>();
       waterSplash.Stop();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");


        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        dist = Vector3.Distance(water.position, transform.position);


        if (dist < minDist)
        {
            waterSplash.Play();
        }

        else
        {
            waterSplash.Stop();
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("shop"))
        {
            movePlayer = false;
            animator.SetFloat("Speed", 0);
            animator.enabled = false;
            dialogueTrigger.TriggerDialogue();
        }
    }

    private void FixedUpdate()
    {
        if(movePlayer == true)
        {
          rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);
        }
    }

}
