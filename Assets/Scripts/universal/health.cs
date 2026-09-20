using UnityEngine;

public class health : MonoBehaviour
{
    [SerializeField] public float currentHealth;
    [SerializeField] public float maxHealth;

    public void takeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("otrzymane obrażenia: "+ damage);
    }
}
