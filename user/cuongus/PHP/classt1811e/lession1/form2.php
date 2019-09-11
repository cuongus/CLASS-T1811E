<!DOCTYPE html>
<html>
<head>
	<title>Đăng ký tài khoản</title>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
</head>
<body>
	<?php
	// if (!empty($_POST)) {
	// 	$fullname = $_POST['username'];
	// 	$password = $_POST['password'];
	// 	echo $fullname;
	// }
	$uName = $pwd = '';
	// if (isset($_POST['username'])) {
	// 	$uName = $_POST['username'];
	// }

	// if (isset($_POST['password'])) {
	// 	$pwd = $_POST['password'];
	// }

	if (isset($_GET['username'])) {
		$uName = $_GET['username'];
	}

	if (isset($_GET['password'])) {
		$pwd = $_GET['password'];
	}
	// if (isset($_REQUEST['username'])) {
	// $uName = $_REQUEST['username'];
	// }

	// if (isset($_REQUEST['password'])) {
	// 	$pwd = $_REQUEST['password'];
	// }

	echo '<br/>uName: '.$uName;
	echo '<br/>pwd: '.$pwd;
	?>
	<body>
		<div class="container">
			<form method="get" action="register.php">
				<div class="form-group">
				<h2>Register Account</h2>
				</div>
				<div class="form-group">
					<label for="username">User Name</label>
					<input type="text" name="username" class="form-control">
				</div>
				<div class="form-group">
					<label for="username">Password</label>
					<input type="password" name="password" class="form-control">
				</div>
				<button class="btn btn-success">Register</button>
			</form>
		</div>
	</body>
</body>
</html>