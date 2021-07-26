<?php
require("dbConn.php");
// Get parameters from URL
$center_lat = $_GET["lat"];
$center_lng = $_GET["lng"];
$radius = $_GET["radius"];
// Start XML file, create parent node
$dom = new DOMDocument("1.0");
$node = $dom->createElement("markers");
$parnode = $dom->appendChild($node);
// Opens a connection to a mySQL server

if (!$conn) {
    die("Not connected : " . mysqli_error($conn));
}
// Set the active mySQL database
$db_selected = mysqli_select_db($conn, "database1");
if (!$db_selected) {
    die("Can\'t use db : " . mysqli_error($conn));
}
// Search the rows in the markers table
$query = sprintf(
    "SELECT Phaid, Phaname, Address, Latitude, Longitude, ( 6371 * acos( cos( radians('%s') ) * cos( radians( Latitude ) ) * cos( radians( Longitude ) - radians('%s') ) + sin( radians('%s') ) * sin( radians( Latitude ) ) ) ) AS distance FROM pharmacy HAVING distance < '%s' ORDER BY distance LIMIT 0 , 20",
    mysqli_real_escape_string($conn, $center_lat),
    mysqli_real_escape_string($conn, $center_lng),
    mysqli_real_escape_string($conn, $center_lat),
    mysqli_real_escape_string($conn, $radius)
);
$result = mysqli_query($conn, $query);
if (!$result) {
    die("Invalid query: " . mysqli_error($conn));
}
header("Content-type: text/xml");
// Iterate through the rows, adding XML nodes for each
while ($row = @mysqli_fetch_assoc($result)) {
    $node = $dom->createElement("marker");
    $newnode = $parnode->appendChild($node);
    $newnode->setAttribute("id", $row['Phaid']);
    $newnode->setAttribute("name", $row['Phaname']);
    $newnode->setAttribute("address", $row['Address']);
    $newnode->setAttribute("lat", $row['Latitude']);
    $newnode->setAttribute("lng", $row['Longitude']);
    $newnode->setAttribute("distance", $row['distance']);
}
echo $dom->saveXML();
