using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed = 5;
    private Vector2 _dir = Vector2.zero;
    
    private void Update()
    {
        Vector3 velocity = _dir * speed * Time.deltaTime;
        transform.position += velocity;
    }

    public void UpdateDirection(Vector2 pDir)
    {
        _dir = pDir;
    }
}