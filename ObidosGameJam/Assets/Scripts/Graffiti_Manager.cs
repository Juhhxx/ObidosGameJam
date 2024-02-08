using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graffiti_Manager : MonoBehaviour
{
    [SerializeField] private GameObject graffitySpr;
    private Vector3 center;
    private Vector3 size;
    public float defacedNum;
    [SerializeField] private float maxDefacedNum;
    [SerializeField] private float min, max;

    // Start is called before the first frame update
    void Start()
    {
        center = gameObject.transform.position;
        size = gameObject.transform.localScale;
        Invoke("SpawnGraffity",1.5f);
    }

    // Update is called once per frame
    void SpawnGraffity()
    {
        Vector3 randomSpawnPoint = new Vector3(Random.Range(center.x - size.x/2,center.x + size.x/2),Random.Range(center.y - size.y/2,center.y + size.y/2),center.z);
        GameObject temp = Instantiate(graffitySpr, randomSpawnPoint, Quaternion.identity, transform);
        temp.transform.Rotate(0f ,180f, 0f);
        float randomTime = Random.Range(min,max + 1);
        defacedNum += 1;
        Debug.Log(defacedNum);

        Invoke("SpawnGraffity",randomTime);
    }
}
