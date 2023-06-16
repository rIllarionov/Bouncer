using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        var playerColor = other.gameObject.GetComponent<Renderer>().material.color;
        var enemyColor = GetComponent<Renderer>().material.color;

        if (enemyColor==playerColor)
        {
            Destroy(transform.gameObject);
        }
    }
}