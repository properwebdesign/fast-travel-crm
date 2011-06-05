using System;

namespace FastTravel.Intranet.DataAccess.Interface
{
	/// <summary>
	/// UnitOfWork interface
	/// </summary>
	public interface IUnitOfWork : IDisposable
	{
		/// <summary>
		/// Save in database
		/// </summary>
		void Commit();
	}
}
