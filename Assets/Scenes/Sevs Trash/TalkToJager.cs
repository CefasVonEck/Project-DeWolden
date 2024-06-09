using UnityEngine;
using DialogueEditor;

public class TalkToJager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private NPCConversation jagerConvo;
    [SerializeField] private SpriteRenderer eSpriteRenderer; // Reference to the "E" sprite renderer
    private bool canStartConversation = false;
    void Start()
    {        
        // Ensure the eSpriteRenderer is initially hidden
        if (eSpriteRenderer != null)
        {
            eSpriteRenderer.enabled = false;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered interaction range");
            canStartConversation = true;        
            
            // Show the "E" sprite renderer
            if (eSpriteRenderer != null)
            {
                eSpriteRenderer.enabled = true;
            }

            
        }
        
    }

    private void Update()
    {
        // Check for "E" key press
        if (canStartConversation && Input.GetKeyDown(KeyCode.E))
        {
            // Start the conversation
            ConversationManager.Instance.StartConversation(jagerConvo);
            Debug.Log("Conversation started");

            // Optionally, hide the "E" sprite renderer after starting the conversation
            //if (eSpriteRenderer != null)
            //{
            //    eSpriteRenderer.enabled = false;
            //}
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Player left interaction range");
        canStartConversation = false;

        if (eSpriteRenderer != null)
        {
            eSpriteRenderer.enabled = false;
        }
       
    }


}
