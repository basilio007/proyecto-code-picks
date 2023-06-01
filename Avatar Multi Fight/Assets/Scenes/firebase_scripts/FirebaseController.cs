using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirebaseController : MonoBehaviour
{

    public GameObject loginPanel, signupPanel, profilePanel, forgetPasswordPanel;

    public InputField loginEmail, loginPassword, signupEmail, signupPassword, signupCPassword, signupUserName, forgetpassEmail;

    public void OpenLoginPanel()
    {
        loginPanel.SetActive(true);
        signupPanel.SetActive(false);
        profilePanel.SetActive(false);
        forgetPasswordPanel.SetActive(false);

    }

    public void OpenSignUpPanel()
    {
        loginPanel.SetActive(false);
        signupPanel.SetActive(true);
        profilePanel.SetActive(false);
        forgetPasswordPanel.SetActive(false);
    }

    public void OpenProfilePanel()
    {
        loginPanel.SetActive(false);
        signupPanel.SetActive(false);
        profilePanel.SetActive(true);
        forgetPasswordPanel.SetActive(false);
    }

    public void OpenForgetPass()
    {
        loginPanel.SetActive(false);
        signupPanel.SetActive(false);
        profilePanel.SetActive(false);
        forgetPasswordPanel.SetActive(true);
    }

    public void LoginUser()
    {
        if (string.IsNullOrEmpty(loginEmail.text) && string.IsNullOrEmpty(loginPassword.text))
        {
            return;
        }

        // aixo fa login
    }

    public void SignUpUser()
    {
        if (string.IsNullOrEmpty(signupEmail.text) && string.IsNullOrEmpty(signupPassword.text) && string.IsNullOrEmpty(signupCPassword.text) && string.IsNullOrEmpty(signupUserName.text))
        {
            return;
        }

        // aixo fa el registre
    }


    public void ForgetPass()
    {
        if (string.IsNullOrEmpty(forgetpassEmail.text)) { 
            return;
        }
    }
  

}
