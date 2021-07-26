<!DOCTYPE html>
<html lang="en">
<?php
session_start();
$isLoged = false;
if (isset($_SESSION['email']) && !empty($_SESSION['email'])) {
  $isLoged = true;
}
?>

<head>
  <!-- Required meta tags -->
  <meta charset="utf-8" />
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
  <title>medical</title>
  <link rel="icon" href="img/favicon.png" />
  <!-- Bootstrap CSS -->
  <link rel="stylesheet" href="css/bootstrap.min.css" />
  <!-- animate CSS -->
  <link rel="stylesheet" href="css/animate.css" />
  <!-- owl carousel CSS -->
  <link rel="stylesheet" href="css/owl.carousel.min.css" />
  <!-- themify CSS -->
  <link rel="stylesheet" href="css/themify-icons.css" />
  <!-- flaticon CSS -->
  <link rel="stylesheet" href="css/flaticon.css" />
  <!-- magnific popup CSS -->
  <link rel="stylesheet" href="css/magnific-popup.css" />
  <!-- nice select CSS -->
  <link rel="stylesheet" href="css/nice-select.css" />
  <!-- swiper CSS -->
  <link rel="stylesheet" href="css/slick.css" />
  <!-- style CSS -->
  <link rel="stylesheet" href="css/style.css" />
</head>

<body>
  <!--::header part start::-->
  <header class="main_menu home_menu">
    <div class="container">
      <div class="row align-items-center">
        <div class="col-lg-12">
          <nav class="navbar navbar-expand-lg navbar-light">
            <a class="navbar-brand" href="index.php">
              <img src="img/mclogo.png">
            </a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
              <span class="navbar-toggler-icon"></span>
            </button>

            <div class="collapse navbar-collapse main-menu-item justify-content-end" id="navbarSupportedContent">
              <ul class="navbar-nav align-items-center">
                <li class="nav-item active">
                  <a class="nav-link" href="index.php">Home</a>
                </li>
                
                <?php
                if (!$isLoged) {
                  echo ('
                    <li class="nav-item">
                      <a class="btn_3 d-lg-block mx-lg-3" href="login.php">Login</a>
                  </li>
                  <li class="nav-item">
                    <a class="btn_3 d-lg-block mx-lg-3" href="registration.php">Register</a>
                  </li>
                    ');
                }else{
                  echo '
                  <li class="nav-item">
                  <a class="btn_3 d-lg-block mx-lg-3" href="signOut.php">Log Out</a>
                </li>
                  ';
                }
                ?>

              </ul>
            </div>
            <a class="btn_2 d-none d-lg-block" href="#">HOT LINE- 011 4567898</a>
          </nav>
        </div>
      </div>
    </div>
  </header>
  <!-- Header part end-->

  <!-- banner part start-->
  <section class="banner_part">
    <div class="container">
      <div class="row align-items-center">
        <div class="col-lg-5 col-xl-5">
          <div class="banner_text">
            <div class="banner_text_iner">
              <h5>We are here for your care</h5>
              <h1>Best Care & Better Doctor</h1>
              <p class="lead">
                MediCu Channeling center & Pharmacies has been a trusted name
                in Sri Lankan healthcare for more than seven decades.
              </p>
              <a href=<?php if ($isLoged) {
                        echo "#appointment";
                      } else {
                        echo "login.php";
                      } ?> class="btn_2">Make an appointment</a>
            </div>
          </div>
        </div>
        <div class="col-lg-7">
          <div class="banner_img">
            <img src="img/banner_img.png" alt="" />
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- banner part start-->

  <!-- about us part start-->
  <section class="about_us padding_top">
    <div class="container">
      <div class="row justify-content-between align-items-center">
        <div class="col-md-6 col-lg-6">
          <div class="about_us_img">
            <img src="img/top_service.png" alt="" />
          </div>
        </div>
        <div class="col-md-6 col-lg-5">
          <div class="about_us_text">
            <h2>About us</h2>
            <p>
              MediCu Channeling center & Pharmacies has been a trusted name in
              Sri Lankan healthcare for more than seven decades.
            </p>
            <p>
              Since our foundation in 1945, we have built a reputation for
              regional leadership in medical excellence and innovation, based
              on a simple philosophy: that improving the health of our
              community should be driven by passion as well as compassion.
            </p>
            <div class="banner_item">
              <div class="single_item">
                <img src="img/icon/banner_1.svg" alt="" />
                <h5>Emergency</h5>
              </div>
              <div class="single_item">
                <img src="img/icon/banner_2.svg" alt="" />
                <h5>Appointment</h5>
              </div>
              <div class="single_item">
                <img src="img/icon/banner_3.svg" alt="" />
                <h5>Qualfied</h5>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- about us part end-->

  <!-- feature_part start-->
  <section class="feature_part">
    <div class="container">
      <div class="row justify-content-center">
        <div class="col-xl-8">
          <div class="section_tittle text-center">
            <h2>Our services</h2>
          </div>
        </div>
      </div>
      <div class="row justify-content-between align-items-center">
        <div class="col-lg-3 col-sm-12">
          <div class="single_feature">
            <div class="single_feature_part">
              <span class="single_feature_icon"><img src="img/child.webp" alt="" /></span>
              <h4>Child Care Center</h4>
              <p>
                Dedicated to the nurturing care of children, we provide
                excellence in medical, surgical and rehabilitative care and
                responsive to parental concerns.
              </p>
            </div>
          </div>
          <div class="single_feature">
            <div class="single_feature_part">
              <span class="single_feature_icon"><img src="img/neurology.webp" alt="" /></span>
              <h4>Neurology Specialists</h4>
              <p>
                Our skilled neurologists have had enormous success treating
                patients diagnosed with brain trauma, epilepsy, sleep
                disorders, strokes, and neck and spine conditions.
              </p>
            </div>
          </div>
        </div>
        <div class="col-lg-4 col-sm-12">
          <div class="single_feature_img">
            <img src="img/service.png" alt="" />
          </div>
        </div>
        <div class="col-lg-3 col-sm-12">
          <div class="single_feature">
            <div class="single_feature_part">
              <span class="single_feature_icon"><img src="img/cardiac.webp" alt="" /></span>
              <h4>Heart Care Center</h4>
              <p>
                Cardiology is a broad field encompassing preventive care,
                invasive and non-invasive procedures, cardiac rehabilitation,
                and a full range of surgical programmes.
              </p>
            </div>
          </div>
          <div class="single_feature">
            <div class="single_feature_part">
              <span class="single_feature_icon"><img src="img/eye.webp" alt="" /></span>
              <h4>Eye Care Center</h4>
              <p>
                The gift of eyesight is one we aim to restore and improve who
                seeking the expertise of our specialists. Offering a range of
                eye care services to your individual needs.
              </p>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- feature_part start-->

  <!--::regervation_part start::-->
  <?php

  if ($isLoged) {
    include_once("dbConn.php");
    echo ('
    <section id="appointment" class="regervation_part section_padding mt-5">
    <div class="container" style="padding:0px;">
      <div class="row align-items-center regervation_content">
        <div class="col-lg-7">
          <div class="regervation_part_iner">
            <form  method="post" action="newAppointment.php">
              <h2>Make an Appointment</h2>
              <div class="form-row">    
                <div class="form-group col-md-8">
                <select class="form-control mb-2" name="sp" id="sp">
                    <option value="1" selected disabled>Select Specialization</option>
                    ');
                    $query = "select specialization from doctor;";
                    $result = mysqli_query($conn, $query);
                    while ($row = mysqli_fetch_assoc($result)) {
                      echo "<option>";
                      echo $row['specialization'];
                      echo "</option>";
                    }
                    echo('
                </select>
                  <select class="form-control" name="doctor" id="Select0">
                    <option value="1" selected disabled>Select Doctor</option>
                </select>
              </div>
              <div class="form-group col-md-8">
              <input type="date" name="appdate" class="form-control mb-4" placeholder="Appointment Date">
              </div>
            </div>
            <div class="regerv_btn">
              <a style="cursor:pointer" class="btn_2" onClick="document.getElementById(`submitBtn`).click()">Make an Appointment</a>
              <input name="submit" style="display:none;" type="submit" id="submitBtn">
            </div>
          </form>
        </div>
      </div>
      <div class="col-lg-5 col-md-6">
        <div class="reservation_img">
          <img style="width:68%;height:auto;bottom:-324px" src="img/reservation.png" alt="" class="reservation_img_iner" />
        </div>
      </div>
    </div>
  </div>
</section>
  ');
  }

  ?>

  <!--::regervation_part end::-->

  <!-- footer part start-->
  <footer class="footer-area">
    <div class="footer section_padding">
      <div class="container">
        <div class="row justify-content-between">
          <div class="col-sm-6 single-footer-widget">
            <a href="#" class="footer_logo">
              <img src="img/mclogo.png" alt="#" />
            </a>
            <p>
              MediCu Channeling center & Pharmacies has been a trusted name in
              Sri Lankan healthcare for more than seven decades.
            </p>
            <div class="social_logo">
              <a href="#"><i class="ti-facebook"></i></a>
              <a href="#"> <i class="ti-twitter"></i> </a>
              <a href="#"><i class="ti-instagram"></i></a>
              <a href="#"><i class="ti-skype"></i></a>
            </div>
          </div>
          <div class="justify-content-lg-end mx-2 mx-sm-5">
            <div class="col single-footer-widget">
              <div class="row">
                <h3>Contact US</h3>
              </div>
              <div class="row">
                <ul>
                  <li><a href="#">NO : 123,colombo7</a></li>
                  <li><a href="#">Sri lanka</a></li>
                  <li><a href="#">011 2345678</a></li>
                </ul>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </footer>

  <!-- footer part end-->

  <!-- jquery plugins here-->

  <script src="js/jquery-1.12.1.min.js"></script>
  <!-- popper js -->
  <script src="js/popper.min.js"></script>
  <!-- bootstrap js -->
  <script src="js/bootstrap.min.js"></script>
  <!-- owl carousel js -->
  <script src="js/owl.carousel.min.js"></script>
  <script src="js/jquery.nice-select.min.js"></script>
  <!-- contact js -->
  <script src="js/jquery.ajaxchimp.min.js"></script>
  <script src="js/jquery.form.js"></script>
  <script src="js/jquery.validate.min.js"></script>
  <script src="js/mail-script.js"></script>
  <script src="js/contact.js"></script>
  <!-- custom js -->
  <script src="js/custom.js"></script>
  <script>

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
              for(var i=0;i<responce.length;i++){
                let option=document.createElement("option");
                option.text=option.value=responce[i];

                let li=document.createElement("li");
                li.setAttribute("data-value",responce[i]);
                li.setAttribute("class","option");
                li.appendChild(document.createTextNode(responce[i]));

                document.getElementById("Select0").add(option);
                document.getElementById("1").appendChild(li);
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