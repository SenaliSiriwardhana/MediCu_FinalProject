<?php
session_start();
if (isset($_SESSION['email']) || !empty($_SESSION['email'])) {
	header("Location:patientDashboard.php");
}
?>
<!DOCTYPE html>
<html lang="en">

<head>
	<title>Patient Login</title>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="css/bootstrap.min.css">
	<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="fonts/font-awesome-4.7.0/css/font-awesome.min.css">
	<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendors/animate/animate.css">
	<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendors/css-hamburgers/hamburgers.min.css">
	<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="vendors/select2/select2.min.css">
	<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="css/util.css">
	<link rel="stylesheet" type="text/css" href="css/main.css">
	<!--===============================================================================================-->
</head>

<body>

	<div class="limiter">

	<?php
	
	if(isset($_GET["login"])){
		echo '<div class="alert alert-warning mb-0 text-center" role="alert">';
		$login=$_GET["login"];
		if($login=="unsuccess"){
			echo "username or password is not correct";
		}else if($login=="unsuccessrow"){
			echo"username or password is not correct";
		}else if($login=="failed"){
			echo "All the fileds are reqired";
		}else if($login="notLoggedIn"){
			echo "Please Login first";
		}
		echo '</div>';
	}
	
	?>
		<div class="container-login100">
			<div class="wrap-login100">
				<div class="login100-pic js-tilt" data-tilt>
					<img src="img/img-01.png" alt="IMG">
				</div>
				<form action="loginback.php" method="post" class="login100-form validate-form">
					<span class="login100-form-title">
						Patient Login
					</span>

					<div class="wrap-input100 validate-input" data-validate="Valid email is required: ex@abc.xyz">
						<input class="input100" type="text" name="email" placeholder="Email">
						<span class="focus-input100"></span>
						<span class="symbol-input100">
							<i class="fa fa-envelope" aria-hidden="true"></i>
						</span>
					</div>

					<div class="wrap-input100 validate-input" data-validate="Password is required">
						<input class="input100" type="password" name="pass" placeholder="Password">
						<span class="focus-input100"></span>
						<span class="symbol-input100">
							<i class="fa fa-lock" aria-hidden="true"></i>
						</span>
					</div>

					<div class="container-login100-form-btn">
						<button class="login100-form-btn" name="submit">
							Login
						</button>
					</div>
					<div class="text-center p-t-136">
						<a class="txt4" href="registration.php">
							Create your Account
							<i class="fa fa-long-arrow-right m-l-5" aria-hidden="true"></i>
						</a>
					</div>
				</form>
			</div>
		</div>
	</div>




	<!--===============================================================================================-->
	<script src="js/jquery-1.12.1.min.js"></script>
	<!--===============================================================================================-->
	<script src="js/popper.min.js"></script>
	<script src="js/bootstrap.min.js"></script>
	<!--===============================================================================================-->
	<script src="vendors/select2/select2.min.js"></script>
	<!--===============================================================================================-->
	<script src="vendors/tilt/tilt.jquery.min.js"></script>
	<script>
		$('.js-tilt').tilt({
			scale: 1.1
		})
	</script>
	<!--===============================================================================================-->
	<script src="js/main.js"></script>

</body>

</html>