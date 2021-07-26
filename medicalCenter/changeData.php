<?php
include_once("dbConn.php");
mysqli_report(MYSQLI_REPORT_ERROR);
if (isset($_POST['submit'])) {
    if (isset($_POST['name'], $_POST['nic'], $_POST['mnum'], $_POST['dob'],
    $_POST['address'])) {
        session_start();
        $email = $_SESSION['email'];
        $name = $_POST['name'];
        $nic = $_POST['nic'];
        $mnum = $_POST['mnum'];
        $dob = $_POST['dob'];
        $address = $_POST['address'];

        if (
            !$name == " " || !$nic == " " || !$mnum == " " || !$dob == " " || !$address == " "
        ) {
            header("Location:unsuccses.php?app=fields");
        } else {
            $query = "update  patient set 
                            nic=?,
                            name=?,
                            mobile=?,
                            dob=?,
                            address=?
                            where email=? ;";
            $stmt = mysqli_stmt_init($conn);
            if (!mysqli_stmt_prepare($stmt, $query)) {
                echo "Something went wrong while executing ";
                exit();
            } else {
                $gender = "gender";
                mysqli_stmt_bind_param($stmt, "ssisss", $nic, $name, $mnum, $dob, $address, $email);
                mysqli_stmt_execute($stmt);
                header("Location:succsess.php");
            }
        }
    } else {
        header("Location:unsuccses.php?app=fields");
    }
}
