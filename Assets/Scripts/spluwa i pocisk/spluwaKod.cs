using System;
using Unity.VisualScripting;
using UnityEngine;

public class spluwaKod : MonoBehaviour
{
    //to jest coś dla testów
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject spluwa;
    bool canShoot;
    float shootDelay;

    public bulletPool bp;

    void Update()
    {
        Vector3 patrzNaMysz = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);

        //float kontjgidsejkg = Mathf.Atan2(patrzNaMysz.x, patrzNaMysz.y) * Mathf.Rad2Deg;
        Vector3 kontjgidsejkg = patrzNaMysz.normalized;
        float kat = Mathf.Atan2(kontjgidsejkg.y, kontjgidsejkg.x) * Mathf.Rad2Deg;
        spluwa.transform.rotation = Quaternion.AngleAxis(kat -90, Vector3.forward); //90 żeby patrzyło na mysz

        if (Input.GetMouseButton(0))
        {
            if (bp.transform.childCount > 0 && canShoot)
            {
                GameObject bullet = bp.transform.GetChild(0).gameObject;
                bullet.SetActive(true);
                bullet.transform.position = spluwa.transform.position;
                bullet.transform.SetParent(null);
                canShoot = false;
                shootDelay = 0.5f;
                bullet.transform.rotation = spluwa.transform.rotation;
            }
        }
        if (shootDelay > 0)
        {
            shootDelay -= Time.deltaTime;
        }
        if (shootDelay <= 0) canShoot = true;
    }
}
