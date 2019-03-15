
//objeto literal
var index = {

    logar: function () {

        var obj = {
            id: 0,
            login: fd.getValById("txtLogin"),
            senha: fd.getValById("txtSenha")
        }

        fd.ajax("POST", "/Login/Logar", obj, index.logarSuccess, index.logarFail);
    },

    logarSuccess: function (retornoServer) {
        fd.getById("divMsg").innerHTML = "";
        fd.getById("divMsg").innerHTML = retornoServer.msg;
    },

    logarFail: function () {
        alert("deu erro na requisição");
    }
}




