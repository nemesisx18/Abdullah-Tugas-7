using System.Collections.Generic;
using UnityEngine;

public class MushroomSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _objPrefab;
    [SerializeField] private List<GameObject> _pooledMushroom;
    private Vector3 _spawnPos;

    float timer;

    private void Start()
    {
        _spawnPos = transform.position;
        _pooledMushroom = new List<GameObject>();
        PoolMushroom();

    }
    private void FixedUpdate()
    {
        PoolMushroom();
    }

    void PoolMushroom()
    {
        GameObject mushroom = _pooledMushroom.Find(x => !x.gameObject.activeSelf);
        if (mushroom == null)
        {
            mushroom = Instantiate(_objPrefab, _spawnPos, Quaternion.identity, transform);
            _pooledMushroom.Add(mushroom);
        }

        ConfigSpawnedObject(mushroom);
    }

    private void ConfigSpawnedObject(GameObject baseObject)
    {
        baseObject.transform.position = _spawnPos;
        baseObject.gameObject.SetActive(true);
    }
}
