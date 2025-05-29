// Ejemplo: Un script que maneja la muerte del jugador
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [Tooltip("El GameEvent que se disparar� cuando el jugador muera.")]
    [SerializeField] private GameEvent playerDiedEvent; // Arrastra aqu� tu "OnPlayerDeathEvent.asset"

    public int currentHealth = 100;

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("Player has died!");
        // Disparar el evento
        if (playerDiedEvent != null)
        {
            playerDiedEvent.Raise();
        }
        // Aqu� ir�a m�s l�gica de muerte, como destruir el GameObject, etc.
    }
    private void Update()
    {
        if(currentHealth <= 0)
        {
            Die();
        }
    }
}