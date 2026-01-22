(function () {
    function applyLogo() {
        const link = document.querySelector(".swagger-ui .topbar a.link") || document.querySelector(".swagger-ui .topbar-wrapper a.link");

        if (link) {
            link.querySelectorAll("img, svg").forEach(e => e.remove());
            link.querySelectorAll("span").forEach(e => (e.style.display = "none"));

            const img = document.createElement("img");
            img.src = "/assets/ecnorsa.jpeg";
            img.alt = "ECNORSA";
            img.style.height = "60px";
            img.style.width = "250px";
            img.style.display = "block";
            img.style.borderRadius = "5px"; // radio

            link.prepend(img);
        }

        // Oculta el bloque "ENCORSApi 1.0 OAS 3.0 /swagger/v1/swagger.json"
        const info = document.querySelector(".swagger-ui .info");
        if (info) info.style.display = "none";

        //  Oculta la sección Schemas / Models
        //const models = document.querySelectorAll(
        //    ".swagger-ui .models, .swagger-ui .models-wrapper, .swagger-ui .model-container"
        //);

        //models.forEach(el => {
        //    el.style.display = "none";
        //});

    }

    let tries = 0;
    const timer = setInterval(() => {
        tries++;
        applyLogo();
        if (tries > 30) clearInterval(timer);
    }, 200);
})();
