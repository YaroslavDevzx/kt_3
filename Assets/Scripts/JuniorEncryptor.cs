using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class JuniorEncryptor : MonoBehaviour
{

    [SerializeField] private TMP_Text showText;

    [Space(5)]
    [Header("Buttons")]
    [SerializeField] private Button encryptButton;
    [SerializeField] private Button decryptButton;
    [SerializeField] private Button peelButton;
    [SerializeField] private Button correctButton;

    private string data = "Cats are j*st h*ge kittens and n$othing else. These cr$azy animals ar$e preferred by a h*ge part of those who keep animals at home. People alw$ays thin$k that cats are lazy animals that lik$e t$o spend their ent$ire life sitting by the wind$ow, all day long.>We have all heard that ca$ts live an average of 8 years, b*t that is no$t the entire tr*th. This n*mber is only ave$rage, cats live 12 ye$ars and more on a$verage. Cats are s$ocial a$nimals, they live with other cats and th$ey als$o$ live with h*mans and other anim$als as well.>Cats live *p to 40 ho*rs a week, so they can not even be c$onsidered as lazy. They play with other animals and they spend tim$e sleeping or lo*nging aro*nd. They enjoy long walks a$nd we all$ know cats will.>It is easy to bring a kitten home, b*t it is not so $easy to raise and raise a worthy member of mo$dern society and make a decent cat o*t of a $baby. Before yo* bring a new cat home, it is im$portant to know how to take care of them and train them properly.>They req*ire the p$roper space, shelter and toys. Cats can be kept in a normal room with doors and wind$ows open, b*t don’t expo$se them $to the we$ather. If yo* want them to play o*tside and go on long walks, keep them inside the ho*se. The ho*se m*st be clean, a$nd food and water m*st alwa$ys be availa$ble. If yo* want yo*r cat to like yo*, yo* m*st be nice $to him or her.>A $cat is a *niq*e creat*re, she has different needs and a different disposition. If yo* choose$ the wrong one to k$eep, yo* mig$ht regret it. Cats are an im$portant part of o*r world, an$d we have to give them the$ right ed*ca$tion.zzz";


    void Start()
    {
        Initialize();
    }

    void Initialize()
    {
        showText.text = data;
        encryptButton.onClick.AddListener(EncryptData);
        decryptButton.onClick.AddListener(DecryptData);
        peelButton.onClick.AddListener(PeelData);
        correctButton.onClick.AddListener(CorrectData);
    }

    void DecryptData()
    {
        data = data.Replace("*", "u");
        showText.text = data;
    }

    void EncryptData()
    {
        data = data.Replace("r", "%");
        data = data.Replace("o", "!&");
        data = data.Replace("e", "@");
        showText.text = data;
    }

    void PeelData()
    {
        data = data.TrimEnd('z');
        data = data.Replace("$", "");
        showText.text = data;
    }

    void CorrectData()
    {
        data = data.Replace(">", "\n");
        showText.text = data;
    }





}
