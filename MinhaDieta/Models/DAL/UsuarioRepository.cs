﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MinhaDieta.Models.Entidades;

namespace MinhaDieta.Models.DAL
{
    public class UsuarioRepository : IDisposable
    {
        private MinhaDietaContext db;
        public UsuarioRepository(MinhaDietaContext _db) 
        {
            db = _db;
        }

        public void Salvar()
        {
            db.SaveChanges();
        }

        public void Adicionar(Usuario usuario) 
        {
            db.Usuarios.Add(usuario);
            this.Salvar();
        }
       
        public void Alterar(Usuario usuario)
        {
            db.Entry(usuario).State = EntityState.Modified;
            this.Salvar();
        }

        public Usuario BuscarPeloId(int id)
        {
            return db.Usuarios.Where(u => u.Id  == id).SingleOrDefault();
        }

        public Usuario BuscarPeloNome(string nome)
        {
            return db.Usuarios.Where(u => u.Nome.Equals(nome)).SingleOrDefault();
        }


        public bool ValidarLogin(string nome, string senha)
        {
            Usuario usuario = db.Usuarios
                                .Where(u => u.Nome.Equals(nome)
                                       && u.Senha.Equals(senha))
                                .SingleOrDefault();

            return usuario != null ? true : false;
        }


        public void Dispose()
        {
            db.Dispose();
        }
    }
}