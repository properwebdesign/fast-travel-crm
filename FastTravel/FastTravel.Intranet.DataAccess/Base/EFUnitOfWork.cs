using System;
using System.Data.Objects;
using FastTravel.Intranet.DataAccess.Interface;

namespace FastTravel.Intranet.DataAccess.Base
{
	/// <summary>
	/// EF4 UnitOfWork
	/// </summary>
	public class EFUnitOfWork : IUnitOfWork, IDisposable
	{
		/// <summary>
		/// Context
		/// </summary>
		public ObjectContext Context { get; private set; }

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="context">Context</param>
		public EFUnitOfWork(ObjectContext context)
		{
			Context = context;
			context.ContextOptions.LazyLoadingEnabled = true;
		}

		/// <summary>
		/// Save in database
		/// </summary>
		public void Commit()
		{
			Context.SaveChanges();
		}

		/// <summary>
		/// Destroy context
		/// </summary>
		public void Dispose()
		{
			if (Context != null)
			{
				Context.Dispose();
				Context = null;
			}

			GC.SuppressFinalize(this);
		}
	}

}
