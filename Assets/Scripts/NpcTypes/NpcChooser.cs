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
    private Animator anim;
    private Rigidbody2D rb;
    private int randomTime;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
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

        anim.SetFloat("moveX", targetVec.x - transform.position.x);
        anim.SetFloat("moveY", targetVec.y - transform.position.y);
    }

    private IEnumerator PathAdder()
    {
        

        if (transform.position == targetVec || transform.position == targetPath[posI].position)
        {
            Transform lastElement2 = targetPath[targetPath.Count -1];

            if(posI < targetPath.Count -1)
            {
                if(TimeManager.instance.isNightS == false && inter.interControl == true)
                {
                    targetVec = targetPath[posI+1].position;
                    posI++;
                }
                else if(TimeManager.instance.isNightS == true || inter.interControl == false)
                {
                    targetVec = lastElement2.transform.position;
                } 
            }
            else
            {
                Debug.Log("sa");
            }

/*
            if(transform.position == lastElement2.position)
            {
                //Destroy(gameObject);
                Debug.Log("as");
            }
            */
            
        }

        anim.SetFloat("moveX", targetVec.x - transform.position.x);
        anim.SetFloat("moveY", targetVec.y - transform.position.y);

        randomTime = Random.Range(5,10);

        yield return new WaitForSeconds(randomTime);

        anim.SetFloat("lastMoveX", targetVec.x - transform.position.x);
        anim.SetFloat("lastMoveY", targetVec.y - transform.position.y);

        StartCoroutine(PathAdder());
        
    }
}
