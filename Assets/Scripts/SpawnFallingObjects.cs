using UnityEngine;

public class SpawnFallingObjects : MonoBehaviour
{

    [SerializeField]
    private GameObject prefabFallingObject;

    [SerializeField]
    private Vector3 zoneSize;

    private void Start() {
        InvokeRepeating("SpawnObject", 3f, Random.Range(2f, 8f));  
    }

    private void SpawnObject(){
        GameObject instantiated = Instantiate(prefabFallingObject);

        instantiated.transform.position = new Vector3(
            Random.Range(transform.position.x - zoneSize.x/2, transform.position.x + zoneSize.x/2),
            transform.position.y,
            Random.Range(transform.position.z - zoneSize.z/2, transform.position.z + zoneSize.z/2));

    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube (transform.position, zoneSize);
    }
}
