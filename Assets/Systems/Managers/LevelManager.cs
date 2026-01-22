using UnityEngine;

public class LevelManager : MonoBehaviour
{

    private GameObject player;
    private GameObject currentLevel;

    public void Start()
    {
        player = ServiceHub.Instance.playerController.gameObject;

        currentLevel = GameObject.FindGameObjectWithTag("Level");
    }

    public void LevelChange(GameObject to, Transform spawnPoint)
    {
        currentLevel.SetActive(false);
        to.SetActive(true);

        player.transform.position = spawnPoint.position;

        currentLevel = to;
    }

}
