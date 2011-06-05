using System;
using System.Collections;
using System.Threading;
using System.Web;
using FastTravel.Intranet.DataAccess.Interface;
using StructureMap;

namespace FastTRavel.Intranet.DataAccess.Base
{
	/// <summary>
	/// UnitOfWork manage
	/// </summary>
	public static class UnitOfWork
	{
		/// <summary>
		/// HttpContext key for UnitOfWork save
		/// </summary>
		private const string HTTPCONTEXTKEY = "FastTravel.Intranet.DataAccess.Base.HttpContext.Key";

		private static IUnitOfWorkFactory _unitOfWorkFactory;
		private static readonly Hashtable _threads = new Hashtable();

		/// <summary>
		/// Save in database
		/// </summary>
		public static void Commit()
		{
			IUnitOfWork unitOfWork = GetUnitOfWork();

			if (unitOfWork != null)
			{
				unitOfWork.Commit();
			}
		}

		/// <summary>
		/// Get current UnitOfWork
		/// </summary>
		public static IUnitOfWork Current
		{
			get
			{
				IUnitOfWork unitOfWork = GetUnitOfWork();

				if (unitOfWork == null)
				{
					_unitOfWorkFactory = ObjectFactory.GetInstance<IUnitOfWorkFactory>();
					unitOfWork = _unitOfWorkFactory.Create();
					SaveUnitOfWork(unitOfWork);
				}

				return unitOfWork;
			}
		}

		/// <summary>
		/// Get current UnitOfWork from HttpContext
		/// </summary>
		private static IUnitOfWork GetUnitOfWork()
		{
			if (HttpContext.Current != null)
			{
				if (HttpContext.Current.Items.Contains(HTTPCONTEXTKEY))
				{
					return (IUnitOfWork)HttpContext.Current.Items[HTTPCONTEXTKEY];
				}

				return null;
			}
			else
			{
				Thread thread = Thread.CurrentThread;
				if (string.IsNullOrEmpty(thread.Name))
				{
					thread.Name = Guid.NewGuid().ToString();
					return null;
				}
				else
				{
					lock (_threads.SyncRoot)
					{
						return (IUnitOfWork)_threads[Thread.CurrentThread.Name];
					}
				}
			}
		}

		/// <summary>
		/// Save UnitOfWork in HttpContext
		/// </summary>
		/// <param name="unitOfWork"></param>
		private static void SaveUnitOfWork(IUnitOfWork unitOfWork)
		{
			if (HttpContext.Current != null)
			{
				HttpContext.Current.Items[HTTPCONTEXTKEY] = unitOfWork;
			}
			else
			{
				lock (_threads.SyncRoot)
				{
					_threads[Thread.CurrentThread.Name] = unitOfWork;
				}
			}
		}
	}

}
