using UnityEngine;

public class InstText : MonoBehaviour
{
    public GameObject wallPref, textPref;
     int numText = 30;
    GameObject[] textArr; 
    GameObject textClone;
    public int offsetVectorY;

    private void OnTriggerEnter(Collider other)
    {
        textArr = new GameObject[numText];
        Vector3 lastPos = new Vector3(wallPref.transform.position.x,
                -30, wallPref.transform.position.z);
        Vector3 offsetVector = new Vector3(0, offsetVectorY, 0);

        if (other.tag == "Player")
        {

            for (int i = 0; i < numText; i++)
            {
                if (lastPos.y < 30)
                {
                    textClone = Instantiate(textPref, lastPos + offsetVector,
                wallPref.transform.rotation);
                    lastPos = textClone.transform.position;
                    textArr[i] = textClone;
                    Debug.Log(numText);
                }
            }

        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            if (textArr.Length > 0)
            {
                for (int i = 0; i < numText; i++)
                {
                    Destroy(textArr[i].gameObject);
                    Debug.Log(numText);

                }
            }
        }
    }

}



