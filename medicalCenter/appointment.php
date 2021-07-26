<?php
session_start();
if (!isset($_SESSION['email']) || empty($_SESSION['email'])) {
  header("Location:login.php?login=notLoggedIn");
  exit();
}
include_once("dbConn.php");
?>
<html>

<body style="height:400px;">
  <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
  <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
  <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

  <form class=" border border-light p-5" method="post" action="newAppointment.php">

    <p class=" text-center h4 mb-4">New Appointment</p>
    <input type="hidden" name="listIndex" value="" id="file_index_fld" />
    <div class="form-group">
    <label for="gender">Select Specialization</label>
      <select class="form-control" name="sp" id="sp">
      <option value="1" selected disabled>Select Specialization</option>
      <?php
      $query = "select DISTINCT specialization from doctor;";
      $result = mysqli_query($conn, $query);
      while ($row = mysqli_fetch_assoc($result)) {
        echo "<option>";
        echo $row['specialization'];
        echo "</option>";
      }
      ?>              
      </select>
    </div>
    <div class="form-group">
      <label for="gender">Select Doctor</label>
      <select class="form-control" name="doctor" id="Select0">
      </select>
    </div>
    <!-- Appointment date -->
    <input id="datePicker" type="date" name="appdate" class="form-control mb-4" placeholder="Date Of Birth">

    <!-- Sign up button -->
    <button name="submit" class=" bg-primary btn btn-info my-4 btn-block" type="submit">Submit</button>
  </form>
  <!-- Default form register -->

  <script>

      $(document).ready(()=>{
        let date = new Date();
        let day=date.getDate();
        let month=date.getMonth();
        let year=date.getFullYear();
        let datePicker=document.getElementById("datePicker");
        datePicker.setAttribute("min",year+"-"+(month+1)+"-"+day);
      });

    $("#sp").change(function () {
            var spVal = this.value;
            $.ajax({
            url:"getDoctors.php",
            type:"POST",
            dataType: 'json',
            data:{
                spVal:spVal
            },
            success:function(responce){
                $("#Select0").empty();
                for(var i=0;i<responce.length;i++){
                    let option=document.createElement("option");
                    option.text=option.value=responce[i];
                    document.getElementById("Select0").add(option);
                }
            },
            error:function(err){
                console.log("ERROR");
            }
            });
        });

</script>

</body>

</html>