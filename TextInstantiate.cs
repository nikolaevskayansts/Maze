using UnityEngine;

public class InstText : MonoBehaviour
{
    public GameObject wallPref, textPref;
    public int numText = 40;
    GameObject[] textArr; 
    GameObject textClone;
    
    

    private void OnTriggerEnter(Collider other)
    {
        textArr = new GameObject[numText];

        if (other.tag == "Player")
        {
            for (int i = 0; i < numText; i++)
            {
                textClone = Instantiate(textPref, new Vector3(wallPref.transform.position.x,
                UnityEngine.Random.Range(-40, 50), wallPref.transform.position.z),
                wallPref.transform.rotation);
                Debug.Log("Instantiate");
                textArr[i] = textClone;
            }
            
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            for (int i = 0; i < numText; i++)
            {
                Destroy(textArr[i].gameObject);

                Debug.Log("Destroy");
            }
        }
    }

  
}
