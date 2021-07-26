<?php
include_once("dbConn.php");
//mysqli_report(MYSQLI_REPORT_ERROR);
if (isset($_POST['submit'])) {
    if (isset($_POST['name'], $_POST['nic'], $_POST['mnum'], $_POST['dob'],
    $_POST['address'], $_POST['email'], $_POST['pass'])) {

        $name = $_POST['name'];
        $nic = $_POST['nic'];
        $mnum = $_POST['mnum'];
        $dob = $_POST['dob'];
        $address = $_POST['address'];
        $email = $_POST['email'];
        $pass = $_POST['pass'];

        if (
            !$name == " " || !$nic == " " || !$mnum == " " || !$dob == " " || !$address == " "
            || !$email == " " || !$pass == " "
        ) {
            echo ('All the fileds are required.');
        } else {
            if (!checkEmail($email, $conn)) {
                $query = "insert into patient (nic,name,dob,address,mobile,email,regNo,gender,pass) values(?,?,?,?,?,?,?,?,?);";
                $stmt = mysqli_stmt_init($conn);
                if (!mysqli_stmt_prepare($stmt, $query)) {
                    echo "Something went wrong while executing ";
                    exit();
                } else {
                    $query0 = "select id from patient;";
                    $out = mysqli_query($conn, $query0);
                    $result = mysqli_num_rows($out) + 1;
                    $regNo = "PTN$result";
                    $gender = "gender";
                    mysqli_stmt_bind_param($stmt, "ssssissss", $nic, $name, $dob, $address, $mnum, $email, $regNo, $gender, $pass);
                    mysqli_stmt_execute($stmt);
                    header("Location:login.php");
                }
            } else {
                echo "Email Exist";
                exit();
            }
        }
    } else {
        header("Location:patientRegistration.php?signup=failed");
        exit();
    }
}

function checkEmail($email, $conn)
{
    $eqery = "select email from patient where email='$email';";
    $out = mysqli_query($conn, $eqery);
    $result = mysqli_num_rows($out);

    if ($result > 0) {
        return true;
    } else {
        return false;
    }
}
