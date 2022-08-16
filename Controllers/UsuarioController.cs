using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Biblioteca.Controllers
{

    public class UsuarioController : Controller
    {
        // Action para registrar usuário
        public IActionResult CadastrarUsuario()
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaSeUsuarioAdmin(this);
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarUsuario(Usuario user)
        {
            user.Senha = Criptografia.TextoCriptografado(user.Senha);
            new UsuarioService().Inserir(user);
            return RedirectToAction("ListaUsuarios");
        }
        //Action que receba os dados do registro
        public IActionResult Login()
        {
            return View();
        }


        


        // Action Listar
        public IActionResult ListaUsuarios()
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaSeUsuarioAdmin(this);
            return View(new UsuarioService().Listar());
        }

        //Action de Editar
        public IActionResult EditarUsuario(int id)
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaSeUsuarioAdmin(this);
            Usuario u = new UsuarioService().Listar(id);
            return View(u);
        }

        [HttpPost]
        public IActionResult EditarUsuario(Usuario userEditado)
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaSeUsuarioAdmin(this);
            new UsuarioService().Editar(userEditado);
            return RedirectToAction("ListaUsuarios");
        }

        // Action de dados recebidos
        
        // Action de exclusão
        public IActionResult ExcluirUsuario(int id)
        {
            Autenticacao.CheckLogin(this);
            Autenticacao.verificaSeUsuarioAdmin(this);
            new UsuarioService().Excluir(id);
            return RedirectToAction("ListaUsuarios");
        }
        // Sair e Permissão
        public IActionResult Permissao()
        {
            Autenticacao.CheckLogin(this);
            return View();
        }
        public IActionResult Sair()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Home");
        }

    }
}