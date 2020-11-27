using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DevIO.App.Data;
using DevIO.App.ViewModels;
using DevIO.Business.Interfaces;
using DevIO.Data.Repository;
using AutoMapper;
using DevIO.Business.Models;
using Microsoft.AspNetCore.Authorization;
using DevIO.App.Extensions;

namespace DevIO.App.Controllers
{    
    [Authorize]
    public class FornecedoresController : BaseController
    {
        private readonly IFornecedorRepository _context;
        private readonly IFornecedorService _fornecedorService;
        private readonly IEnderecoRepository _enderecoRepository;
        private readonly IMapper _mapper;

        public FornecedoresController(IFornecedorRepository context, IEnderecoRepository enderecoRepository, IMapper mapper,
            IFornecedorService fornecedorService, INotificador notificador) : base(notificador)
        {
            _context = context;
            _enderecoRepository = enderecoRepository;
            _mapper = mapper;
            _fornecedorService = fornecedorService;
        }

        [AllowAnonymous]
        [Route("lista-de-fornecedores")]
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<FornecedorViewModel>>(await _context.ObterTodos()));            
        }

        [AllowAnonymous]
        [Route("dados-do-fornecedor/{id:guid}")]
        public async Task<IActionResult> Details(Guid id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var FornecedorViewModel = _mapper.Map<FornecedorViewModel>(await _context.ObterFornecedorEndereco(id));
                
            if (FornecedorViewModel == null)
            {
                return NotFound();
            }

            return View(FornecedorViewModel);
        }

        [ClaimsAuthorize("Fornecedor", "Adicionar")]
        [Route("novo-fornecedor")]
        public IActionResult Create()
        {
            return View();
        }

        [ClaimsAuthorize("Fornecedor", "Adicionar")]
        [Route("novo-fornecedor")]
        [HttpPost]        
        public async Task<IActionResult> Create(FornecedorViewModel fornecedorViewModel)
        {
            if (!ModelState.IsValid) { 
                return View(fornecedorViewModel); 
            }
            
            var fornecedor = _mapper.Map<Fornecedor>(fornecedorViewModel);
            await _fornecedorService.Adicionar(fornecedor);

            if (!OperacaoValida()) { return View(fornecedorViewModel); }

            return RedirectToAction(nameof(Index));           
            
        }

        [ClaimsAuthorize("Fornecedor", "Editar")]
        [Route("editar-fornecedor/{id:guid}")]
        public async Task<IActionResult> Edit(Guid id)
        {
            var FornecedorViewModel = _mapper.Map<FornecedorViewModel>(await _context.ObterFornecedorProdutosEndereco(id));
            if (FornecedorViewModel == null)
            {
                return NotFound();
            }
            return View(FornecedorViewModel);
        }

        [ClaimsAuthorize("Fornecedor", "Editar")]
        [Route("editar-fornecedor/{id:guid}")]
        [HttpPost]        
        public async Task<IActionResult> Edit(Guid id,FornecedorViewModel FornecedorViewModel)
        {
            if (id != FornecedorViewModel.Id) { return NotFound(); }

            if (!ModelState.IsValid) return View(FornecedorViewModel);

            await _fornecedorService.Atualizar(_mapper.Map<Fornecedor>(FornecedorViewModel));

            if (!OperacaoValida()) { return View(await ObterFornecedorProdutosEndereco(id)); }

            return RedirectToAction(nameof(Index));
        }

        [ClaimsAuthorize("Fornecedor", "Excluir")]
        [Route("excluir-fornecedor/{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var FornecedorViewModel = await ObterFornecedorEndereco(id);
            if (FornecedorViewModel == null)
            {
                return NotFound();
            }

            return View(FornecedorViewModel);
        }

        [ClaimsAuthorize("Fornecedor", "Excluir")]
        [Route("excluir-fornecedor/{id:guid}")]
        [HttpPost, ActionName("Delete")]        
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var FornecedorViewModel = await _context.ObterFornecedorEndereco(id);
            if (FornecedorViewModel == null) return NotFound();

            await _fornecedorService.Remover(id);

            if (!OperacaoValida()) { return View(FornecedorViewModel); }

            return RedirectToAction(nameof(Index));

        }

        [ClaimsAuthorize("Fornecedor", "Editar")]
        [Route("atualizar-endereco-fornecedor/{id:guid}")]
        public async Task<IActionResult> AtualizarEndereco(Guid id)
        {
            var fornecedor = await ObterFornecedorEndereco(id);

            if(fornecedor == null)
            {
                return NotFound();
            }

            return PartialView("_AtualizarEndereco", new FornecedorViewModel { Endereco = fornecedor.Endereco });            
        }

        [Route("obter-endereco-fornecedor/{id:guid}")]
        public async Task<IActionResult> ObterEndereco(Guid id)
        {
            var fornecedor = await ObterFornecedorEndereco(id);

            if(fornecedor == null)
            {
                return NotFound();
            }

            return PartialView("_DetalhesEndereco", fornecedor);
        }

        [ClaimsAuthorize("Fornecedor", "Editar")]
        [Route("atualizar-endereco-fornecedor/{id:guid}")]
        [HttpPost]        
        public async Task<IActionResult> AtualizarEndereco(FornecedorViewModel fornecedorViewModel)
        {
            ModelState.Remove("Nome");
            ModelState.Remove("Documento");

            if (!ModelState.IsValid) return PartialView("_AtualizarEndereco", fornecedorViewModel);

            await _fornecedorService.AtualizarEndereco(_mapper.Map<Endereco>(fornecedorViewModel.Endereco));

            if (!OperacaoValida()) { return PartialView("_AtualizarEndereco", fornecedorViewModel); }

            var url = Url.Action("ObterEndereco", "Fornecedores", new { id = fornecedorViewModel.Endereco.FornecedorId });
            return Json(new { success = true, url });
        }
        private async Task<FornecedorViewModel> ObterFornecedorEndereco(Guid id)
        {
            return _mapper.Map<FornecedorViewModel>(await _context.ObterFornecedorEndereco(id));
        }

        private async Task<FornecedorViewModel> ObterFornecedorProdutosEndereco(Guid id)
        {
            return _mapper.Map<FornecedorViewModel>(await _context.ObterFornecedorProdutosEndereco(id));
        }
    }
}

