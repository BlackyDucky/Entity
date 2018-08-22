function initMap() {
    var uluru = { lat: 30, lng: 30 };

    var map = new google.maps.Map(document.getElementById('map'), {
        zoom: 7,
        center: uluru
    });

    var marker = new google.maps.Marker({

        map: map
    });

}

// TESTER
function initialize() {

    var address = (document.getElementById('my-address'));
    var autocomplete = new google.maps.places.Autocomplete(address);
    autocomplete.setTypes(['geocode']);
    google.maps.event.addListener(autocomplete, 'place_changed', function () {
        var place = autocomplete.getPlace();
        if (!place.geometry) {
            return;
        }

        var address = '';
        if (place.address_components) {
            address = [
                (place.address_components[0] && place.address_components[0].short_name || ''),
                (place.address_components[1] && place.address_components[1].short_name || ''),
                (place.address_components[2] && place.address_components[2].short_name || '')
            ].join(' ');
        }
    });
}


function codeAddress() {
    geocoder = new google.maps.Geocoder();
    var address = document.getElementById("my-address").value;
    geocoder.geocode({ 'address': address }, function (results, status) {
        if (status == google.maps.GeocoderStatus.OK) {

            alert("Latitude: " + results[0].geometry.location.lat());
            alert("Longitude: " + results[0].geometry.location.lng());
        }

        else {
            alert("Geocode was not successful for the following reason: " + status);
        }
    });
}
google.maps.event.addDomListener(window, 'load', initialize);


function submitAction() {
    alert("ins submit action");
    var uluru = { lat: 30, lng: 30 };
    var url = "https://maps.googleapis.com/maps/api/geocode/json?latlng="+uluru.lat+","+uluru.lng+"&key=AIzaSyBO7G4gpbTBOeTAmQztwp520oxspaqDQu4";
    loadDoc(url);
}

function loadDoc(url) {
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            var address_text = JSON.parse(this.responseText).results[0].formatted_address;
            alert("Response is: "+address_text);
            
        }
    };
    xhttp.open("GET", url, true);
    xhttp.send();
}

