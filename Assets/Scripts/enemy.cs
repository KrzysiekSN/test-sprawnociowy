using UnityEngine;

public class enemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet")
        {
            gameObject.GetComponent<health>().takeDamage(5);
            other.gameObject.GetComponent<bulletMove>().bulletDestroy(other.gameObject);
        }
    }
}
