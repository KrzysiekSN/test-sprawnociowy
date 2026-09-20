using UnityEngine;

public class floorTouchy : MonoBehaviour
{
    [SerializeField] public bool isGround;
    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Touched: " + collision.gameObject.tag);
        if (collision.gameObject.tag == "ground")
        {
            isGround = true;
        }
    }
}
