using UnityEngine;
using UnityEngine.UI; 
public class OptionSelector : MonoBehaviour
//i used unity forums to help me make this..
{
    public Text displayText; 

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collision detected!");

        Debug.Log("Collided object tag: " + other.gameObject.tag);

        if (other.CompareTag("GoodOption"))
        {
            DisplayMessage("Good option selected! Move towards goodness!");
        }
        else if (other.CompareTag("BadOption"))
        {
            DisplayMessage("Bad option selected! Avoid war!");
        }
    }


    void DisplayMessage(string message)
    {
        
        if (displayText != null)
        {
            
            displayText.text = message;
        }
        else
        {
            
            Debug.LogWarning("UI Text component not assigned!");
        }
    }
}
