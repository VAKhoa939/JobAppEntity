using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication
{
    class ApplyFormDAO : AnyDAO<ApplyForm>
    {
        public void Update(ApplyForm applyForm)
        {
            ApplyForm applyFormToUpdate = GetObject(applyForm.Id);
            applyFormToUpdate.CV = applyForm.CV;
            applyFormToUpdate.Coverletter = applyForm.Coverletter;
            applyFormToUpdate.Timesent = applyForm.Timesent;
            applyFormToUpdate.Status = applyForm.Status;
            db.SaveChanges();
        }
    }
}
