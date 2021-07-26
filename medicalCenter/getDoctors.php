<?php
include("./dbConn.php");
$spVal =$_POST["spVal"];
$query = "select FullName from doctor where Specialization ='".$spVal."'";
$result = mysqli_query($conn, $query);
$res=array();
while ($row = mysqli_fetch_assoc($result)) {
    array_push($res,$row["FullName"]);
}
echo json_encode($res);
