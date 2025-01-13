using DigitalClassroom.DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClassroom.DataAccessLayer.Repositories
{
    // GenericRepository veritabanı işlemlerini tekrar tekrar yazmamak için oluşturulmuş bir sınıftır.
    // GenericRepository sınıfı veritabanı işlemlerini gerçekleştirmek için DbContext türünden ve DbSet türünden bir nesne alır.
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        // Veritabanı bağlamı nesnesi
        private readonly DbContext _context;
        // Veritabanı seti nesnesi
        private readonly DbSet<T> _dbSet;
        // Kurucu metot ile veritabanı bağlamı ve seti alınır
        public GenericRepository(DbContext context)
        {
            _context = context;
            // Set metpdu ile veritabanı seti nesnesi alınır
            _dbSet = context.Set<T>();
        }
        public void Add(T entity)
        {
            // Veritabanına yeni bir varlık ekle
            _dbSet.Add(entity);
            // Değişiklikleri veritabanına uygula
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            // Veritabanından varlığı sil
            _dbSet.Remove(entity);
            // Değişiklikleri veritabanına uygula
            _context.SaveChanges();
        }

        // IEnumerable<T> : T türünden bir koleksiyon döndüren metot
        // Expression<Func<T, bool>> predicate : T türünden bir varlık döndüren ve bool türünden bir değer alan bir fonksiyon
        // predicate : koşul
        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            // Veritabanında ilgili koşulu sağlayan varlıkları getir
            return _dbSet.Where(predicate).ToList();
        }

        public IEnumerable<T> GetAll()
        {
            // Veritabanındaki tüm varlıkları getir
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            // Veritabanından ilgili id'ye sahip varlığı getir
            return _dbSet.Find(id);
        }

        public void Update(T entity)
        {
            // Veritabanında ilgili varlığı güncelle
            _dbSet.AddOrUpdate(entity);
            // Değişiklikleri veritabanına uygula
            _context.SaveChanges();
        }
    }
}
