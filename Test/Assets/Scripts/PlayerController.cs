using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    //Player movement
   public PlayerAction inputaction;
    Vector2 move;
    Vector2 rotate;
    private float walkspeed = 5f;
    public Camera playerCamera;
    Vector3 cameraRotation;

    //Jump
    Rigidbody rb;
    private float distancetoground;
    private bool isGrounded = true;
    public float jump = 5f;

    //Player animation 
    Animator Playeranimator;
    private bool iswalking = false;

    //Projectile bullets
    public GameObject bullet;
    public Transform projectilePos;

    private void OnEnable() 
    {
        inputaction.Player.Enable();
    }
    private void OnDisable()
    {
        inputaction.Player.Disable();
    }

    // Start is called before the first frame update
    void Awake()
    {
        if(!instance)
        {
            instance = this;
        }

        inputaction = new PlayerAction();

        inputaction.Player.Move.performed += cntxt => move = cntxt.ReadValue<Vector2>();
        inputaction.Player.Move.canceled += cntxt => move = Vector2.zero;

        inputaction.Player.Jump.performed += cntxt => Jump();

        inputaction.Player.Shoot.performed += cntxt => Shoot();
        
        rb = GetComponent<Rigidbody>();
        Playeranimator = GetComponent<Animator>();
        distancetoground = GetComponent<Collider>().bounds.extents.y;
    }
    private void Jump()
    {
        if (isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jump);
            isGrounded = false;
        }
    }

        public void Shoot()
        {
        Rigidbody bulletRb = Instantiate(bullet, projectilePos.position, Quaternion.identity).GetComponent<Rigidbody>();
        bulletRb.AddForce(transform.forward * 32f, ForceMode.Impulse);
        bulletRb.AddForce(transform.up * 5f, ForceMode.Impulse);
        }
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * move.y * Time.deltaTime * walkspeed,Space.Self);
        transform.Translate(Vector3.right * move.x * Time.deltaTime * walkspeed, Space.Self);

        isGrounded = Physics.Raycast(transform.position, -Vector3.up, distancetoground);

    }
}
