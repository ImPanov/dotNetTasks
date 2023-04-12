// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
let button = document.getElementById('Next');
button.onclick = changeUrl;
function changeUrl(event) {
    var searchParams = new URLSearchParams(window.location.search);
    if (!searchParams.get("id")) {
        searchParams.set('id', 1);
        searchParams.append("handler","Id")
    } else {
        let numb = searchParams.get("id");
        searchParams.set('id', ++numb);
    }

    window.location = '/index?' + searchParams.toString();
}