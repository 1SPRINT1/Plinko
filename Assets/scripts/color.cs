
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class color : MonoBehaviour
{
    public GameObject red;
    public GameObject blue;
    public GameObject green;
    public GameObject purple;

    public Text _score;
    public Text _hp;

    public float t = 0;
    public float tmax = 10;

    public static int score;
    public static int hp = 3;

    public static int activeColor = 0;
    private void Start()
    {
        activeColor = Random.Range(1, 4);
        score = PlayerPrefs.GetInt("score", score);
    }

    private void Update()
    {
        _score.text = "Score: " + score;
        _hp.text = "Helth: " + hp;

        PlayerPrefs.SetInt("score", score);

        t = t + Time.deltaTime;
        if (t >= tmax)
        {
            activeColor = Random.Range(1, 4);
            t = 0;
        }

        if (activeColor == 1)
        {
            red.SetActive(true);
            blue.SetActive(false);
            green.SetActive(false);
            purple.SetActive(false);
        }
        if (activeColor == 2)
        {
            red.SetActive(false);
            blue.SetActive(true);
            green.SetActive(false);
            purple.SetActive(false);
        }
        if (activeColor == 3)
        {
            red.SetActive(false);
            blue.SetActive(false);
            green.SetActive(true);
            purple.SetActive(false);
        }
        if (activeColor == 4)
        {
            red.SetActive(false);
            blue.SetActive(false);
            green.SetActive(false);
            purple.SetActive(true);
        }

        if (hp == 0)
        {
            SceneManager.LoadScene("Menu");
            hp = 3;
        }
    }
}
