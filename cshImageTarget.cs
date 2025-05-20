using UnityEngine;
using Vuforia;

public class ImageTarget: MonoBehaviour
{
    public bool Marker3;
    public bool AxCard;
    public bool Marker6;
    public bool WindCard;
    public bool Marker9;
    public bool FireCard;
    public GameObject tree1;
    public GameObject brokenTree;
    public Transform brokenTree_tf;
    public Transform house1;
    public GameObject house1G;
    public Transform wolf;
    public GameObject wolfG;
    public Transform fire_tf;
    public GameObject fire;
    public Transform smoke_tf;
    public GameObject smoke;
    bool hasFired = false;
    bool hasTree = false;
    bool isMoving1 = true;
    bool isMoving2 = true;
    public GameObject woodBreakParticle;
    public GameObject notice3;
    public GameObject notice6;
    public GameObject notice9;

    public void OnMarker3()
    {
        Marker3 = true;
    }

    public void OffMarker3()
    {
        Marker3 = false;
    }

    public void OnAxCard()
    {
        AxCard = true;
    }

    public void OffAxCard()
    {
        AxCard = false;
    }

    public void OnMarker6()
    {
        Marker6 = true;
    }

    public void OffMarker6()
    {
        Marker6 = false;
    }

    public void OnWindCard()
    {
        WindCard = true;
    }

    public void OffWindCard()
    {
        WindCard = false;
    }

    public void OnMarker9()
    {
        Marker9 = true;
    }

    public void OffMarker9()
    {
        Marker9 = false;
    }

    public void OnFireCard()
    {
        FireCard = true;
    }

    public void OffFireCard()
    {
        FireCard = false;
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        if(AxCard && Marker3)  	
        {
            Destroy(tree1, 1);
            Destroy(notice3);
            Invoke("newTree", 1f);
            
        }

        if(WindCard && Marker6)  
        {
            Destroy(notice6);
            houseMove();
            Invoke("StopMoving1", 2f);
        }

        if(FireCard && Marker9)    
        {
            Destroy(notice9);
            if (!hasFired)
            {
                Instantiate(fire, fire_tf.position, fire_tf.rotation);
                Instantiate(smoke, smoke_tf.position, smoke_tf.rotation);
                hasFired = true; // 파이어가 생성되었음을 표시합니다.
            }
            Invoke("wolfMove", 3f);
            Invoke("StopMoving2", 4.5f);
        }

    
    }

    void houseMove()
    {
        if (isMoving1)
        {
            house1.position += Vector3.right * 4 * Time.deltaTime;
        }

    }

    void wolfMove()
    {
        if (isMoving2)
        {
            // 왼쪽 방향으로 이동합니다.
            wolf.position += Vector3.left * 4 * Time.deltaTime;
        }
    }

    void newTree()
    {
        if (!hasTree)
        {
            Instantiate(woodBreakParticle, brokenTree_tf.localPosition, Quaternion.identity);
            Instantiate(brokenTree, brokenTree_tf.transform);
            //brokenTree.localScale = new Vector3(2.0f, 2.0f, 2.0f);
            hasTree = true;
            Invoke("DestroyParticle", 1.5f);
        }
    }

    void StopMoving1()
    {
        isMoving1 = false;
        Destroy(house1G);
    }

    void StopMoving2()
    {
        isMoving2 = false;
        Destroy(wolfG);
    }

    void DestroyParticle()
    {
        Destroy(woodBreakParticle);
    }
    
}
