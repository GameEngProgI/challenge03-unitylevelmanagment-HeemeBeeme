using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public GameObject Player;
    public Vector3 SpawnPoint;

    public GameObject To;
    public GameObject CurrentLevel;

    public void LevelChange()
    {
        CurrentLevel.SetActive(false);
        To.SetActive(true);

        Player.transform.position = SpawnPoint;
        CurrentLevel = To;
    }

}
