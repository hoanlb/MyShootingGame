using System;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private SpawnerUnit []unitInfos;

    private void Update()
    {
        foreach(var unit in unitInfos)
        {
            unit.Timer += Time.deltaTime;
            if (unit.Timer >= unit.cooldown)
            {
                GameObject tmpPlaneArmy = Instantiate(unit.unitPrefab, new Vector3(UnityEngine.Random.Range(unit.minX, unit.maxX), 4, 0), Quaternion.identity);
                Destroy(tmpPlaneArmy, 20f);

                unit.Timer = 0;
            }
        }
    }

    [Serializable]
    public  class SpawnerUnit
    {
        [SerializeField]public GameObject unitPrefab;
        [SerializeField]public float cooldown;
        [SerializeField] public float minX;
        [SerializeField] public float maxX; 

        public float Timer=0;
    }


}
