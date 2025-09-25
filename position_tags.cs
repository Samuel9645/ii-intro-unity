using UnityEngine;

public class position_tags : MonoBehaviour
{
    void FindAndPrintObjectsWithTag(string tag)
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag(tag);
        foreach (GameObject obj in objects)
        {
            Debug.Log("Object with tag " + tag + " named " + obj.name + " is at position " + obj.transform.position);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FindAndPrintObjectsWithTag("Characters");
        FindAndPrintObjectsWithTag("Enemies");
        FindAndPrintObjectsWithTag("Terrain");
        FindAndPrintObjectsWithTag("Structures");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
