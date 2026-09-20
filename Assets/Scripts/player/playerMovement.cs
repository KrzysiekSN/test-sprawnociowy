using System.Runtime.CompilerServices;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 500f;
    [SerializeField] private Rigidbody player;
    [SerializeField] private floorTouchy floorToucher;

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            player.AddForce(new Vector3(moveSpeed, 0, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            player.AddForce(new Vector3(-moveSpeed, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.Space) && floorToucher.isGround)
        {
            player.AddForce(new Vector3(0, jumpForce, 0));
            floorToucher.isGround = false;
        }
    }

}
