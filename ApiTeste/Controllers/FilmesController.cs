using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using ApiTeste.Helpers;
using ApiTeste.Models;

namespace ApiTeste.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        const int PAGE_SIZE = 20;
        private List<Filme> _Filmes;
        public FilmesController()
        {
            var filme = new Filme();
            _Filmes = filme.CriaListaDeFilmes();
        }



        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public IEnumerable<Filme> Get()
        {
            return _Filmes;
        }


        [HttpGet]
        [AllowAnonymous]
        public IEnumerable<Filme> FilmesPorPagina(int pagina)
        {
            
            var filmes = ListExtensions.ChunkBy(_Filmes, PAGE_SIZE);

            if (pagina >= filmes.Count)
            {
                throw new ArgumentException("Pagina inválida");
            }

            return filmes[pagina];
        }



        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IEnumerable<Filme> BuscaFilmeContendo(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new ArgumentException("Entrada não pode ser nula ou vazia");
            }
            IList<Filme> filmesEncontrados = new List<Filme>();

            foreach (var filme in _Filmes)
            {
                if (filme.Nome.ToUpper().Contains(nome.ToUpper()))
                {
                    filmesEncontrados.Add(filme);
                }
            }
            return filmesEncontrados;
        }


        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IEnumerable<Filme> BuscaFilmeUsandoTresPrimeirosCaracteres(string entrada)
        {
            if (string.IsNullOrEmpty(entrada))
            {
                throw new ArgumentException("Entrada não pode ser nula ou vazia");
            }
            if(entrada.Length > 3)
            {
                throw new ArgumentException("Quantidade de caracteres excede a permitida");
            }

            IList<Filme> filmesEncontrados = new List<Filme>();
            foreach (var filme in _Filmes)
            {
                if (filme.Nome.ToUpper().StartsWith(entrada.ToUpper().Substring(0, 3)))
                {
                    filmesEncontrados.Add(filme);
                }
            }
            return filmesEncontrados;
        }

    }
}

