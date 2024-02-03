using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcChooser : MonoBehaviour
{
    private SpriteRenderer spi;
    public GameObject jokeSprite;
    public NpcType mainType;
    public Transform target;
    public Vector3 targetVec;
    public Vector3 targetVecCheck;
    public float speed;
    public GameObject path;
    public GameObject path1;
    public GameObject path2;
    public GameObject path3;
    public int randomChooserP;
    public List<Transform> targetPath = new List<Transform>();
    public int posI;
    public Transform traSetter;
    public NpcInterraction inter;

    void Start()
    {
        spi = GetComponent<SpriteRenderer>();
        target = GameObject.FindGameObjectWithTag("TargetPos").transform;
        path1 = GameObject.FindGameObjectWithTag("TargetPath1");
        path2 = GameObject.FindGameObjectWithTag("TargetPath2");
        path3 = GameObject.FindGameObjectWithTag("TargetPath3");
        RandomPath();
        targetVec = target.transform.position;
        targetVecCheck = target.transform.position;
        jokeSprite.GetComponent<SpriteRenderer>().sprite = mainType.jokeSpi;
        PosUpdater();
        StartCoroutine(PathAdder());
        traSetter.transform.position = targetVec; 
        targetPath[0] = traSetter;
    }

    void Update()
    {
        Move();
    }

    private void RandomPath()
    {
        randomChooserP = Random.Range(0,3);

        switch(randomChooserP)
        {
            case 0:
            path = path1;
            break;
        
            case 1:
            path = path2;
            break;

            case 2:
            path = path3;
            break;
        }
    }

    private void PosUpdater()
    {
        foreach (Transform child in path.transform)
        {
            targetPath.Add(child);
        }
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetVec, speed * Time.deltaTime);
    }

    private IEnumerator PathAdder()
    {
        

        if (transform.position == targetVec || transform.position == targetPath[posI].position)
        {
            if(posI < targetPath.Count -1)
            {
                
                if(TimeManager.instance.isNightS == false && inter.interControl == true)
                {
                    targetVec = targetPath[posI+1].position;
                    posI++;
                }
                else if(TimeManager.instance.isNightS == true || inter.interControl == false)
                {
                    Transform lastElement2 = targetPath[targetPath.Count -1];
                    targetVec = lastElement2.transform.position;
                }
            }
            else
            {
                Debug.Log("sa");
            }

            
        }
        yield return new WaitForSeconds(10);
        StartCoroutine(PathAdder());
        
    }
}
