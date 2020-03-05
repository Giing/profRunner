using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.ThirdPerson;

public class CollisionDetector : MonoBehaviour
{
    private ThirdPersonCharacter character;
    private Vector3 movement;

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Runner")
        {
            //SceneManager.LoadScene("GameOver");
        }
        /*else if(collision.gameObject.tag == "SlowZone")
        {
            HitSlowZone();
        }*/
    }

    /*private void HitSlowZone()
    {
        character = GetComponent<ThirdPersonCharacter>();
        character.Move(movement, false, false);
        Debug.Log("oui");
    }*/

}
