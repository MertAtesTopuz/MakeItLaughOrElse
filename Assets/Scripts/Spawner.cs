using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private int randSpawner;
    public NpcType[] typer;
    public GameObject npc;
    [SerializeField] private float spawnTime;
    public List<GameObject> npcList = new List<GameObject>();
    public GameObject spawnedNpc;
    public Vector3 firstObjTarget;
    public int distance;

    [Header("Prefab")]
    public GameObject npcType1;
    public GameObject npcType2;
    public GameObject npcType3;
    public GameObject npcType4;
    public GameObject npcType5;
    public GameObject npcType6;
    private int npcTypeRand;

    void Start()
    {
        if (UIController.instance.maxCapasity > UIController.instance.currentCapacity)
        {
            StartCoroutine(SpawnTimer());
        }
    }

    void Update()
    {
         NpcQueue();      
    }

    private void NpcQueue()
    {
        for (int i = 0; i < npcList.Count; i++)
        {
            if(npcList[i] == null)
            {
                npcList.RemoveAt(i);
                UIController.instance.currentCapacity --;
            }

            if(npcList.Count > 1)
            {
                firstObjTarget = npcList[i].GetComponent<NpcChooser>().targetVec;
                
            }
            
            if(i != 0 && npcList[i].GetComponent<NpcChooser>().targetVec == npcList[i].GetComponent<NpcChooser>().targetVecCheck)
            {
                npcList[i].GetComponent<NpcChooser>().targetVec = 
                new Vector2(npcList[i].GetComponent<NpcChooser>().targetVec.x, npcList[i-1].GetComponent<NpcChooser>().targetVec.y  - distance);
                
                if(npcList[i-1].GetComponent<NpcChooser>().targetVec != firstObjTarget)
                {
                    npcList[i].GetComponent<NpcChooser>().targetVec = firstObjTarget;
                }
                
            }
        }
    }

    private void NpcTypeChooser()
    {
        switch(npcTypeRand)
        {
            case 0:
            npc = npcType1;
            break;
            case 1:
            npc = npcType2;
            break;
            case 2:
            npc = npcType3;
            break;
            case 3:
            npc = npcType4;
            break;
            case 4:
            npc = npcType5;
            break;
            case 5:
            npc = npcType6;
            break;
        }
    }
    
    private IEnumerator SpawnTimer()
    {
        if (UIController.instance.maxCapasity > UIController.instance.currentCapacity)
        {
            npcTypeRand = Random.Range(0,6);
            NpcTypeChooser();
            randSpawner = Random.Range(0,typer.Length);
            npc.GetComponent<NpcChooser>().mainType = typer[randSpawner];
            yield return new WaitForSeconds(spawnTime);
            spawnedNpc = Instantiate(npc, transform.position, Quaternion.identity);
            npcList.Add(spawnedNpc);
            UIController.instance.currentCapacity ++;
        }
        
        StartCoroutine(SpawnTimer());
    }
}
