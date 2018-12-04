using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move : MonoBehaviour {

    public int enemySpeed;
    public int xMoveDirection;
    private bool m_FacingRight = true;  // For determining which way the player is currently facing.

    // Update is called once per frame
    void Update () {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(xMoveDirection, 0));
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(xMoveDirection, 0) * enemySpeed;
        if (hit.distance < 1.5f)
        {
            Flip();
            if (hit.collider.tag == "Player")
            {
                GameOver.isGameOver = true;
            }
        }
	}

    void Flip()
    {
        // Switch the way the player is labelled as facing.
        m_FacingRight = !m_FacingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
        xMoveDirection *= -1;
    }
}
