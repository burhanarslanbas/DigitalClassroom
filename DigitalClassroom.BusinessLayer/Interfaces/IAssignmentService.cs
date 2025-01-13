using DigitalClassroom.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClassroom.BusinessLayer.Interfaces
{
    public interface IAssignmentService: IGenericService<Assignment>
    {
        void DeleteAssignmentAndStudentSubmissions(int assignmentId);   
    }
}
