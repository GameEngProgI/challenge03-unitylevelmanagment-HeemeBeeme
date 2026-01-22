using UnityEngine;

public class LevelChangeTrigger : MonoBehaviour
{
    public LevelManager levelManager;

    public GameObject ToLevel;
    public Transform SpawnPoint;

    private void Start()
    {
        levelManager = ServiceHub.Instance.levelManager;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Trigger Entered");

            levelManager.LevelChange(ToLevel, SpawnPoint);
        }
    }
}
