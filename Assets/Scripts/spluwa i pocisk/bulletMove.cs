using UnityEditor.UI;
using UnityEngine;

public class bulletMove : MonoBehaviour
{
    [SerializeField] int bulletSpeed;
    [SerializeField] float bulletDisappear=2;
    [SerializeField] GameObject objectPool;

    void Update()
    {
        Vector3 bulletMovement= transform.up *Time.deltaTime*bulletSpeed;
        GetComponent<Rigidbody>().MovePosition(transform.position + bulletMovement);
        bulletDisappear -= Time.deltaTime;
        if (bulletDisappear <= 0)
        {
            bulletDestroy(gameObject);
        }
    }
    public void bulletDestroy(GameObject obj)
    {
        GameObject objectPool = GameObject.Find("bulletPool"); //ono tutaj ustala bulletPool jako parent bo miałem problem z wrzuceniem tego w inspectorze
        obj.transform.SetParent(objectPool.transform);
        obj.SetActive(false);
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "ground")
        {
            bulletDestroy(gameObject);
        }
    }
}
