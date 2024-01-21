using UnityEngine;

public class MouseFollow: MonoBehaviour
{
    public float followSpeed = 5f; // �ll�that� sebess�g

    private void Update()
    {
        // Az eg�r poz�ci�j�nak lek�r�se
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Az objektum poz�ci�j�nak friss�t�se a v�zszintes (X tengely) k�vet�s alapj�n
        transform.position = new Vector3(mousePosition.x, transform.position.y, transform.position.z);
        Debug.Log(mousePosition);
    }
}
