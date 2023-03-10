<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validation.aspx.cs" Inherits="Validation.Validator" %>

<!DOCTYPE html>

<html>
<head>
	<title>Validator</title>
</head>
<body>
	<form runat="server">
		
			<label for="name">Name:</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<input type="text" id="name" name="name" runat="server" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic" ErrorMessage="Name must be requirred"></asp:RequiredFieldValidator>

			<label for="familyName">
            <br />
            <br />
            Family Name:</label>&nbsp;&nbsp;&nbsp;&nbsp;
			<input type="text" id="familyName" name="familyName" runat="server" />
            <br />
            <br />
		

		
			<label for="address">Address:</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<input type="text" id="address" name="address" runat="server" />
		

		
			<label for="city">
            <br />
            <br />
            City:</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<input type="text" id="city" name="city" runat="server" />

			<label for="zipCode">
            <br />
            <br />
            Zip Code:</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<input type="text" id="zipCode" name="zipCode" runat="server" />
		

		
			<label for="phone">
            <br />
            <br />
            Phone:</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<input type="text" id="phone" name="phone" runat="server" />
		

		
			<label for="email">
            <br />
            <br />
            E-mail:</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<input type="text" id="email" name="email" runat="server" /><br />
            <br />
            <br />
&nbsp;

		
			<asp:Button ID="checkButton" runat="server" Text="Check" OnClick="checkButton_Click" />
		
	</form>
</body>
</html>
