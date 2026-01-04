netSmtpMailSection.Network.Port = Convert.ToInt32(ServerPortTextBox.Text, CultureInfo.InvariantCulture);

    netSmtpMailSection.From = FromTextBox.Text;

    AuthenticateMode authenticationMode = AuthenticateMode.None;
    if (NoneRadioButton.Checked) {
        authenticationMode = AuthenticateMode.None;
    }
    else if (BasicRadioButton.Checked) {
        authenticationMode = AuthenticateMode.Basic;
    }
    else {
        authenticationMode = AuthenticateMode.NTLM;
    }


    if (authenticationMode == AuthenticateMode.None) {
        netSmtpMailSection.Network.DefaultCredentials = false;
        netSmtpMailSection.Network.UserName = String.Empty;
        netSmtpMailSection.Network.Password = String.Empty;
    } else if (authenticationMode == AuthenticateMode.Basic) {
        netSmtpMailSection