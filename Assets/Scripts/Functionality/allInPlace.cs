using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class allInPlace : MonoBehaviour
{
    public GameObject C2;
    public GameObject G2;
    public GameObject G1;
    public GameObject C1;
    public GameObject T1;
    public GameObject A1;
    public GameObject G;
    public GameObject T;
    public GameObject C;
    public GameObject A;
    public GameObject guide;

    bool cor = false;

    // Start is called before the first frame update
    void Start()
    {
        guide.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (((C1.transform.position.x < T1.transform.position.x) || (C2.transform.position.x < T1.transform.position.x))
            && (T1.transform.position.x < G.transform.position.x) 
            && ((G.transform.position.x < C1.transform.position.x) || (G.transform.position.x < C2.transform.position.x))
            && ((C1.transform.position.x < A1.transform.position.x) && (C2.transform.position.x < A1.transform.position.x))
            && ((G1.transform.position.x < A.transform.position.x) || (G2.transform.position.x < A.transform.position.x))
            && (A.transform.position.x < C.transform.position.x)
            && ((C.transform.position.x < G1.transform.position.x) || (C.transform.position.x < G2.transform.position.x))
            && ((G1.transform.position.x < T.transform.position.x) && (G2.transform.position.x < T.transform.position.x))
            && (G1.transform.position.y <= -2f && G1.transform.position.y >= -4f)
            && (G2.transform.position.y <= -2f && G2.transform.position.y >= -4f)
            && (T.transform.position.y <= -2f && T.transform.position.y >= -4f)
            && (A.transform.position.y <= -2f && A.transform.position.y >= -4f)
            && (C.transform.position.y <= -2f && C.transform.position.y >= -4f)
            && (C1.transform.position.y <= 1f && C1.transform.position.y >= -1f)
            && (C2.transform.position.y <= 1f && C2.transform.position.y >= -1f)
            && (T1.transform.position.y <= 1f && T1.transform.position.y >= -1f)
            && (G.transform.position.y <= 1f && G.transform.position.y >= -1f)
            && (A1.transform.position.y <= 1f && A1.transform.position.y >= -1f)) // comment
        {
            cor = true;
        } else
        {
            cor = false;
        }

        if (!cor)
        {
           guide.SetActive(false);
        }

        if (cor)
        {
            Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAA");
            guide.SetActive(true);
            if (Input.GetKeyDown("return"))
            {
                SceneManager.LoadScene(sceneName: "Stage4");
            }
        }
    }
}
