
<?php

if (isset($_POST['submit'])) {
    include_once("dbConn.php");
    if (isset($_POST['email'], $_POST['pass'])) {

        $email = $_POST['email'];
        $pass = $_POST['pass'];

        if ($email == " " || $pass == " ") {
            echo ("All Fields are Requred.");
        } else {
            $query = "select email,pass from patient where email=?";
            $stmnt = mysqli_stmt_init($conn);
            mysqli_stmt_prepare($stmnt, $query);
            mysqli_stmt_bind_param($stmnt, "s", $email);
            mysqli_stmt_execute($stmnt);
            $result = mysqli_stmt_get_result($stmnt);
            $numrows = mysqli_num_rows($result);
            if ($numrows >= 1) {
                while ($row = mysqli_fetch_assoc($result)) {
                    if ($pass == $row['pass'] && $email == $row['email']) {
                        session_start();
                        $_SESSION['email'] = $email;
                        header("Location:patientDashboard.php?login=success");
                        exit();
                    } else {
                        header("Location:login.php?login=unsuccess");
                    }
                }
            } else {
                header("Location:login.php?login=unsuccessrow");
            }
        }
    } else {
        header("Location:login.php?login=failed");
    }
} else {
    header("Location:login.php");
}

?>