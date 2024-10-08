﻿using Bloco_de_notas.DAO;
using Bloco_de_notas.DAO.Interfaces;
using Bloco_de_notas.Facade.Interfaces;
using Bloco_de_notas.Models;

namespace Bloco_de_notas.Facade {
    public class FacadeNota : IFacadeNota {
        public IDAOGeneric DAO { get; set; }

        public FacadeNota() => DAO = new DAONota();
        
        public void SalvarNota(EntidadeDominio entidade) => DAO.Insert(entidade);

        public List<EntidadeDominio> SelecionarTodasNotas() =>  DAO.SelectAll();

        public EntidadeDominio SelecionarPorId(int Id) => DAO.SelectById(Id);

        public void AtualizarNota(EntidadeDominio entidade) => DAO.Update(entidade);
        
        public void ApagarNota(int Id) => DAO.Delete(Id);
    }
}
    