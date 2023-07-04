using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CoinSystem : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    public RawImage coinImage;

    private int coinCount ;
    private void Start()
    {
        // Cargar la puntuaci�n m�s alta almacenada previamente
        coinCount = PlayerPrefs.GetInt("Coins", 0);
    }
    public void CollectCoin(int coin)
    {
        coinCount++;

        // Actualiza el texto y la imagen de la moneda en pantalla
        coinText.text = "Coins: " + coinCount.ToString();
        PlayerPrefs.SetInt("Coins", coinCount);
        PlayerPrefs.Save();
        // Asigna la imagen de la moneda correspondiente aqu�
    }

    
}
