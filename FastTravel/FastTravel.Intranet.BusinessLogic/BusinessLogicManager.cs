using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FastTravel.Intranet.DataAccess.Base;
using FastTRavel.Intranet.DataAccess.Base;
using FastTravel.Intranet.DataAccess.Interface;
using FastTravel.Intranet.DB;
using StructureMap;

namespace FastTravel.Intranet.BusinessLogic
{
	/// <summary>
	/// General manager
	/// </summary>
	public static class BusinessLogicManager
	{
		/// <summary>
		/// Init
		/// </summary>
		public static void Initialize()
		{
			ObjectFactory.Initialize(
				x =>
				{
					x.ForRequestedType<IUnitOfWorkFactory>().TheDefaultIsConcreteType<EFUnitOfWorkFactory>();
					x.ForRequestedType(typeof(IRepository<>)).TheDefaultIsConcreteType(typeof(EFRepository<>));
				}
			);

			// Set context for UnitOfWork factory 
			EFUnitOfWorkFactory.SetObjectContext(() => new FastTravelModelContainer());
		}

		/// <summary>
		/// Save in database
		/// </summary>
		public static void Commit()
		{
			UnitOfWork.Commit();
		}

		/// <summary>
		/// Safely save in database
		/// </summary>
		/// <returns></returns>
		public static bool TryCommit()
		{
			try
			{
				UnitOfWork.Commit();
				return true;
			}
			catch (Exception e)
			{
				return false;
			}
		}

		/// <summary>
		/// Destroy current UnitOfWork
		/// </summary>
		public static void Dispose()
		{
			UnitOfWork.Current.Dispose();
		}
	}

}
