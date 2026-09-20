using JetBrains.Annotations;
using UnityEngine;

public class bulletPool : MonoBehaviour
{
    [SerializeField] public int bulletAmount; 
    public GameObject bulletPrefab;
    public GameObject bulletPoolParent;
    void Start()
    {
        for (int i = 0; i < bulletAmount; i++)
        {
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.SetActive(false);
            bullet.transform.SetParent(bulletPoolParent.transform);
        }

    }
}
