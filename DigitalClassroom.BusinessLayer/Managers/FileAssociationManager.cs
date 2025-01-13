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
    public class FileAssociationManager : IFileAssociationService
    {
        private readonly IFileAssociationRepository _fileAssociationRepository;
        public FileAssociationManager(IFileAssociationRepository fileAssociationRepository)
        {
            _fileAssociationRepository = fileAssociationRepository;
        }
        public void Add(FileAssociation entity)
        {
            _fileAssociationRepository.Add(entity);
        }

        public void Delete(FileAssociation entity)
        {
            _fileAssociationRepository.Delete(entity);
        }

        public IEnumerable<FileAssociation> Find(Expression<Func<FileAssociation, bool>> predicate)
        {
            return _fileAssociationRepository.Find(predicate);
        }

        public IEnumerable<FileAssociation> GetAll()
        {
            return _fileAssociationRepository.GetAll();
        }

        public FileAssociation GetById(int id)
        {
            return _fileAssociationRepository.GetById(id);
        }

        public void Update(FileAssociation entity)
        {
            _fileAssociationRepository.Update(entity);
        }
    }
}
