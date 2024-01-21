using UnityEngine;

public class MouseFollow: MonoBehaviour
{
    public float followSpeed = 5f; // Állítható sebesség

    private void Update()
    {
        // Az egér pozíciójának lekérése
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Az objektum pozíciójának frissítése a vízszintes (X tengely) követés alapján
        transform.position = new Vector3(mousePosition.x, transform.position.y, transform.position.z);
        Debug.Log(mousePosition);
    }
}
