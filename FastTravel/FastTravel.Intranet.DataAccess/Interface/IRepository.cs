using System;
using System.Collections.Generic;
using System.Linq;
using FastTravel.Intranet.DataAccess.Base;

namespace FastTravel.Intranet.DataAccess.Interface
{
	/// <summary>
	/// Repository interface
	/// </summary>
	/// <typeparam name="T">Entity</typeparam>
	public interface IRepository<T> where T : class
	{
		IQueryable<T> GetQuery();

		/// <summary>
		/// Get all entities
		/// </summary>
		/// <returns>Entities list</returns>
		IEnumerable<T> GetAll();

		/// <summary>
		/// Get page
		/// </summary>
		/// <param name="start">Page number</param>
		/// <param name="limit">Page size</param>
		/// <param name="sort">Sort by field</param>
		/// <param name="orderDirections">Sort direction ("ASC" or "DESC")</param>
		/// <param name="count">Total object count</param>
		/// <returns>List</returns>
		List<T> GetPage(int start, int limit, string sort, OrderDirections orderDirections, out int count);

		/// <summary>
		/// Sorting
		/// </summary>
		/// <typeparam name="T">Object</typeparam>
		/// <param name="q">Query</param>
		/// <param name="sort">Sort by field</param>
		/// <param name="ascending">Sort direction</param>
		/// <returns>Entities</returns>
		IQueryable<T> SortByQuery<T>(IQueryable<T> q, string sort, bool ascending);

		/// <summary>
		/// Find entities by parameters
		/// </summary>
		/// <param name="where">Parameter</param>
		/// <returns>Entity</returns>
		IEnumerable<T> Find(Func<T, bool> where);

		/// <summary>
		/// Get single entity by parameter
		/// </summary>
		/// <param name="where">Parameter</param>
		/// <returns>Entity</returns>
		T Single(Func<T, bool> where);

		/// <summary>
		/// Get first entity by parameter
		/// </summary>
		/// <param name="where">Parameter</param>
		/// <returns>Entity</returns>
		T First(Func<T, bool> where);

		/// <summary>
		/// Delete entity
		/// </summary>
		/// <param name="entity">Entity</param>
		void Delete(T entity);

		/// <summary>
		/// Add entity
		/// </summary>
		/// <param name="entity">Entity</param>
		void Add(T entity);

		/// <summary>
		/// Add entity in to context
		/// </summary>
		/// <param name="entity">Entity</param>
		void Attach(T entity);

		/// <summary>
		/// Save changes
		/// </summary>
		void SaveChanges();
	}

}
