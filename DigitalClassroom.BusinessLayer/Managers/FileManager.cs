using DigitalClassroom.BusinessLayer.Interfaces;
using DigitalClassroom.DataAccessLayer.Interfaces;
using DigitalClassroom.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClassroom.BusinessLayer.Managers
{
    public class FileManager : IFileService
    {
        private readonly IFileRepository _fileRepository;
        public FileManager(IFileRepository fileRepository)
        {
            _fileRepository = fileRepository;
        }
        public void Add(File entity)
        {
            _fileRepository.Add(entity);
        }

        public void Delete(File entity)
        {
            _fileRepository.Delete(entity);
        }

        public IEnumerable<File> Find(Expression<Func<File, bool>> predicate)
        {
            return _fileRepository.Find(predicate);
        }

        public IEnumerable<File> GetAll()
        {
            return _fileRepository.GetAll();
        }

        public File GetById(int id)
        {
            return _fileRepository.GetById(id);
        }

        public void Update(File entity)
        {
            _fileRepository.Update(entity);
        }
    }
}
