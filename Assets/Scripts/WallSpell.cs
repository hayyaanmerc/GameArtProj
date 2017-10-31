using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpell : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    public GameObject wall;
    private float duration = 2.5f;
    GameObject obj;
    public GameObject ground;
    int wallcount;
    //public WallInfo info = wall.GetComponent<WallInfo>();
    //public Camera camera;
    // Use this for initialization
    void Start()
    {
        //Destroy(prefab.gameObject, 2);
        //prefab.SetActive = false;
        wallcount = 0;

    }
    /*private IEnumerator WaitforNext() //waits for the next wall
    {
        yield return new WaitForSeconds(1.0f);
        //Debug.Log("WaitForNextStun Done");
    }*/
    private IEnumerator wallDuration() //destory wall after certain amount of time
    {
        yield return new WaitForSeconds(duration);
        obj.SetActive(false);
        wallcount = 0;
       // StartCoroutine(WaitforNext());

    }
    // Update is called once per frame
    void Update()
    {
         ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
       {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (wallcount == 0)
                {
                    wallcount = 1;
                    //if (counter < 1) {
                    obj = Instantiate(wall, /*transform.position + new Vector3(2, ground.transform.position.x, 0)*/new Vector3(hit.point.x, hit.point.y + 0.5f, 0), Quaternion.identity) as GameObject;
                    obj.SetActive(true); //sets active instead of destroying
                    StartCoroutine(wallDuration()); // Starts Wall duration
                                                    //counter++;
                                                    //}
                }

            }
        }
    }
}