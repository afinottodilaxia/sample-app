using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using SampleMVCApp.Models;

namespace SampleMVCApp.Services
{
    public class ProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService()
        {
            _context = new ApplicationDbContext();
        }

        // Crea un nuovo prodotto
        public void Create(Prodotto prodotto)
        {
            if (prodotto == null)
                throw new ArgumentNullException(nameof(prodotto));

            _context.Prodotti.Add(prodotto);
            _context.SaveChanges();
        }

        // Ottieni tutti i prodotti
        public List<Prodotto> GetAll()
        {
            return _context.Prodotti.ToList();
        }

        // Ottieni un prodotto per ID
        public Prodotto GetById(int id)
        {
            return _context.Prodotti.Find(id);
        }

        // Aggiorna un prodotto esistente
        public void Update(Prodotto prodotto)
        {
            if (prodotto == null)
                throw new ArgumentNullException(nameof(prodotto));

            _context.Entry(prodotto).State = EntityState.Modified;
            _context.SaveChanges();
        }

        // Elimina un prodotto per ID
        public void Delete(int id)
        {
            var prodotto = _context.Prodotti.Find(id);
            if (prodotto == null)
                throw new KeyNotFoundException($"Prodotto con ID {id} non trovato.");

            _context.Prodotti.Remove(prodotto);
            _context.SaveChanges();
        }
    }
}
