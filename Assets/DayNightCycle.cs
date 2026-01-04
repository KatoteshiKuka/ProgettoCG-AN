using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Impostazioni Ciclo")]
    public float daySpeed = 200.0f; 

    [Header("Collegamento Luci")]
    public Light nightLight; // Qui collegheremo la tua Point Light

    void Update()
    {
        // Ruota il sole costantemente
        transform.Rotate(Vector3.right * daySpeed * Time.deltaTime);

        // Controllo Notte: 
        // Se la direzione della luce (forward) punta verso l'alto (y > 0), è notte.
        if (nightLight != null)
        {
            nightLight.enabled = transform.forward.y > 0.1f;
        }
    }
}