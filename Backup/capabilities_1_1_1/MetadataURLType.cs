//
// MetadataURLType.cs.cs
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

namespace capabilities_1_1_1
{
	public class MetadataURLType : Altova.Xml.Node
	{
		#region Forward constructors
		public MetadataURLType() : base() { SetCollectionParents(); }
		public MetadataURLType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public MetadataURLType(XmlNode node) : base(node) { SetCollectionParents(); }
		public MetadataURLType(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

			for (int i = 0; i < DomChildCount(NodeType.Attribute, "", "type"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Attribute, "", "type", i);
				InternalAdjustPrefix(DOMNode, false);
			}

			for (int i = 0; i < DomChildCount(NodeType.Element, "", "Format"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "Format", i);
				InternalAdjustPrefix(DOMNode, false);
			}

			for (int i = 0; i < DomChildCount(NodeType.Element, "", "OnlineResource"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "OnlineResource", i);
				InternalAdjustPrefix(DOMNode, false);
				new OnlineResourceType(DOMNode).AdjustPrefix();
			}
		}


		#region type2 accessor methods
		public int Gettype2MinCount()
		{
			return 1;
		}

		public int type2MinCount
		{
			get
			{
				return 1;
			}
		}

		public int Gettype2MaxCount()
		{
			return 1;
		}

		public int type2MaxCount
		{
			get
			{
				return 1;
			}
		}

		public int Gettype2Count()
		{
			return DomChildCount(NodeType.Attribute, "", "type");
		}

		public int type2Count
		{
			get
			{
				return DomChildCount(NodeType.Attribute, "", "type");
			}
		}

		public bool Hastype2()
		{
			return HasDomChild(NodeType.Attribute, "", "type");
		}

		public SchemaString Gettype2At(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Attribute, "", "type", index)));
		}

		public SchemaString Gettype2()
		{
			return Gettype2At(0);
		}

		public SchemaString type2
		{
			get
			{
				return Gettype2At(0);
			}
		}

		public void Removetype2At(int index)
		{
			RemoveDomChildAt(NodeType.Attribute, "", "type", index);
		}

		public void Removetype2()
		{
			while (Hastype2())
				Removetype2At(0);
		}

		public void Addtype2(SchemaString newValue)
		{
			AppendDomChild(NodeType.Attribute, "", "type", newValue.ToString());
		}

		public void Inserttype2At(SchemaString newValue, int index)
		{
			InsertDomChildAt(NodeType.Attribute, "", "type", index, newValue.ToString());
		}

		public void Replacetype2At(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Attribute, "", "type", index, newValue.ToString());
		}
		#endregion // type2 accessor methods

		#region type2 collection
        public type2Collection	Mytype2s = new type2Collection( );

        public class type2Collection: IEnumerable
        {
            MetadataURLType parent;
            public MetadataURLType Parent
			{
				set
				{
					parent = value;
				}
			}
			public type2Enumerator GetEnumerator() 
			{
				return new type2Enumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class type2Enumerator: IEnumerator 
        {
			int nIndex;
			MetadataURLType parent;
			public type2Enumerator(MetadataURLType par) 
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
				return(nIndex < parent.type2Count );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(parent.Gettype2At(nIndex));
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

        #endregion // type2 collection

		#region Format accessor methods
		public int GetFormatMinCount()
		{
			return 1;
		}

		public int FormatMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetFormatMaxCount()
		{
			return 1;
		}

		public int FormatMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetFormatCount()
		{
			return DomChildCount(NodeType.Element, "", "Format");
		}

		public int FormatCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "Format");
			}
		}

		public bool HasFormat()
		{
			return HasDomChild(NodeType.Element, "", "Format");
		}

		public SchemaString GetFormatAt(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "Format", index)));
		}

		public SchemaString GetFormat()
		{
			return GetFormatAt(0);
		}

		public SchemaString Format
		{
			get
			{
				return GetFormatAt(0);
			}
		}

		public void RemoveFormatAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "Format", index);
		}

		public void RemoveFormat()
		{
			while (HasFormat())
				RemoveFormatAt(0);
		}

		public void AddFormat(SchemaString newValue)
		{
			AppendDomChild(NodeType.Element, "", "Format", newValue.ToString());
		}

		public void InsertFormatAt(SchemaString newValue, int index)
		{
			InsertDomChildAt(NodeType.Element, "", "Format", index, newValue.ToString());
		}

		public void ReplaceFormatAt(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "Format", index, newValue.ToString());
		}
		#endregion // Format accessor methods

		#region Format collection
        public FormatCollection	MyFormats = new FormatCollection( );

        public class FormatCollection: IEnumerable
        {
            MetadataURLType parent;
            public MetadataURLType Parent
			{
				set
				{
					parent = value;
				}
			}
			public FormatEnumerator GetEnumerator() 
			{
				return new FormatEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class FormatEnumerator: IEnumerator 
        {
			int nIndex;
			MetadataURLType parent;
			public FormatEnumerator(MetadataURLType par) 
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
				return(nIndex < parent.FormatCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(parent.GetFormatAt(nIndex));
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

        #endregion // Format collection

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
			return DomChildCount(NodeType.Element, "", "OnlineResource");
		}

		public int OnlineResourceCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "OnlineResource");
			}
		}

		public bool HasOnlineResource()
		{
			return HasDomChild(NodeType.Element, "", "OnlineResource");
		}

		public OnlineResourceType GetOnlineResourceAt(int index)
		{
			return new OnlineResourceType(GetDomChildAt(NodeType.Element, "", "OnlineResource", index));
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
			RemoveDomChildAt(NodeType.Element, "", "OnlineResource", index);
		}

		public void RemoveOnlineResource()
		{
			while (HasOnlineResource())
				RemoveOnlineResourceAt(0);
		}

		public void AddOnlineResource(OnlineResourceType newValue)
		{
			AppendDomElement("", "OnlineResource", newValue);
		}

		public void InsertOnlineResourceAt(OnlineResourceType newValue, int index)
		{
			InsertDomElementAt("", "OnlineResource", index, newValue);
		}

		public void ReplaceOnlineResourceAt(OnlineResourceType newValue, int index)
		{
			ReplaceDomElementAt("", "OnlineResource", index, newValue);
		}
		#endregion // OnlineResource accessor methods

		#region OnlineResource collection
        public OnlineResourceCollection	MyOnlineResources = new OnlineResourceCollection( );

        public class OnlineResourceCollection: IEnumerable
        {
            MetadataURLType parent;
            public MetadataURLType Parent
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
			MetadataURLType parent;
			public OnlineResourceEnumerator(MetadataURLType par) 
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
            Mytype2s.Parent = this; 
            MyFormats.Parent = this; 
            MyOnlineResources.Parent = this; 
	}
}
}
