using UnityEngine;

public class ReferralManager : MonoBehaviour
{
    public static bool referralActive = false;

    public void CheckCode(string code)
    {
        if (code == "PikachuLi")
        {
            referralActive = true;
        }
    }
}