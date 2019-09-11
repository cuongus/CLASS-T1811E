<!DOCTYPE html>
<html>
<head>
	<title>FORM SIGN</title>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width">
	<!--
	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
	-->
	<!-- Latest compiled and minified CSS -->
	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css" integrity="sha384-HSMxcRTRxnN+Bdg0JdbxYKrThecOKuH5zCYotlSAcp1+c8xmyTe9GYg1l9a69psu" crossorigin="anonymous">

	<!-- Optional theme -->
	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap-theme.min.css" integrity="sha384-6pzBo3FDv/PJ8r2KRkGHifhEocL+1X2rVCTTkUfGk7/0pbek5mMa1upzvWbrUbOZ" crossorigin="anonymous">

	<!-- Latest compiled and minified JavaScript -->
	<script src="https://stackpath.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js" integrity="sha384-aJ21OjlMXNL5UyIl/XNwTMqvzeRMZH2w8c5cRVpzpU8Y5bApTppSuUkhZXN0VxHd" crossorigin="anonymous"></script>

</head>
<body>
	<?php
		// if (!empty($_POST)) {
		// 	$fullname = $_POST['username'];
		// 	$password = $_POST['password'];
		// 	echo $fullname;
		// }
		$uName = $pwd = '';
		if (isset($_POST['username'])) {
			$uName = $_POST['username'];
		}

		if (isset($_POST['password'])) {
			$pwd = $_POST['password'];
		}

		// if (isset($_GET['username'])) {
		// $uName = $_GET['username'];
		// }

		// if (isset($_GET['password'])) {
		// 	$pwd = $_GET['password'];
		// }
		// if (isset($_REQUEST['username'])) {
		// 	$uName = $_REQUEST['username'];
		// }

		// if (isset($_REQUEST['password'])) {
		// 	$pwd = $_REQUEST['password'];
		// }

		echo '<br/>uName: '.$uName;
		echo '<br/>pwd: '.$pwd;
	?>
	<!--
	<form>
	  <div class="form-group">
	    <label for="exampleInputEmail1">Email address</label>
	    <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Enter email">
	    <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
	  </div>
	  <div class="form-group">
	    <label for="exampleInputPassword1">Password</label>
	    <input type="password" class="form-control" id="exampleInputPassword1" placeholder="Password">
	  </div>
	  <div class="form-group form-check">
	    <input type="checkbox" class="form-check-input" id="exampleCheck1">
	    <label class="form-check-label" for="exampleCheck1">Check me out</label>
	  </div>
	  <button type="submit" class="btn btn-primary">Submit</button>
	</form>
	-->
	<!--
	<form class="form-inline">
	  <div class="form-group">
	    <label class="sr-only" for="exampleInputEmail3">Email address</label>
	    <input type="email" class="form-control" id="exampleInputEmail3" placeholder="Email">
	  </div>
	  <div class="form-group">
	    <label class="sr-only" for="exampleInputPassword3">Password</label>
	    <input type="password" class="form-control" id="exampleInputPassword3" placeholder="Password">
	  </div>
	  <div class="checkbox">
	    <label>
	      <input type="checkbox"> Remember me
	    </label>
	  </div>
	  <button type="submit" class="btn btn-default">Sign in</button>
	</form>
	-->
	<section class ="section1">
		<div class="container">
			<div class="col-md-6 col-md-offset-3">
				<form class="form-horizontal" method="post" action="register.php">
				  <div class="form-group">
				    <label for="inputEmail3" class="col-sm-2 control-label">Email</label>
				    <div class="col-sm-10">
				      <input type="email" class="form-control" id="inputEmail3" placeholder="Email" name="username">
				    </div>
				  </div>
				  <div class="form-group">
				    <label for="inputPassword3" class="col-sm-2 control-label">Password</label>
				    <div class="col-sm-10">
				      <input type="password" class="form-control" id="inputPassword3" placeholder="Password" name="password">
				    </div>
				  </div>
				  <div class="form-group">
				    <div class="col-sm-offset-2 col-sm-10">
				      <div class="checkbox">
				        <label>
				          <input type="checkbox"> Remember me
				        </label>
				      </div>
				    </div>
				  </div>
				  <div class="form-group">
				    <div class="col-sm-offset-2 col-sm-10">
				      <!-- <button type="submit" class="btn btn-default">Sign in</button> -->
				      <button class="btn btn-default">Sign in</button>
				    </div>
				  </div>
				</form>
			</div>
		</div>
	</section>

</body>
</html>