const uri = 'https://localhost:7085/Rewrite'
const TEXT = 'я съел кота бориса'
async function send(text) {
    fetch(uri, {
        method: 'POST',
        headers: {
            'Content-type': "application/json"
            },
        body: JSON.stringify({ name: 'я съел кота бориса' })
    }).then(response => response.text())
        .then(responseText => document.getElementById("textForm").value = responseText);
    
}

async function getText() {
    await fetch(uri, {
        method: "GET",        
        headers: { "Accept": "text/plain" }
    }).then(response => response.text())
        .then(responseText => document.getElementById("textForm").value = responseText);
    

}


document.getElementById("sendBtn").addEventListener("click", () => {
    const text = document.getElementById("textForm").value;
    send(TEXT);
});
