<?php

include_once("dbConn.php");
mysqli_report(MYSQLI_REPORT_ERROR);
if (isset($_POST['submit'])) {
    if (isset($_POST['doctor'], $_POST['appdate'])) {
        session_start();
        $doctor = $_POST['doctor'];
        $date = $_POST['appdate'];
        $email = $_SESSION['email'];
        if (
            !$doctor == " " || !$date == " "
        ) {
            header("Location:unsuccses.php?app=fields");
        } else {
            $query = "insert into appointment (PatientId,DoctorId,AppDate) values(?,?,?);";
            $stmt = mysqli_stmt_init($conn);
            if (!mysqli_stmt_prepare($stmt, $query)) {
                echo "Something went wrong while executing ";
                exit();
            } else {
                $query0 = "select DoctorId from doctor where FullName='$doctor';";
                $out0 = mysqli_query($conn, $query0);

                $row = mysqli_fetch_assoc($out0);
                $docID = $row['DoctorId'];
                echo "doc - $docID";
                $query1 = "select Id from patient where Email='$email';";
                $out1 = mysqli_query($conn, $query1);

                $row = mysqli_fetch_assoc($out1);
                $patientID = $row['Id'];
                echo "patient id- $patientID";
                mysqli_stmt_bind_param($stmt, "sss", $patientID, $docID, $date);
                mysqli_stmt_execute($stmt);
                header("Location:succsess.php");                           
            }
        }
    } else {
        header("Location:unsuccses.php?app=dd");
    }
} else {
    header("Location:unsuccses.php?app=fields");
}
