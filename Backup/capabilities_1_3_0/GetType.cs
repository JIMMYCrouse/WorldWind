//
// GetType.cs.cs
//
// This file was generated by XMLSPY 2004 Enterprise Edition.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the XMLSPY Documentation for further details.
// http://www.altova.com/xmlspy
//


using System;
using System.Collections;
using System.Xml;
using Altova.Types;

namespace capabilities_1_3_0.wms
{
	public class GetType : Altova.Xml.Node
	{
		#region Forward constructors
		public GetType() : base() { SetCollectionParents(); }
		public GetType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public GetType(XmlNode node) : base(node) { SetCollectionParents(); }
		public GetType(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

			for (int i = 0; i < DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "OnlineResource"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "OnlineResource", i);
				InternalAdjustPrefix(DOMNode, true);
				new OnlineResourceType(DOMNode).AdjustPrefix();
			}
		}


		#region OnlineResource accessor methods
		public int GetOnlineResourceMinCount()
		{
			return 1;
		}

		public int OnlineResourceMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetOnlineResourceMaxCount()
		{
			return 1;
		}

		public int OnlineResourceMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetOnlineResourceCount()
		{
			return DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "OnlineResource");
		}

		public int OnlineResourceCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "OnlineResource");
			}
		}

		public bool HasOnlineResource()
		{
			return HasDomChild(NodeType.Element, "http://www.opengis.net/wms", "OnlineResource");
		}

		public OnlineResourceType GetOnlineResourceAt(int index)
		{
			return new OnlineResourceType(GetDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "OnlineResource", index));
		}

		public OnlineResourceType GetOnlineResource()
		{
			return GetOnlineResourceAt(0);
		}

		public OnlineResourceType OnlineResource
		{
			get
			{
				return GetOnlineResourceAt(0);
			}
		}

		public void RemoveOnlineResourceAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "OnlineResource", index);
		}

		public void RemoveOnlineResource()
		{
			while (HasOnlineResource())
				RemoveOnlineResourceAt(0);
		}

		public void AddOnlineResource(OnlineResourceType newValue)
		{
			AppendDomElement("http://www.opengis.net/wms", "OnlineResource", newValue);
		}

		public void InsertOnlineResourceAt(OnlineResourceType newValue, int index)
		{
			InsertDomElementAt("http://www.opengis.net/wms", "OnlineResource", index, newValue);
		}

		public void ReplaceOnlineResourceAt(OnlineResourceType newValue, int index)
		{
			ReplaceDomElementAt("http://www.opengis.net/wms", "OnlineResource", index, newValue);
		}
		#endregion // OnlineResource accessor methods

		#region OnlineResource collection
        public OnlineResourceCollection	MyOnlineResources = new OnlineResourceCollection( );

        public class OnlineResourceCollection: IEnumerable
        {
            GetType parent;
            public GetType Parent
			{
				set
				{
					parent = value;
				}
			}
			public OnlineResourceEnumerator GetEnumerator() 
			{
				return new OnlineResourceEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class OnlineResourceEnumerator: IEnumerator 
        {
			int nIndex;
			GetType parent;
			public OnlineResourceEnumerator(GetType par) 
			{
				parent = par;
				nIndex = -1;
			}
			public void Reset() 
			{
				nIndex = -1;
			}
			public bool MoveNext() 
			{
				nIndex++;
				return(nIndex < parent.OnlineResourceCount );
			}
			public OnlineResourceType  Current 
			{
				get 
				{
					return(parent.GetOnlineResourceAt(nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(Current);
				}
			}
    	}

        #endregion // OnlineResource collection

        private void SetCollectionParents()
        {
            MyOnlineResources.Parent = this; 
	}
}
}
