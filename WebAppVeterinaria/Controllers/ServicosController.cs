﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebAppVeterinaria.Data;
using WebAppVeterinaria.Entity;
using WebAppVeterinaria.ViewModels;

namespace WebAppVeterinaria.Controllers
{
    [Authorize]
    public class ServicosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ServicosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var lista = await _context.Servicos.Where(u => u.UsuarioId == userId).ToListAsync();

            return View(lista);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var detalhes = await _context.Servicos.FirstOrDefaultAsync(x => x.Id == id);

            return View(detalhes);
        }

        [HttpGet]
        public IActionResult Create()
        {
            TempData["UsuarioId"] = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Servico servico)
        {
            if (ModelState.IsValid)
            {
                TempData["UsuarioId"] = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                _context.Servicos.Add(servico);
                await _context.SaveChangesAsync();

                TempData["createSuccess"] = "Serviço cadastrado com Sucesso";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewData["error"] = "Houve um erro ao cadastraro o serviço";
                TempData["UsuarioId"] = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                return View(servico);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var servico = await _context.Servicos.FindAsync(id);

            TempData["UsuarioId"] = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var servicoViewModel = new ServicoViewModel();

            servicoViewModel.Descricao = servico.Descricao;
            servicoViewModel.Preco = servico.Preco;

            return View(servicoViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Servico servico)
        {
            if (!ModelState.IsValid) return View(servico);

            TempData["UsuarioId"] = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            _context.Servicos.Update(servico);
            await _context.SaveChangesAsync();

            TempData["updateSuccess"] = "Serviço atualizado com Sucesso";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var servico = await _context.Servicos.FindAsync(id);

            return View(servico);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Servico servico)
        {
            _context.Servicos.Remove(servico);
            await _context.SaveChangesAsync();

            TempData["deleteSuccess"] = "Serviço excluído com Sucesso";
            return RedirectToAction("Index");
        }
    }
}
