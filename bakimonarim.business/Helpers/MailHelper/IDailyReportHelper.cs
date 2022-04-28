using bakimonarim.core.Utilities.Results;
using bakimonarim.entity.Dto;

namespace bakimonarim.business.Helpers.MailHelper
{
    public interface IDailyReportHelper
    {
        public IResult CreateDailyReport(DeletedVarlikLogModelDto varlik);
    }
}
