using UnityEngine;

public class PlayerManager : MonoBehaviour, IGameManager
{
    public ManagerStatus status { get; private set; }

    public int health { get; private set; }
    public int maxHealth { get; private set; }

    public void Startup()
    {
        Debug.Log("Player manager starting...");

        //Do any player behavior needed to be done at start. etc: Player health setting starting values.
        health = 50;
        maxHealth = 100;

        status = ManagerStatus.Started;
    }

    public void ChangeHealth(int value)
    {
        health += value;
        if (health > maxHealth)
            health = maxHealth;
        else if (health == 0)
            health = 0;

        Debug.Log($"Health: {health}/{maxHealth}");
    }
}