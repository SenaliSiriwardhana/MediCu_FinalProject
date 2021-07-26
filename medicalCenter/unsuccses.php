<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
</head>

<body style="background-color:#F4F6F9;">

  <div class="container">

    <div class="alert alert-danger">
      <?php
      echo "<strong>UnSuccess!</strong><br>";
      if ($_GET['app'] == "fields") {
        echo "All the fileds are requered.";
      }
      ?>
    </div>
  </div>

</body>

</html>