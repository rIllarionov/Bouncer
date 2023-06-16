using UnityEngine;
public class GameController : MonoBehaviour
{
    [SerializeField] private EnemiesSpawner _enemiesSpawner;
    [SerializeField] private ColorRandomizer _colorRandomizer;
    [SerializeField] private TransformRandomizer _transformRandomizer;
    [SerializeField] private PlayerController playerController;
    [SerializeField] private SphereController _sphereController;

    private void Awake()
    {
        _enemiesSpawner.EnemiesSpawn(_colorRandomizer,_transformRandomizer);
        _sphereController.SphereInitialize(_colorRandomizer,_transformRandomizer);
        playerController.PlayerSpawn();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            playerController.PlayerMover();
        }
    }
    
}
