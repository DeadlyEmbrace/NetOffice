﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.CollectionsGeneric;

namespace NetOffice.OWC10Api
{
	/// <summary>
	/// DispatchInterface SchemaRowsources 
	/// SupportByVersion OWC10, 1
	/// </summary>
	[SupportByVersion("OWC10", 1)]
	[EntityType(EntityType.IsDispatchInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Property), HasIndexProperty(IndexInvoke.Property, "Item")]
	[TypeId("F5B39AA4-1480-11D3-8549-00C04FAC67D7")]
	public interface SchemaRowsources : ICOMObject, IEnumerableProvider<NetOffice.OWC10Api.SchemaRowsource>
	{
		#region Properties

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		[SupportByVersion("OWC10", 1)]
		Int32 Count { get; }

		/// <summary>
		/// SupportByVersion OWC10 1
		/// Get
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("OWC10", 1)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
		NetOffice.OWC10Api.SchemaRowsource this[object index] { get; }

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion OWC10 1
		/// </summary>
		/// <param name="name">string name</param>
		/// <param name="rowsourceType">NetOffice.OWC10Api.Enums.DscRowsourceTypeEnum rowsourceType</param>
		/// <param name="commandText">optional object commandText</param>
		[SupportByVersion("OWC10", 1)]
		NetOffice.OWC10Api.SchemaRowsource Add(string name, NetOffice.OWC10Api.Enums.DscRowsourceTypeEnum rowsourceType, object commandText);

		/// <summary>
		/// SupportByVersion OWC10 1
		/// </summary>
		/// <param name="name">string name</param>
		/// <param name="rowsourceType">NetOffice.OWC10Api.Enums.DscRowsourceTypeEnum rowsourceType</param>
		[CustomMethod]
		[SupportByVersion("OWC10", 1)]
		NetOffice.OWC10Api.SchemaRowsource Add(string name, NetOffice.OWC10Api.Enums.DscRowsourceTypeEnum rowsourceType);

		/// <summary>
		/// SupportByVersion OWC10 1
		/// </summary>
		/// <param name="name">string name</param>
		/// <param name="rowsourceType">NetOffice.OWC10Api.Enums.DscRowsourceTypeEnum rowsourceType</param>
		/// <param name="commandText">optional object commandText</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersion("OWC10", 1)]
		NetOffice.OWC10Api.SchemaRowsource AddNew(string name, NetOffice.OWC10Api.Enums.DscRowsourceTypeEnum rowsourceType, object commandText);

		/// <summary>
		/// SupportByVersion OWC10 1
		/// </summary>
		/// <param name="name">string name</param>
		/// <param name="rowsourceType">NetOffice.OWC10Api.Enums.DscRowsourceTypeEnum rowsourceType</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethod]
		[SupportByVersion("OWC10", 1)]
		NetOffice.OWC10Api.SchemaRowsource AddNew(string name, NetOffice.OWC10Api.Enums.DscRowsourceTypeEnum rowsourceType);

		/// <summary>
		/// SupportByVersion OWC10 1
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("OWC10", 1)]
		void Delete(object index);

		#endregion
	}
}
