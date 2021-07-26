<?php
require("Geocoding.php");

use myPHPnotes\Geocoding;

$geo = new Geocoding("AIzaSyDVwVkweXsDH2ihvCQdLDrT2XPfkmQUSIU");

$codinates = $geo->getCoordinates("317/A, Kanupelalla Road Wewalhinna - Kadana Road, Badulla");

var_dump($codinates);
