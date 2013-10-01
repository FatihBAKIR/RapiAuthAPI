<?php
require 'RapiAuth.php';

$Authenticatior = new RapiAuth("c4ca4238a0b923820dcc509a6f75849b");

if (isset($_POST["token"]) && isset($_POST["kod"]))
{
	if ($Authenticatior->Kontrol($_POST["token"], $_POST["kod"]))
	{
		echo "Dogru";
	} 
	else
		echo "Yanlis";
}
?>

<form action="PHP-Demo.php" method="POST">
<input type="text" name="token" value="<?=isset($_POST["token"]) ? $_POST["token"] : "Token" ?>" />
<input type="text" name="kod" value="<?=isset($_POST["kod"]) ? $_POST["kod"] : "Kod" ?>" />
<input type="submit" value="Kontrol" />
</form>