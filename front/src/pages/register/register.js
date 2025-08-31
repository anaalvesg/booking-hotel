document.querySelector("#confirm-button").addEventListener("click", function () { 
    let msg = ''

    if (document.querySelector("#name").value.length < 3 || !isNaN(document.querySelector("#name").value))  {
        msg+= 'Nome inválido'
    }

    if (document.querySelector("#cpf").value.length != 11 || isNaN(document.querySelector("#cpf").value)) {
        msg+= '\n CPF inválido'
    }

    if (document.querySelector("#birth-date").value == null) {
        msg+= '\n Data de nascimento inválida'
    }

    if (document.querySelector("#password").value.length < 6) {
        msg+= '\n Senha fraca'
    }

    if (document.querySelector("#confirm-password").value != document.querySelector("#password").value) {
        msg+= '\n Senhas não coincidem'
    }

    console.log(msg)
})
