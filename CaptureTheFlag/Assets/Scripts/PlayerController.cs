using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Stats")]
    public float moveSpeed;
    public float jumpForce;
    public int curHp;
    public int maxHp;

    [Header("Mouse Look")]
    public float lookSensitivity;
    public float maxLookX;
    public float minLookX;
    private float rotX;
    private Camera camera;
    private Rigidbody rb;
    // private Weapon weapon;
    
    void Awake()
    {
       curHp = maxHp; 
    }

    void Start()
    {
        camera = Camera.main;
        rb = GetComponent<Rigidbody>();
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed;
        float z = Input.GetAxis("Vertical") * moveSpeed;
        Vector3 dir = transform.right * x + transform.forward * z;
        dir.y = rb.velocity.y;
        rb.velocity = dir;
    }

    void CamLook()
    {
        float y = Input.GetAxis("Mouse X") * lookSensitivity;
        rotX += Input.GetAxis("Mouse Y") * lookSensitivity;
        rotX = Mathf.Clamp(rotX, minLookX, maxLookX);
        camera.transform.localRotation = Quaternion.Euler(-rotX, 0, 0);
        transform.eulerAngles += Vector3.up * y;
    }

    void Jump()
    {
        Ray ray = new Ray(transform.position, Vector3.down);

        if(Physics.Raycast(ray, 1.1f))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
    
    public void TakeDamage(int damage)
    {
        curHp -= damage;

        if(curHp <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Player has died");
        Time.timeScale = 0;
    }
    public void GiveHealth()
    {
        Debug.Log("Player has been healed");
    }
    public void GiveAmmo()
    {
        Debug.Log("Player has collected Ammo");
    }

    void Update()
    {
        Move();
        CamLook();
        if(Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }
    
}
