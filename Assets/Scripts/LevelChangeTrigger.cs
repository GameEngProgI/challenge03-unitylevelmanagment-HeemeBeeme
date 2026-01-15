using UnityEngine;

public class LevelChangeTrigger : MonoBehaviour
{
    public LevelManager levelManager;

    public GameObject ToLevel;
    public Vector3 SpawnPoint;

    private void Start()
    {
        levelManager = ServiceHub.Instance.levelManager;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Trigger Entered");

            levelManager.SpawnPoint = SpawnPoint;
            levelManager.To = ToLevel;
            levelManager.LevelChange();
        }
    }
}
