using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipeFrefab;
    public Transform spawnPosition;  
    public float delayPerSpawn;
    public Vector2 offsetPipeSpawn;
    
    private float currentTimeSpawn =0f;
    void Update()
    {
        if(GameManager.Instance.isStartGame==false) return;
        if (GameManager.Instance.isEndGame) return;
        if (currentTimeSpawn >= delayPerSpawn)
        {
            currentTimeSpawn = 0;
            SpawnPipe();
        }
        currentTimeSpawn = currentTimeSpawn + Time.deltaTime;
    }

    private void SpawnPipe()
    {
        GameObject pipe =Instantiate(pipeFrefab);
        pipe.transform.position = spawnPosition.position;
        var offset = Random.Range(offsetPipeSpawn.x, offsetPipeSpawn.y);
        pipe.transform.position += new Vector3(0, offset);
        
    }
}
