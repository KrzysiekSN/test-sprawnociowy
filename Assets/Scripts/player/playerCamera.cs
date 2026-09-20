using UnityEngine;

public class playerCamera : MonoBehaviour
{
    [SerializeField] private GameObject gracz;
    [SerializeField] private GameObject kamera;

    void Update()
    {
        Vector3 graczPozycja = gracz.transform.position;
        kamera.transform.position = new Vector3(graczPozycja.x,graczPozycja.y+1,graczPozycja.z-10);
    }
}
