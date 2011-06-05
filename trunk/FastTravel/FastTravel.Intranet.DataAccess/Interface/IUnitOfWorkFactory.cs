namespace FastTravel.Intranet.DataAccess.Interface
{
	/// <summary>
	/// UnitOfwork factory interface
	/// </summary>
	public interface IUnitOfWorkFactory
	{
		/// <summary>
		/// Create new UnitOfWork
		/// </summary>
		/// <returns>UnitOfWork</returns>
		IUnitOfWork Create();
	}

}
