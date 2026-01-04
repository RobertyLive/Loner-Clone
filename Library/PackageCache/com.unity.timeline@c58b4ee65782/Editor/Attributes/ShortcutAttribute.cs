dth="1%">
                                                    <asp:Label runat="server" AssociatedControlID="NoneRadioButton" Text="<%$ Resources:NoneRadioButtonText %>"/>
                                                </td>
                                                <td/>
                                            </tr>
                                            <tr>
                                                <td width="1%"/>
                                                <td width="1%" valign="top">
                                                    <asp:RadioButton runat="server" id="BasicRadioButton" GroupName="Authentication"
                                                                     AutoPostBack="true" OnCheckedChanged="Authentication_ValueChanged"/>
                                                </td>
                                                <td width="1%" colspan="2">
                                                    <asp:Label runat="server" AssociatedControlID="BasicRadioButton" Text="<%$ Resources:BasicRadioButtonText %>"/><br/>
                                                    <asp:Literal runat="server" Text="<%$ Resources:BasicAuthDesc %>"/>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td width="1%"/>
                                                <td width="1%"/>
                                                <td width="1%">
                                                    <asp:Label id="UserNameLabel" runat="server" AssociatedControlID="UserNameTextBox"
                                                               Text="<%$ Resources:SenderUserNameLabel %>"/>
                                                </td>
                                                <td>
                                                    <asp:TextBox runat="server" id="UserNameTextBox"/>
                                                </td>
                                            </tr>
                                            <