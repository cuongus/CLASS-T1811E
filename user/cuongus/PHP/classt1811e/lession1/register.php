<!DOCTYPE html>
<html>
<head>
	<title>Register</title>
</head>
<body>
	<?php
		$uName = $pwd = '';
		if (isset($_POST['username'])) {
			$uName = $_POST['username'];
		}

		if (isset($_POST['password'])) {
			$pwd = $_POST['password'];
		}

		echo '<br/>uName: '.$uName;
		echo '<br/>pwd: '.$pwd;
	?>
</body>
</html>