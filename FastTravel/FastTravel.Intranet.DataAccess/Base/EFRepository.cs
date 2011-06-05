using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using FastTRavel.Intranet.DataAccess.Base;
using FastTravel.Intranet.DataAccess.Interface;

namespace FastTravel.Intranet.DataAccess.Base
{
	/// <summary>
	/// EF4 proxy-repository
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class EFRepository<T> : IRepository<T> where T : class
	{
		private ObjectContext _context;
		private IObjectSet<T> _objectSet;

		/// <summary>
		/// Context
		/// </summary>
		protected ObjectContext Context
		{
			get { return _context ?? (_context = GetCurrentUnitOfWork<EFUnitOfWork>().Context); }
		}

		protected IObjectSet<T> ObjectSet
		{
			get { return _objectSet ?? (_objectSet = this.Context.CreateObjectSet<T>()); }
		}

		/// <summary>
		/// Get current UnitOfWork
		/// </summary>
		/// <typeparam name="TUnitOfWork">UnitOfWork</typeparam>
		/// <returns>UnitOfWork</returns>
		public TUnitOfWork GetCurrentUnitOfWork<TUnitOfWork>() where TUnitOfWork : IUnitOfWork
		{
			return (TUnitOfWork)UnitOfWork.Current;
		}

		/// <summary>
		/// Fluent-query
		/// </summary>
		/// <returns></returns>
		public IQueryable<T> GetQuery()
		{
			return ObjectSet;
		}

		/// <summary>
		/// Get all entities
		/// </summary>
		/// <returns>Entities list</returns>
		public IEnumerable<T> GetAll()
		{
			return GetQuery().ToList();
		}

		/// <summary>
		/// Get page
		/// </summary>
		/// <param name="start">Page number</param>
		/// <param name="limit">Page size</param>
		/// <param name="sort">Sort by field</param>
		/// <param name="orderDirections">Sort direction ("ASC" or "DESC")</param>
		/// <param name="count">Total object count</param>
		/// <returns>List</returns>
		public List<T> GetPage(int start, int limit, string sort, OrderDirections orderDirections, out int count)
		{
			var result = GetQuery().Select(e => e);
			if (!string.IsNullOrEmpty(sort))
			{
				result = orderDirections == OrderDirections.ASC ? SortByQuery<T>(result, sort, true) : SortByQuery<T>(result, sort, false);
			}

			if (start >= 0 && limit > 0)
			{
				result = result.Skip(start).Take(limit);
			}
			count = GetQuery().Count();
			return result.ToList();
		}

		/// <summary>
		/// Sorting
		/// </summary>
		/// <typeparam name="T">Object</typeparam>
		/// <param name="q">Query</param>
		/// <param name="sort">Sort by field</param>
		/// <param name="ascending">Sort direction</param>
		/// <returns>Entities</returns>
		public IQueryable<T> SortByQuery<T>(IQueryable<T> q, string sort, bool ascending)
		{
			var p = Expression.Parameter(typeof(T), "e");

			if (typeof(T).GetProperty(sort).PropertyType == typeof(int?))
			{
				var x = Expression.Lambda<Func<T, int?>>(Expression.Property(p, sort), p);
				q = ascending ? q.OrderBy(x) : q.OrderByDescending(x);
			}
			else if (typeof(T).GetProperty(sort).PropertyType == typeof(int))
			{
				var x = Expression.Lambda<Func<T, int>>(Expression.Property(p, sort), p);
				q = ascending ? q.OrderBy(x) : q.OrderByDescending(x);
			}
			else if (typeof(T).GetProperty(sort).PropertyType == typeof(DateTime))
			{
				var x = Expression.Lambda<Func<T, DateTime>>(Expression.Property(p, sort), p);
				q = ascending ? q.OrderBy(x) : q.OrderByDescending(x);
			}
			else if (typeof(T).GetProperty(sort).PropertyType == typeof(DateTime?))
			{
				var x = Expression.Lambda<Func<T, DateTime>>(Expression.Property(p, sort), p);
				q = ascending ? q.OrderBy(x) : q.OrderByDescending(x);
			}
			else if (typeof(T).GetProperty(sort).PropertyType == typeof(Int64))
			{
				var x = Expression.Lambda<Func<T, Int64>>(Expression.Property(p, sort), p);
				q = ascending ? q.OrderBy(x) : q.OrderByDescending(x);
			}
			else
			{
				var x = Expression.Lambda<Func<T, object>>(Expression.Property(p, sort), p);
				q = ascending ? q.OrderBy(x) : q.OrderByDescending(x);
			}
			return q;
		}

		/// <summary>
		/// Find entities by parameters
		/// </summary>
		/// <param name="where">Parameter</param>
		/// <returns>Entity</returns>
		public IEnumerable<T> Find(Func<T, bool> where)
		{
			return this.ObjectSet.Where<T>(where);
		}

		/// <summary>
		/// Get single entity by parameter
		/// </summary>
		/// <param name="where">Parameter</param>
		/// <returns>Entity</returns>
		public T Single(Func<T, bool> where)
		{
			return this.ObjectSet.SingleOrDefault<T>(where);
		}

		/// <summary>
		/// Get first entity by parameter
		/// </summary>
		/// <param name="where">Parameter</param>
		/// <returns>Entity</returns>
		public T First(Func<T, bool> where)
		{
			return this.ObjectSet.First<T>(where);
		}

		/// <summary>
		/// Delete entity
		/// </summary>
		/// <param name="entity">Entity</param>
		public virtual void Delete(T entity)
		{
			this.ObjectSet.DeleteObject(entity);
		}

		/// <summary>
		/// Add entity
		/// </summary>
		/// <param name="entity">Entity</param>
		public virtual void Add(T entity)
		{
			this.ObjectSet.AddObject(entity);
		}

		/// <summary>
		/// Add entity in to context
		/// </summary>
		/// <param name="entity">Entity</param>
		public void Attach(T entity)
		{
			this.ObjectSet.Attach(entity);
		}

		/// <summary>
		/// Save changes
		/// </summary>
		public void SaveChanges()
		{
			this.Context.SaveChanges();
		}
	}

}
