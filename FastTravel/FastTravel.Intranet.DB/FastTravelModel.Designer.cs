﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace FastTravel.Intranet.DB
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class FastTravelModelContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new FastTravelModelContainer object using the connection string found in the 'FastTravelModelContainer' section of the application configuration file.
        /// </summary>
        public FastTravelModelContainer() : base("name=FastTravelModelContainer", "FastTravelModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new FastTravelModelContainer object.
        /// </summary>
        public FastTravelModelContainer(string connectionString) : base(connectionString, "FastTravelModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new FastTravelModelContainer object.
        /// </summary>
        public FastTravelModelContainer(EntityConnection connection) : base(connection, "FastTravelModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
    }
    

    #endregion
    
    
}
