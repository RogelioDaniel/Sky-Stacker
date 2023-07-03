using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static int highScore;

    private void Start()
    {
        // Cargar la puntuaci�n m�s alta almacenada previamente
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    public static void SaveHighScore(int score)
    {
        if (score > highScore)
        {
            // Guardar la nueva puntuaci�n m�s alta
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
            print(highScore);
        }
    }
}
