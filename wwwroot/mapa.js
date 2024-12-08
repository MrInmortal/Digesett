function initMap(multas) {
    const map = new google.maps.Map(document.getElementById("map"), {
        center: { lat: 18.4861, lng: -69.9312 }, // Centro inicial del mapa
        zoom: 12,
    });

    multas.forEach((multa) => {
        const marker = new google.maps.Marker({
            position: { lat: multa.Lat, lng: multa.Lng },
            map: map,
            title: multa.Descripcion,
        });

        const infoWindow = new google.maps.InfoWindow({
            content: `<p>${multa.Descripcion}</p>`,
        });

        marker.addListener("click", () => {
            infoWindow.open(map, marker);
        });
    });
}
