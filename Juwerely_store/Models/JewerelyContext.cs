using Juwerely_store.Helpers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juwerely_store.Models
{
    public class JewerelyContext : DbContext
    {
        #region Constructors

        public JewerelyContext() : base(ConnectionControl.GetConnectionString())
        {

        }

        #endregion

        #region Properties

        public DbSet<Ware> Wares { get; set; }

        #endregion
    }
}
