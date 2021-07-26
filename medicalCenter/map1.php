<!DOCTYPE html>
<?php
session_start();
?>
<head>
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="initial-scale=1.0, user-scalable=no" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
    <title>Pharmacy Location in Maps</title>
    <style>
        /* Always set the map height explicitly to define the size of the div
     * element that contains the map. */
        #map {
            height: 100%;
        }

        /* Optional: Makes the  page fill the window. */
        html,
        body {
            height: 100%;
            margin: 0;
            padding: 0;
        }
    </style>
</head>

<body style="margin:0px; padding:0px;" onload="initMap()">
    <div style="width:300px;margin:auto;margin-top:25px;">
        <input class="" type="hidden" id="searchButton" value="Search" />
        <button style="width:300px;" class=" text-center btn btn-primary" onclick="getLocation()">Find</button>
        <select class="list list-group-item" id="locationSelect" style="width: 100%; visibility: hidden"></select>
    </div>


    <div id="map" style="width: 100%; height: 90%"></div>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script>
        var map;
        var markers = [];
        var infoWindow;
        var locationSelect;


        function initMap() {
            var lanka = {
                lat: 7.28686,
                lng: 80.6384,
            };
            map = new google.maps.Map(document.getElementById('map'), {
                center: lanka,
                zoom: 7,
                mapTypeId: 'roadmap',
                mapTypeControlOptions: {
                    style: google.maps.MapTypeControlStyle.DROPDOWN_MENU
                }
            });
            infoWindow = new google.maps.InfoWindow();

            document.getElementById("searchButton").onclick = searchLocations;

            locationSelect = document.getElementById("locationSelect");
            locationSelect.onchange = function() {
                var markerNum = locationSelect.options[locationSelect.selectedIndex].value;
                if (markerNum != "none") {
                    google.maps.event.trigger(markers[markerNum], 'click');
                }
            };
        }
        //using geolocation api -take the user location using gps....
        function getLocation() {
            if (navigator.geolocation) {
                navigator.geolocation.getCurrentPosition(function(position) {
                    searchLocationsNear(position);
                });
            }
            // url="https://www.googleapis.com/geolocation/v1/geolocate?key=AIzaSyD70HZPKSTuVuz1PeCZIy844hlzWFpYgLs";
            // data={
            //     "homeMobileCountryCode":413,
            //     "homeMobileNetworkCode":94
            // }
            // $.post(url,data,function(data,status){
            //     searchLocationsNear(data);
            //     console.log(data);
            // })
        }

        function searchLocations() {
            var address = document.getElementById("addressInput").value;
            var geocoder = new google.maps.Geocoder();
            geocoder.geocode({
                address: address
            }, function(results, status) {
                if (status == google.maps.GeocoderStatus.OK) {
                    searchLocationsNear(results[0].geometry.location);
                } else {
                    alert(address + ' not found');
                }
            });
        }

        function clearLocations() {
            infoWindow.close();
            for (var i = 0; i < markers.length; i++) {
                markers[i].setMap(null);
            }
            markers.length = 0;

            locationSelect.innerHTML = "";
            var option = document.createElement("option");
            option.value = "none";
            option.innerHTML = "See all results:";
            locationSelect.appendChild(option);
        }

        function searchLocationsNear(position) {
            clearLocations();

            var mylocation = new google.maps.LatLng(
                parseFloat(position.coords.latitude.toFixed(6)), // position.coords.latitude.toFixed(6) - from geolocation api javascript
                parseFloat(position.coords.longitude.toFixed(6)) // position.coords.longitude.toFixed(6)
				
                ); 
				console.log(position.coords.latitude.toFixed(6));
				console.log(position.coords.latitude.toFixed(6));
				

            //show patient current location
            myLocationMarker(mylocation, "My Location", "");

            var radius = 10;

            var searchUrl = 'storelocator.php?lat=' + position.coords.latitude.toFixed(6) + '&lng=' + position.coords.longitude.toFixed(6) + '&radius=' + radius; /*  position.coords.latitude.toFixed(6)  position.coords.longitude.toFixed(6)   */
            console.log(searchUrl);
			downloadUrl(searchUrl, function(data) {
                var xml = parseXml(data);
                var markerNodes = xml.documentElement.getElementsByTagName("marker");
                var bounds = new google.maps.LatLngBounds();
                if(markerNodes.length<1){
                    var latlang={
                        lat:parseFloat(position.coords.latitude.toFixed(6)),
                        lng:parseFloat(position.coords.longitude.toFixed(6))
                    };
                    bounds.extend(latlang);
                    alert("no pharmacy found around you");
                }
                for (var i = 0; i < markerNodes.length; i++) {
                    var id = markerNodes[i].getAttribute("id");
                    var name = markerNodes[i].getAttribute("name");
                    var address = markerNodes[i].getAttribute("address");
                    var distance = parseFloat(markerNodes[i].getAttribute("distance"));
                    var latlng = new google.maps.LatLng(
                        parseFloat(markerNodes[i].getAttribute("lat")),
                        parseFloat(markerNodes[i].getAttribute("lng")));

                    createOption(name, distance, i);
                    createMarker(latlng, name, address);
                    bounds.extend(latlng);
                }
                map.fitBounds(bounds)
                locationSelect.style.visibility = "visible";
                locationSelect.onchange = function() {
                    var markerNum = locationSelect.options[locationSelect.selectedIndex].value;
                    google.maps.event.trigger(markers[markerNum], 'click');
                };
            });
        }

        function createMarker(latlng, name, address) {
            var html = "<b>" + name + "</b> <br/>" + address;
            var marker = new google.maps.Marker({
                map: map,
                position: latlng
            });
            google.maps.event.addListener(marker, 'click', function() {
                infoWindow.setContent(html);
                infoWindow.open(map, marker);
            });
            markers.push(marker);
        }

        function myLocationMarker(latlng, name, address) {
            var html = "<b>" + name + "</b> <br/>" + address;
            var marker = new google.maps.Marker({
                map: map,
                position: latlng,
                icon: {
                    url: "http://maps.google.com/mapfiles/ms/icons/blue-dot.png"
                }
            });
            google.maps.event.addListener(marker, 'click', function() {
                infoWindow.setContent(html);
                infoWindow.open(map, marker);
            });
            markers.push(marker);
        }



        function createOption(name, distance, num) {
            var option = document.createElement("option");
            option.value = num;
            option.innerHTML = name;
            locationSelect.appendChild(option);
        }

        function downloadUrl(url, callback) {
            var request = window.ActiveXObject ?
                new ActiveXObject('Microsoft.XMLHTTP') :
                new XMLHttpRequest;

            request.onreadystatechange = function() {
                if (request.readyState == 4) {
                    request.onreadystatechange = doNothing;
                    callback(request.responseText, request.status);
                }
            };

            request.open('GET', url, true);
            request.send(null);
        }

        function parseXml(str) {
            if (window.ActiveXObject) {
                var doc = new ActiveXObject('Microsoft.XMLDOM');
                doc.loadXML(str);
                return doc;
            } else if (window.DOMParser) {
                return (new DOMParser).parseFromString(str, 'text/xml');
            }
        }

        function doNothing() {}
    </script>
    <script async defer src="https://maps.googleapis.com/maps/api/js?key=AIzaSyD70HZPKSTuVuz1PeCZIy844hlzWFpYgLs&callback=initMap">
    </script>
</body>

</html>