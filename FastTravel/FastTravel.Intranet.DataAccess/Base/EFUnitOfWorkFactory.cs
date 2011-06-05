using System;
using System.Data.Objects;
using FastTravel.Intranet.DataAccess.Interface;

namespace FastTravel.Intranet.DataAccess.Base
{
	/// <summary>
	/// UnitOfWork factory
	/// </summary>
	public class EFUnitOfWorkFactory : IUnitOfWorkFactory
	{
		private static Func<ObjectContext> _objectContextDelegate;
		private static readonly Object _lockObject = new object();

		/// <summary>
		/// Set context
		/// </summary>
		/// <param name="objectContextDelegate">Контекст</param>
		public static void SetObjectContext(Func<ObjectContext> objectContextDelegate)
		{
			_objectContextDelegate = objectContextDelegate;
		}

		/// <summary>
		/// Create UnitOfWork
		/// </summary>
		/// <returns>UnitOfWork</returns>
		public IUnitOfWork Create()
		{
			ObjectContext context;

			lock (_lockObject)
			{
				context = _objectContextDelegate();
			}

			return new EFUnitOfWork(context);
		}
	}

}
