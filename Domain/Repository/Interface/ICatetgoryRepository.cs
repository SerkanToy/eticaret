using eticaret.Domain.Core.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eticaret.Domain.Repository.Interface
{
    public interface ICatetgoryRepository: IRepository<Category>
    {
        List<Category> CategoryJoin(string flag, bool isDelete = false);
        SelectList CategorySelect(int[] CategoryId = null);

    }
}
