using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    private float runSpeed;
    private Rigidbody2D rigibody;

    void Start()
    {
        rigibody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rigibody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * runSpeed, Input.GetAxisRaw("Vertical") * runSpeed);
    }
}
