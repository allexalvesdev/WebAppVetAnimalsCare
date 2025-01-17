﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebAppVeterinaria.Data;
using WebAppVeterinaria.Entity;
using WebAppVeterinaria.ViewModels;
using X.PagedList;
using System.Security.Claims;


namespace WebAppVeterinaria.Controllers
{
    [Authorize]
    public class ClientesController : Controller
    {

        private ApplicationDbContext _context;

        public ClientesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Index(int page = 1, int pageSize = 10)
        {
            var search = Request.Query["Search"].ToString();

            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var clientes = _context.Clientes
                .Include(c => c.Usuario)
                .OrderBy(x => x.Id)
                .Where(u => u.UsuarioId == userId)
                .Where(c => c.NomeCompleto.Contains(search));

            PagedList<Cliente> model = new PagedList<Cliente>(clientes, page, pageSize);

            ViewBag.Search = search;

            return View("Index", model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var detalhes = await _context.Clientes.FirstOrDefaultAsync(c => c.Id == id);

            return View(detalhes);
        }

        [HttpGet]
        public IActionResult Create()
        {
            TempData["UsuarioId"] = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                TempData["error"] = "Houve um erro ao cadastraro o cliente";
                TempData["UsuarioId"] = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                return View(cliente);
            }

            TempData["UsuarioId"] = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            _context.Clientes.Add(cliente);

            await _context.SaveChangesAsync();
            TempData["createSuccess"] = "Cliente cadastrado com Sucesso";
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);

            TempData["UsuarioId"] = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var clienteViewModel = new ClienteViewModel();

            clienteViewModel.NomeCompleto = cliente.NomeCompleto;
            clienteViewModel.Rg = cliente.Rg;
            clienteViewModel.Cpf = cliente.Cpf;
            clienteViewModel.Telefone = cliente.Telefone;
            clienteViewModel.Celular = cliente.Celular;
            clienteViewModel.Cep = cliente.Cep;
            clienteViewModel.Logradouro = cliente.Logradouro;
            clienteViewModel.Bairro = cliente.Bairro;
            clienteViewModel.Numero = cliente.Numero;
            clienteViewModel.Complemento = cliente.Complemento;
            clienteViewModel.Cidade = cliente.Cidade;
            clienteViewModel.Estado = cliente.Estado;
            clienteViewModel.Ativo = cliente.Ativo;


            return View(clienteViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                TempData["UsuarioId"] = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                return View(cliente);
            }


            _context.Clientes.Update(cliente);

            await _context.SaveChangesAsync();

            TempData["updateSuccess"] = "Cliente atualizado com Sucesso";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var cliente = await _context.Clientes
                .Include(c => c.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);

            return View(cliente);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                return View(cliente);
            }
            else
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();

                TempData["deleteSuccess"] = "Cliente excluído com Sucesso";
                return RedirectToAction("Index");
            }
        }

    }

}
