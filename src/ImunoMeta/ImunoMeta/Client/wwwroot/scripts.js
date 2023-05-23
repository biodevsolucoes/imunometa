window.getCurrentPosition = function (callback) {
    navigator.geolocation.getCurrentPosition(function (position) {
        callback.invokeMethodAsync('Invoke', true, position.coords.latitude, position.coords.longitude);
    }, function (error) {
        callback.invokeMethodAsync('Invoke', false, 0, 0);
    });
};

window.loadGoogleMapsScript = function () {
    return new Promise((resolve, reject) => {
        if (window.google && window.google.maps) {
            resolve();
        } else {
            const script = document.createElement("script");
            script.src = "https://maps.googleapis.com/maps/api/js?key=AIzaSyDmAW7wmqmdXGad7uTul6ziPdRaJVGnJxY&libraries=places";
            script.async = true;
            script.defer = true;
            script.onload = resolve;
            script.onerror = reject;
            document.head.appendChild(script);
        }
    });
}
function handleTrocarModal() {
    paginaInformacao.classList.add("d-none")
    paginaConfirmacao.classList.remove("d-none")
}

function handleCompletarModal() {
    paginaInformacao.classList.remove("d-none")
    paginaConfirmacao.classList.add("d-none")
    modal.classList.add("d-none")
    alert("A disponibilidade de vacinas por inteligência coletiva não foi implementada a nível de protótipo.");
}

function handleFecharModal() {
    paginaInformacao.classList.remove("d-none")
    paginaConfirmacao.classList.add("d-none")
    modal.classList.add("d-none")
}

window.initializeMap = function (latitude, longitude, locais) {
    const mapOptions = {
        center: { lat: latitude, lng: longitude },
        zoom: 14
    };

    const map = new google.maps.Map(document.getElementById("mapCanvas"), mapOptions);

    var iconeVacinacao = {
        url: 'local.png',
        scaledSize: new google.maps.Size(70, 70)
    };

    var iconeUsuario = {
        url: 'userLocalization.png',
        scaledSize: new google.maps.Size(70, 70)
    };

    var usuario = new google.maps.Marker({
        position: { lat: latitude, lng: longitude },
        map: map,
        icon: iconeUsuario,
        title: 'Você'
    });

    console.log("======== locais ===========")
    console.log(locais);

    locais.forEach(local => {
        var marcador = new google.maps.Marker({
            position: { lat: local.latitude, lng: local.longitude },
            map: map,
            icon: iconeVacinacao,
            title: local.nome
        })

        marcador.addListener('click', function () {
            var modal = document.getElementById("modal");
            var paginaInformacao = document.getElementById("paginaInformacao");
            var paginaConfirmacao = document.getElementById("paginaConfirmacao");
            var btnFechar = document.getElementsByClassName("modal-close");

            var titulo = document.getElementById("localTitulo");
            var endereco = document.getElementById("localEndereco");
            var img = document.getElementById("localImg");

            titulo.innerHTML = local.nome
            img.removeAttribute("src")
            img.setAttribute("src", `https://maps.googleapis.com/maps/api/staticmap?center=${local.latitude},${local.longitude}&zoom=12&size=300x300&markers=color:red|label:A|${local.latitude},${local.longitude}&key=AIzaSyDmAW7wmqmdXGad7uTul6ziPdRaJVGnJxY`)
            endereco.innerHTML = `${local.endereco}, ${local.cidade}, ${local.uf}`


            modal.classList.remove("d-none");
        })
    })
}