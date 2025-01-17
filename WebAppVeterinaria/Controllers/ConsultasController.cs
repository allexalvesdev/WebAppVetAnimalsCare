﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebAppVeterinaria.Data;
using WebAppVeterinaria.Entity;
using WebAppVeterinaria.ViewModels;
using X.PagedList;

namespace WebAppVeterinaria.Controllers
{
    [Authorize]
    public class ConsultasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ConsultasController(ApplicationDbContext context)
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
            var consultas = _context.Consultas
                .Include(c => c.Cliente)
                .Include(c => c.Veterinario)
                .Include(c => c.Animal)
                .Where(u => u.UsuarioId == userId)
                .OrderBy(c => c.DataConsulta)
                .Where(c => c.Cliente.NomeCompleto.Contains(search) || c.Animal.Nome.Contains(search));



            PagedList<Consulta> model = new PagedList<Consulta>(consultas, page, pageSize);

            return View("Index", model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var detalhes = await _context.Consultas
                .Include(c => c.Cliente)
                .Include(c => c.Veterinario)
                .Include(c => c.Animal)
                .FirstOrDefaultAsync(c => c.Id == id);

            return View(detalhes);
        }

        public IActionResult Create()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            ViewData["ClienteId"] = new SelectList(_context.Clientes.Where(u => u.UsuarioId == userId), "Id", "NomeCompleto");
            ViewData["VeterinarioId"] = new SelectList(_context.Veterinarios.Where(u => u.UsuarioId == userId), "Id", "NomeCompleto");
            ViewData["AnimalId"] = new SelectList(_context.Animais.Where(u => u.UsuarioId == userId), "Id", "Nome");

            TempData["UsuarioId"] = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Consulta consulta)
        {
            if (ModelState.IsValid)
            {
                TempData["UsuarioId"] = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

                _context.Consultas.Add(consulta);

                await _context.SaveChangesAsync();

                TempData["CreateSuccess"] = "Consulta cadastrado com Sucesso";

                return RedirectToAction(nameof(Index));
            }

            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "NomeCompleto", consulta.ClienteId);
            ViewData["VeterinarioId"] = new SelectList(_context.Veterinarios, "Id", "NomeCompleto", consulta.VeterinarioId);
            ViewData["AnimalId"] = new SelectList(_context.Animais, "Id", "Nome", consulta.AnimalId);

            TempData["error"] = "Houve um erro ao cadastraro a consulta";
            return View(consulta);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            var consulta = await _context.Consultas.FindAsync(id);
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            TempData["UsuarioId"] = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (id == null)
            {
                return NotFound();
            }

            if (consulta == null)
            {
                return NotFound();
            }

            var consultaViewModel = new ConsultaViewModel();

            consultaViewModel.AnimalId = consulta.AnimalId;
            consultaViewModel.ClienteId = consulta.ClienteId;
            consultaViewModel.VeterinarioId = consulta.VeterinarioId;
            consultaViewModel.DataCadastro = consulta.DataCadastro;
            consultaViewModel.DataConsulta = consulta.DataConsulta;
            consultaViewModel.DataRetorno = consulta.DataRetorno;
            consultaViewModel.Descricao = consulta.Descricao;
            consultaViewModel.Retorno = consulta.Retorno;
            consultaViewModel.Observacao = consulta.Observacao;
            consultaViewModel.Raca = consulta.Raca;
            consultaViewModel.TipoSexo = consulta.TipoSexo;
            consultaViewModel.TipoEspecie = consulta.TipoEspecie;
            consultaViewModel.Idade = consulta.Idade;
            consultaViewModel.Peso = consulta.Peso;
            consultaViewModel.HistoricoClinicoAnimal = consulta.HistoricoClinicoAnimal;
           

            ViewData["ClienteId"] = new SelectList(_context.Clientes.Where(u => u.UsuarioId == userId), "Id", "NomeCompleto", consulta.ClienteId);
            ViewData["VeterinarioId"] = new SelectList(_context.Veterinarios.Where(u => u.UsuarioId == userId), "Id", "NomeCompleto", consulta.VeterinarioId);
            ViewData["AnimalId"] = new SelectList(_context.Animais.Where(u => u.UsuarioId == userId), "Id", "Nome", consulta.AnimalId);

            return View(consultaViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Consulta consulta)
        {
            if (!ModelState.IsValid)
            {
                TempData["UsuarioId"] = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                ViewData["ClienteId"] = new SelectList(_context.Clientes.Where(u => u.UsuarioId == userId), "Id", "NomeCompleto", consulta.ClienteId);
                ViewData["VeterinarioId"] = new SelectList(_context.Veterinarios.Where(u => u.UsuarioId == userId), "Id", "NomeCompleto", consulta.VeterinarioId);
                ViewData["AnimalId"] = new SelectList(_context.Animais.Where(u => u.UsuarioId == userId), "Id", "Nome", consulta.AnimalId);

                return View(consulta);
            }

            TempData["UsuarioId"] = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            #region
            //consulta.AnimalId = consultaViewModel.AnimalId;
            //consulta.ClienteId = consultaViewModel.ClienteId;
            //consulta.VeterinarioId = consultaViewModel.VeterinarioId;
            //consulta.DataCadastro = consultaViewModel.DataCadastro;
            //consulta.DataConsulta = consultaViewModel.DataConsulta;
            //consulta.DataRetorno = consultaViewModel.DataRetorno;
            //consulta.Descricao = consultaViewModel.Descricao;
            //consulta.Retorno = consultaViewModel.Retorno;
            //consulta.Observacao = consultaViewModel.Observacao;
            //consulta.Raca = consultaViewModel.Raca;
            //consulta.TipoSexo = consultaViewModel.TipoSexo;
            //consulta.TipoEspecie = consultaViewModel.TipoEspecie;
            //consulta.Idade = consultaViewModel.Idade;
            //consulta.Peso = consultaViewModel.Peso;
            //consulta.HistoricoClinicoAnimal = consultaViewModel.HistoricoClinicoAnimal;
            #endregion

            _context.Consultas.Update(consulta);

            await _context.SaveChangesAsync();

            TempData["updateSuccess"] = "Consulta atualizada com Sucesso";
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var consulta = await _context.Consultas
                .Include(c => c.Cliente)
                .Include(c => c.Veterinario)
                .Include(c => c.Animal)
                .FirstOrDefaultAsync(m => m.Id == id);


            return View(consulta);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Consulta consulta)
        {
            if (!ModelState.IsValid) return View(consulta);

            _context.Consultas.Remove(consulta);

            await _context.SaveChangesAsync();
            TempData["deleteSuccess"] = "Consulta excluída com Sucesso";
            return RedirectToAction("Index");
        }

        public JsonResult LoadPet(int id)
        {
            var pet = _context.Animais.Where(x => x.ClienteId == id).ToList();

            return Json(new SelectList(pet, "Id", "Nome"));
        }

        public JsonResult BuscarPet(int id)
        {
            var pet = _context.Animais.Where(p => p.Id == id).FirstOrDefault();

            string[] result = new string[6];

            result[0] = pet.Raca;
            result[1] = pet.Idade;
            result[2] = pet.TipoEspecie.ToString();
            result[3] = pet.TipoSexo.ToString();
            result[4] = pet.Peso;
            result[5] = pet.Observacao;

            return Json(result);

        }
    }
}
