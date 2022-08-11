// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function validarLivro(){
    var titulo = formularioLivro.titulo.value;
    var autor = document.getElementById("autor");
    var ano = document.getElementById("ano");
    
    
    if(titulo == "" ) {
        alert('Preencha o campo Título');
        formularioLivro.titulo.focus();
        return false;
    }

    if(autor.value == "" ) {
        alert('Preencha o campo Autor');
        formularioLivro.autor.focus();
        return false;
    }

    if(ano.value == "" ) {
        alert('Preencha o campo Ano');
        formularioLivro.ano.focus();
        return false;
    }

   

}

function validarEmprestimo(){
    var nomeUsuario = document.getElementById("nomeUsuario");
    var telefone = document.getElementById("telefone");
    var dataEmp = document.getElementById("dataEmp");
    var dataDev = document.getElementById("dataDev");
    var livroEmp = document.getElementById("livroEmp");
    
    
    if(nomeUsuario.value == "" ) {
        alert('Preencha o campo Nome');
        formularioEmprestimo.nomeUsuario.focus();
        return false;
    }

    if(telefone.value == "" ) {
        alert('Preencha o campo Telefone');
        formularioEmprestimo.telefone.focus();
        return false;
    }

    if(dataEmp.value == "" ) {
        alert('Preencha o campo Data de Empréstimo');
        formularioEmprestimo.dataEmp.focus();
        return false;
    }

    if(dataDev.value == "" ) {
        alert('Preencha o campo Data de Devolução');
        formularioEmprestimo.dataDev.focus();
        return false;
    }

    if(livroEmp.value == "" ) {
        alert('Preencha o campo Livro');
        formularioEmprestimo.livroEmp.focus();
        return false;
    }
   

}