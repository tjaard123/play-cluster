let url = 'http://lala.io:32533/accounts'
document.getElementById('url').value = url;

let responseBlock = document.getElementById('responseBlock');

var get = () => {
    atomic(document.getElementById('url').value)
        .then(function (response) {
            responseBlock.style.color = "black";
            responseBlock.innerText = JSON.stringify(response.data, null, 2);
        })
        .catch(function (error) {
            responseBlock.style.color = "red";
            responseBlock.innerText = JSON.stringify(error, null, 2);
        });
}