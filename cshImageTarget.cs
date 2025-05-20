using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshImageTarget : MonoBehaviour
{
    public bool Marker2;
    public bool Card1;
    public bool Marker3;
    public bool Card2;
    public bool Marker4;
    public bool Card3;
    public bool Marker6;
    public bool Card4;
    public bool Marker9;
    public bool Card5;
    public Transform picture;
    public GameObject medicine;
    public GameObject liver;
    bool hasLiver = false;
    public Transform mal_tf;
    bool isMoving1 = true;
    // bool isMoving2 = true;
    public Transform zara;
    bool isMoving3 = true;
    public Transform rabbit;
    public GameObject rabbitG;
    bool hasRabbitPic = false;
    public Transform rabbitPic_tf;
    public GameObject rabbitPic;
    bool isMoving4 = true;
    public Transform zaraRabbit;
    public GameObject notice2;
    public GameObject notice3;
    public GameObject notice4;
    public GameObject notice6;
    public GameObject notice9;
    bool zaraMoving1 = true;
    bool zaraMoving2 = true;
    bool zaraMoving3 = true;



    public void OnMarker2()
    {
        Marker2 = true;
    }

    public void OffMarker2()
    {
        Marker2 = false;
    }

    public void OnMarker3()
    {
        Marker3 = true;
    }

    public void OffMarker3()
    {
        Marker3 = false;
    }

    public void OnMarker4()
    {
        Marker4 = true;
    }

    public void OffMarker4()
    {
        Marker4 = false;
    }

    public void OnMarker6()
    {
        Marker6 = true;
    }

    public void OffMarker6()
    {
        Marker6 = false;
    }

    public void OnMarker9()
    {
        Marker9 = true;
    }

    public void OffMarker9()
    {
        Marker9 = false;
    }

    public void OnCard1()
    {
        Card1 = true;
    }

    public void OffCard1()
    {
        Card1 = false;
    }

    public void OnCard2()
    {
        Card2 = true;
    }

    public void OffCard2()
    {
        Card2 = false;
    }

    public void OnCard3()
    {
        Card3 = true;
    }

    public void OffCard3()
    {
        Card3 = false;
    }

    public void OnCard4()
    {
        Card4 = true;
    }

    public void OffCard4()
    {
        Card4 = false;
    }

    public void OnCard5()
    {
        Card5 = true;
    }

    public void OffCard5()
    {
        Card5 = false;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Card1 && Marker2)
        {
            Destroy(medicine, 1);
            Invoke("newLiver", 1f);
        }

        if (Card2 && Marker3)
        {
            pictureMove();
            Invoke("stopMoving1", 1.0f);
        }

        if (Card3 && Marker4)
        {
            zaraMove1();
            Invoke("zaraStop1", 1.0f);
            Invoke("zaraMove2", 1.0f);
            Invoke("zaraStop2", 2.0f);
            Invoke("zaraMove3", 2.0f);
            Invoke("zaraStop3", 3.0f);
        
            newRabbitPicture();
        } 

        
        

        if (Card4 && Marker6)
        {
            zaraRabbitMove();
            Invoke("stopMoving4", 2.5f);
        }

        if (Card5 && Marker9)
        {
            rabbitMove();
            Invoke("stopMoving3", 1.0f);
        }

    }


    void newRabbitPicture()
    {
        if (!hasRabbitPic)
        {
            Instantiate(rabbitPic, rabbitPic_tf.transform);
            hasRabbitPic = true;
        }
    }

    void pictureMove()
    {
        if (isMoving1)
        {
            picture.position += Vector3.left * 4 * Time.deltaTime;
        }
    }

    void stopMoving1()
    {
        isMoving1 = false;
    }

    void newLiver()
    {
        if (!hasLiver)
        {
            Instantiate(liver, mal_tf.transform);
            hasLiver = true;
        }
    }

    void zaraMove1()
    {
        if (zaraMoving1)
        {
            Vector3 moveDirection = Vector3.right + Vector3.back;
            zara.position += Vector3.right * 3 * Time.deltaTime;
            zara.position += Vector3.back * 3.5f * Time.deltaTime;
            zara.rotation = Quaternion.LookRotation(moveDirection.normalized);
        }
    }

    void zaraMove2()
    {
        if (zaraMoving2)
        {
            Vector3 moveDirection = Vector3.right + Vector3.forward;
            zara.position += Vector3.right * 3 * Time.deltaTime;
            zara.position += Vector3.forward * 3.5f * Time.deltaTime;
            zara.rotation = Quaternion.LookRotation(moveDirection.normalized);
        }
    }

    void zaraMove3()
    {
        if (zaraMoving3)
        {
            Vector3 moveDirection = Vector3.right + Vector3.back;
            zara.position += Vector3.right * 3 * Time.deltaTime;
            zara.position += Vector3.back * 3.5f * Time.deltaTime;
            zara.rotation = Quaternion.LookRotation(moveDirection.normalized);
        }
    }

    void zaraStop1()
    {
        zaraMoving1 = false;
    }

    void zaraStop2()
    {
        zaraMoving2 = false;
    }

    void zaraStop3()
    {
        zaraMoving3 = false;
    }


    void rabbitMove()
    {
        if (isMoving3)
        {
            Vector3 moveDirection = Vector3.right + Vector3.forward;
            rabbit.position += Vector3.right * 2 * Time.deltaTime;
            rabbit.position += Vector3.forward * 4 * Time.deltaTime;
            rabbit.rotation = Quaternion.LookRotation(moveDirection.normalized);
        }
    }

    void stopMoving3()
    {
        isMoving3 = false;
        Destroy(rabbitG);
    }

    void zaraRabbitMove()
    {
        if (isMoving4)
        {
            zaraRabbit.position += Vector3.right * 2.3f * Time.deltaTime;
            //zaraRabbit.position += Vector3.down * 10 * Time.deltaTime;
            zaraRabbit.position += Vector3.back * 2.2f * Time.deltaTime;

        }
    }

    void stopMoving4()
    {
        isMoving4 = false;
    }
}
