using UnityEngine;

public class CollisionFallingObjects : MonoBehaviour
{

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Player"))
            {
                other.gameObject.transform.position = new Vector3((float)36.8699989, (float)0.45, (float)119.029999);
                other.gameObject.transform.rotation = Quaternion.Euler(0, -180f, 0);
                other.rigidbody.velocity = Vector3.zero;
                Destroy(gameObject);
            }
    }

    private void Update() {
        if (gameObject.transform.position.y < -50){
            Destroy(gameObject);
        }
    }
}
    
