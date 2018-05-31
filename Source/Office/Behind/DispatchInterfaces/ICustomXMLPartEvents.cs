﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.OfficeApi;

namespace NetOffice.OfficeApi.Behind
{
    /// <summary>
    /// DispatchInterface ICustomXMLPartEvents 
    /// SupportByVersion Office, 12,14,15,16
    /// </summary>
    [SupportByVersion("Office", 12, 14, 15, 16)]
    [EntityType(EntityType.IsDispatchInterface)]
    public class ICustomXMLPartEvents : COMObject, NetOffice.OfficeApi.ICustomXMLPartEvents
    {
        #pragma warning disable

        #region Type Information

        /// <summary>
        /// Instance Type
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
        public override Type InstanceType
        {
            get
            {
                return LateBindingApiWrapperType;
            }
        }

        private static Type _type;

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(ICustomXMLPartEvents);
                return _type;
            }
        }

        #endregion

        #region Ctor

        /// <param name="factory">current used factory core</param>
        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="proxyShare">proxy share instead if com proxy</param>
        public ICustomXMLPartEvents(Core factory, ICOMObject parentObject, COMProxyShare proxyShare) : base(factory, parentObject, proxyShare)
        {
        }

        ///<param name="factory">current used factory core</param>
        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        public ICustomXMLPartEvents(Core factory, ICOMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
        {

        }

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public ICustomXMLPartEvents(ICOMObject parentObject, object comProxy) : base(parentObject, comProxy)
        {
        }

        ///<param name="factory">current used factory core</param>
        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public ICustomXMLPartEvents(Core factory, ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
        {

        }

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public ICustomXMLPartEvents(ICOMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
        {
        }

        ///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public ICustomXMLPartEvents(ICOMObject replacedObject) : base(replacedObject)
        {
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public ICustomXMLPartEvents() : base()
        {
        }

        /// <param name="progId">registered progID</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public ICustomXMLPartEvents(string progId) : base(progId)
        {
        }

        #endregion

        #region Properties

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        /// <param name="newNode">NetOffice.OfficeApi.CustomXMLNode newNode</param>
        /// <param name="inUndoRedo">bool inUndoRedo</param>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public void NodeAfterInsert(NetOffice.OfficeApi.CustomXMLNode newNode, bool inUndoRedo)
        {
            Factory.ExecuteMethod(this, "NodeAfterInsert", newNode, inUndoRedo);
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        /// <param name="oldNode">NetOffice.OfficeApi.CustomXMLNode oldNode</param>
        /// <param name="oldParentNode">NetOffice.OfficeApi.CustomXMLNode oldParentNode</param>
        /// <param name="oldNextSibling">NetOffice.OfficeApi.CustomXMLNode oldNextSibling</param>
        /// <param name="inUndoRedo">bool inUndoRedo</param>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public void NodeAfterDelete(NetOffice.OfficeApi.CustomXMLNode oldNode, NetOffice.OfficeApi.CustomXMLNode oldParentNode, NetOffice.OfficeApi.CustomXMLNode oldNextSibling, bool inUndoRedo)
        {
            Factory.ExecuteMethod(this, "NodeAfterDelete", oldNode, oldParentNode, oldNextSibling, inUndoRedo);
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        /// <param name="oldNode">NetOffice.OfficeApi.CustomXMLNode oldNode</param>
        /// <param name="newNode">NetOffice.OfficeApi.CustomXMLNode newNode</param>
        /// <param name="inUndoRedo">bool inUndoRedo</param>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public void NodeAfterReplace(NetOffice.OfficeApi.CustomXMLNode oldNode, NetOffice.OfficeApi.CustomXMLNode newNode, bool inUndoRedo)
        {
            Factory.ExecuteMethod(this, "NodeAfterReplace", oldNode, newNode, inUndoRedo);
        }

        #endregion

        #pragma warning restore
    }
}
