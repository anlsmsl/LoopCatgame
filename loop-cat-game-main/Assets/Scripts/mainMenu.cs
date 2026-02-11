using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    // Panel objelerini Unity Inspector üzerinden sürükleyip bağlayacağız
    public GameObject gelistiriciPaneli;
    public GameObject anaMenuObjeleri; // Opsiyonel: Panel açılınca ana butonları gizlemek istersen

    public void SonrakiSahneyeGit()
    {
        int mevcutSahneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(mevcutSahneIndex + 1);
    }

    // Geliştiriciler panelini açar
    public void GelistiricileriAc()
    {
        if (gelistiriciPaneli != null)
        {
            gelistiriciPaneli.SetActive(true);
            anaMenuObjeleri.SetActive(false);

            // anaMenuObjeleri.SetActive(false); // İstersen ana butonları kapatabilirsin
        }
    }

    // Geliştiriciler panelini kapatır
    public void GelistiricileriKapat()
    {
        if (gelistiriciPaneli != null)
        {
            gelistiriciPaneli.SetActive(false);
            anaMenuObjeleri.SetActive(true);
            // anaMenuObjeleri.SetActive(true); // Ana butonları geri açarsın
        }
    }

    // Oyundan çıkış yapar
    public void OyundanCik()
    {
        Debug.Log("Oyundan çıkılıyor..."); // Editörde çalıştığını anlamak için
        Application.Quit(); // Derlenmiş oyunda çalışır
    }
}