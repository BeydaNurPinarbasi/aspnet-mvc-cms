using Cms.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Data.Interfaces.BlogInterfaces
{
  public interface IBlogRepository
  {

    Task<List<Blog>> GetBlogWithInclude();
  }
}
