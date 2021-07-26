<?php
session_start();
if (!isset($_SESSION['email']) || empty($_SESSION['email'])) {
    header("Location:login.php?login=notLoggedIn");
    exit();
}
?>


<html>

<body style="height:400px;">
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
    <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

    <form class="text-center border border-light p-5" method="post" action="changeData.php" enctype="multipart/form-data">

        <p class="h4 mb-4">Change Account Settings</p>
        <?php
        include_once("dbConn.php");
        $email = $_SESSION['email'];
        $query = "select * from patient where Email='$email'";
        $result = mysqli_query($conn, $query);
        $data = mysqli_fetch_assoc($result);
        $name = $data['Name'];
        $nic = $data['NIC'];
        $date = $data['DOB'];
        $mnum = $data['Mobile'];
        $address = $data['Address'];

        echo "<input type='text'name='name' class='form-control mb-4' placeholder='Full Name' value='$name'>";

        echo "<input type='text' name='nic' class='form-control mb-4' placeholder='NIC' value='$nic'>";

        echo "<input type='date' name='dob' class='form-control mb-4' placeholder='Date of Birth' value='$date'>";

        echo "<input type='text' name='mnum' class='form-control mb-4' placeholder='MObile Number' value='$mnum'>";

        echo "<input type='text' name='address' class='form-control mb-4' placeholder='Address' value='$address'>";

        ?>

        <select class="form-control" name="gender">
            <option>Male</option>
            <option>Female</option>
            <!-- Sign up button -->
        </select>
        <button name="submit" class=" btn btn-primary my-4 btn-block" type="submit">Submit</button>
    </form>
    <!-- Default form register -->

</body>

</html>