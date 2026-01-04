<%@ page masterPageFile="~/WebAdminWithConfirmation.master" inherits="System.Web.Administration.ApplicationConfigurationPage"%>
<%@ register TagPrefix="webadmin" namespace="System.Web.Administration" %>
<%@ Import Namespace="System.Globalization" %>
<%@ Import Namespace="System.Web.Administration" %>
<%@ Import Namespace="System.Web.Configuration" %>
<%@ Import Namespace="System.Net.Configuration" %>

<script runat="server" language="cs">

private enum AuthenticateMode {
    None = 0,
    Basic = 1,
    NTLM = 2,
}

private int PasswordCharLen {
    get {
        object o = ViewState["!PasswordCharLen"];
        if (o == null) {
            return 0;
        }
        return (int)o;
    }
    set {
        ViewState["!PasswordCharLen"] = value;
    }
}

private WebAdminWithConfirmationMasterPage Master {
    get {
        return (WebAdminWithConfirmationMasterPage)base.Master;
    }
}

private void Authentication_ValueChanged(object sender, EventArgs e) {
    ToggleSenderInfoUI(BasicRadioButton.Checked);
}

private void Page_Load() {
    string appPath = ApplicationPath;
    if (!IsPostBack) {
        if (!String.IsNullOrEmpty(appPath)) {
            ConfigureSMTPTitle.Text = String.Format((string)GetLocalResourceObject("TitleForSite"), appPath);
        }

        Configuration config = OpenWebConfiguration(appPath);
        SmtpSection netSmtpMailSection = (SmtpSection) config.GetSection("system.net/mailSettings/smtp");

        ServerNameTextBox.Text = netSmtpMailSection.Network.Host;
        ServerPortTextBox.Text = Convert.ToString(netSmtpMailSection.Network.Port, CultureInfo.InvariantCulture);

        FromTextBox.Text = netSmtpMailSection.From;