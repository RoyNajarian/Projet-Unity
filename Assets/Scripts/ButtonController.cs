using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    [SerializeField] // Référence à l'objet TextMeshProUGUI dans l'inspecteur
    public TextMeshProUGUI m_Title; // Référence à l'objet Image dans l'inspecteur

     [SerializeField]
    private Image m_Icon;

    [SerializeField]
    private string m_Text = "Button";

    [SerializeField]
    private Sprite m_Sprite;

    [SerializeField]
    private Color m_SpriteColor = Color.magenta;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_Title.text = m_Text; // Permet de définir le texte du TextMeshProUGUI avec la valeur de m_Text
        m_Icon.sprite = m_Sprite; // Permet de définir le sprite de l'Image avec la valeur de m_Sprite
    }

    // Update is called once per frame
    void Update()
    {
    } // Fin de Update

    // Méthode de la classe, au même niveau que Start et Update
    public void ChangeIconColor()
    {
        m_Icon.color = m_SpriteColor; // Applique la couleur choisie dans l'Inspector
    }
} // Fin de la classe ButtonController