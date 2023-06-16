using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemiesSpawner : MonoBehaviour
{
    [SerializeField] private int enemyCount;
    [SerializeField] private GameObject _enemyPrefab;
    
    public void EnemiesSpawn(ColorRandomizer _colorRandomizer, TransformRandomizer _transformRandomizer)
    {
        for (int i = 0; i < enemyCount; i++)
        {
            var newEnemy = Instantiate(_enemyPrefab, _transformRandomizer.GetCoordinate(),Quaternion.identity);
            var renderer = newEnemy.GetComponent<Renderer>();
            renderer.material.color = _colorRandomizer.GetColor();
        }
    }
}
