using UnityEngine;
using System.Collections;

public class setCubes : MonoBehaviour
{

    public GameObject[] obj;
    public GameObject[] objSky;
    public GameObject number;

    [ContextMenu("Arrange")]
    public void Arrange()
    {
        //for (int i = 0; i < 10; i++ )
        //{
        //    for (int j = 0; j < 10; j++)
        //    {
        //        int o = Random.Range(0, obj.Length);
        //        int r = Random.Range(1, 10);
        //        GameObject e = new GameObject();
        //        e.transform.position = Vector3.zero;
        //        GameObject g = Instantiate(obj[o], new Vector3(i, 0, j), Quaternion.identity) as GameObject;
        //        g.transform.Rotate(0, r * 90, 0);
        //        e.transform.name = i + ":" + j;
        //        g.transform.name = i + ":" + j;
        //        g.transform.SetParent(e.transform);
        //        GameObject gg = Instantiate(number) as GameObject;
        //        gg.transform.SetParent(g.transform);
        //        gg.transform.position = new Vector3(i, 0.5f, j);
        //        gg.GetComponent<TextMesh>().text = ((i + 1) * (j + 1)).ToString();
        //    }
        //}
        int counter = 1;
        GameObject allparent = new GameObject();
        allparent.name = "Cubes Parent";
        allparent.transform.position = Vector3.zero;
        for (int i = 0; i < 10; i += 2)
        {
            for (int j = 0; j < 10; j++)
            {
                int o = Random.Range(0, obj.Length);
                int r = Random.Range(1, 10);
                GameObject e = new GameObject();
                e.transform.position = Vector3.zero;
                GameObject g = Instantiate(obj[o], new Vector3(j, 0, i), Quaternion.identity) as GameObject;
                g.AddComponent<BoxCollider>();
                g.transform.Rotate(0, r * 90, 0);
                e.transform.name = i + ":" + j;
                g.transform.name = i + ":" + j;
                g.transform.SetParent(e.transform);
                GameObject gg = Instantiate(number) as GameObject;
                gg.transform.SetParent(g.transform);
                gg.transform.position = new Vector3(j, 0.5f, i);
                gg.GetComponent<TextMesh>().text = counter.ToString();
                e.transform.SetParent(allparent.transform);
                counter++;
            }

            for (int j = 9; j >= 0; j--)
            {
                int o = Random.Range(0, obj.Length);
                int r = Random.Range(1, 10);
                GameObject e = new GameObject();
                e.transform.position = Vector3.zero;
                GameObject g = Instantiate(obj[o], new Vector3(j, 0, i + 1), Quaternion.identity) as GameObject;
                g.AddComponent<BoxCollider>();
                g.transform.Rotate(0, r * 90, 0);
                e.transform.name = i + ":" + j;
                g.transform.name = i + ":" + j;
                g.transform.SetParent(e.transform);
                GameObject gg = Instantiate(number) as GameObject;
                gg.transform.SetParent(g.transform);
                gg.transform.position = new Vector3(j, 0.5f, i + 1);
                gg.GetComponent<TextMesh>().text = counter.ToString();
                e.transform.SetParent(allparent.transform);

                counter++;
            }

        }
    }


    [ContextMenu("ArrangeSkyRock")]
    public void ArrangeSkyRock()
    {
        for (int i = 0; i < 50; i++)
        {
            int x = Random.Range(-10, 20);
            int y = Random.Range(-10, 20);
            int z = Random.Range(-10, 20);
            int o = Random.Range(0, objSky.Length);
            int r = Random.Range(1, 10);
            GameObject g = Instantiate(objSky[o], Vector3.zero, Quaternion.identity) as GameObject;
            g.transform.Rotate(0, 0, 0);
            g.transform.position = new Vector3(x, y, z);
            g.transform.name = "SkyRock" + " : " + i;
        }
    }
    void OnEnable()
    {

    }

}
