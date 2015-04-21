//
// StyleType.cs.cs
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
	public class StyleType : Altova.Xml.Node
	{
		#region Forward constructors
		public StyleType() : base() { SetCollectionParents(); }
		public StyleType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public StyleType(XmlNode node) : base(node) { SetCollectionParents(); }
		public StyleType(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

			for (int i = 0; i < DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "Name"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "Name", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "Title"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "Title", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "Abstract"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "Abstract", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "LegendURL"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "LegendURL", i);
				InternalAdjustPrefix(DOMNode, true);
				new LegendURLType(DOMNode).AdjustPrefix();
			}

			for (int i = 0; i < DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "StyleSheetURL"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "StyleSheetURL", i);
				InternalAdjustPrefix(DOMNode, true);
				new StyleSheetURLType(DOMNode).AdjustPrefix();
			}

			for (int i = 0; i < DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "StyleURL"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "StyleURL", i);
				InternalAdjustPrefix(DOMNode, true);
				new StyleURLType(DOMNode).AdjustPrefix();
			}
		}


		#region Name accessor methods
		public int GetNameMinCount()
		{
			return 1;
		}

		public int NameMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetNameMaxCount()
		{
			return 1;
		}

		public int NameMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetNameCount()
		{
			return DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "Name");
		}

		public int NameCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "Name");
			}
		}

		public bool HasName()
		{
			return HasDomChild(NodeType.Element, "http://www.opengis.net/wms", "Name");
		}

		public SchemaString GetNameAt(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "Name", index)));
		}

		public SchemaString GetName()
		{
			return GetNameAt(0);
		}

		public SchemaString Name
		{
			get
			{
				return GetNameAt(0);
			}
		}

		public void RemoveNameAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "Name", index);
		}

		public void RemoveName()
		{
			while (HasName())
				RemoveNameAt(0);
		}

		public void AddName(SchemaString newValue)
		{
			AppendDomChild(NodeType.Element, "http://www.opengis.net/wms", "Name", newValue.ToString());
		}

		public void InsertNameAt(SchemaString newValue, int index)
		{
			InsertDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "Name", index, newValue.ToString());
		}

		public void ReplaceNameAt(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "Name", index, newValue.ToString());
		}
		#endregion // Name accessor methods

		#region Name collection
        public NameCollection	MyNames = new NameCollection( );

        public class NameCollection: IEnumerable
        {
            StyleType parent;
            public StyleType Parent
			{
				set
				{
					parent = value;
				}
			}
			public NameEnumerator GetEnumerator() 
			{
				return new NameEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class NameEnumerator: IEnumerator 
        {
			int nIndex;
			StyleType parent;
			public NameEnumerator(StyleType par) 
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
				return(nIndex < parent.NameCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(parent.GetNameAt(nIndex));
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

        #endregion // Name collection

		#region Title accessor methods
		public int GetTitleMinCount()
		{
			return 1;
		}

		public int TitleMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetTitleMaxCount()
		{
			return 1;
		}

		public int TitleMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetTitleCount()
		{
			return DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "Title");
		}

		public int TitleCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "Title");
			}
		}

		public bool HasTitle()
		{
			return HasDomChild(NodeType.Element, "http://www.opengis.net/wms", "Title");
		}

		public SchemaString GetTitleAt(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "Title", index)));
		}

		public SchemaString GetTitle()
		{
			return GetTitleAt(0);
		}

		public SchemaString Title
		{
			get
			{
				return GetTitleAt(0);
			}
		}

		public void RemoveTitleAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "Title", index);
		}

		public void RemoveTitle()
		{
			while (HasTitle())
				RemoveTitleAt(0);
		}

		public void AddTitle(SchemaString newValue)
		{
			AppendDomChild(NodeType.Element, "http://www.opengis.net/wms", "Title", newValue.ToString());
		}

		public void InsertTitleAt(SchemaString newValue, int index)
		{
			InsertDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "Title", index, newValue.ToString());
		}

		public void ReplaceTitleAt(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "Title", index, newValue.ToString());
		}
		#endregion // Title accessor methods

		#region Title collection
        public TitleCollection	MyTitles = new TitleCollection( );

        public class TitleCollection: IEnumerable
        {
            StyleType parent;
            public StyleType Parent
			{
				set
				{
					parent = value;
				}
			}
			public TitleEnumerator GetEnumerator() 
			{
				return new TitleEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class TitleEnumerator: IEnumerator 
        {
			int nIndex;
			StyleType parent;
			public TitleEnumerator(StyleType par) 
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
				return(nIndex < parent.TitleCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(parent.GetTitleAt(nIndex));
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

        #endregion // Title collection

		#region Abstract2 accessor methods
		public int GetAbstract2MinCount()
		{
			return 0;
		}

		public int Abstract2MinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetAbstract2MaxCount()
		{
			return 1;
		}

		public int Abstract2MaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetAbstract2Count()
		{
			return DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "Abstract");
		}

		public int Abstract2Count
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "Abstract");
			}
		}

		public bool HasAbstract2()
		{
			return HasDomChild(NodeType.Element, "http://www.opengis.net/wms", "Abstract");
		}

		public SchemaString GetAbstract2At(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "Abstract", index)));
		}

		public SchemaString GetAbstract2()
		{
			return GetAbstract2At(0);
		}

		public SchemaString Abstract2
		{
			get
			{
				return GetAbstract2At(0);
			}
		}

		public void RemoveAbstract2At(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "Abstract", index);
		}

		public void RemoveAbstract2()
		{
			while (HasAbstract2())
				RemoveAbstract2At(0);
		}

		public void AddAbstract2(SchemaString newValue)
		{
			AppendDomChild(NodeType.Element, "http://www.opengis.net/wms", "Abstract", newValue.ToString());
		}

		public void InsertAbstract2At(SchemaString newValue, int index)
		{
			InsertDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "Abstract", index, newValue.ToString());
		}

		public void ReplaceAbstract2At(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "Abstract", index, newValue.ToString());
		}
		#endregion // Abstract2 accessor methods

		#region Abstract2 collection
        public Abstract2Collection	MyAbstract2s = new Abstract2Collection( );

        public class Abstract2Collection: IEnumerable
        {
            StyleType parent;
            public StyleType Parent
			{
				set
				{
					parent = value;
				}
			}
			public Abstract2Enumerator GetEnumerator() 
			{
				return new Abstract2Enumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class Abstract2Enumerator: IEnumerator 
        {
			int nIndex;
			StyleType parent;
			public Abstract2Enumerator(StyleType par) 
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
				return(nIndex < parent.Abstract2Count );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(parent.GetAbstract2At(nIndex));
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

        #endregion // Abstract2 collection

		#region LegendURL accessor methods
		public int GetLegendURLMinCount()
		{
			return 0;
		}

		public int LegendURLMinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetLegendURLMaxCount()
		{
			return Int32.MaxValue;
		}

		public int LegendURLMaxCount
		{
			get
			{
				return Int32.MaxValue;
			}
		}

		public int GetLegendURLCount()
		{
			return DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "LegendURL");
		}

		public int LegendURLCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "LegendURL");
			}
		}

		public bool HasLegendURL()
		{
			return HasDomChild(NodeType.Element, "http://www.opengis.net/wms", "LegendURL");
		}

		public LegendURLType GetLegendURLAt(int index)
		{
			return new LegendURLType(GetDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "LegendURL", index));
		}

		public LegendURLType GetLegendURL()
		{
			return GetLegendURLAt(0);
		}

		public LegendURLType LegendURL
		{
			get
			{
				return GetLegendURLAt(0);
			}
		}

		public void RemoveLegendURLAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "LegendURL", index);
		}

		public void RemoveLegendURL()
		{
			while (HasLegendURL())
				RemoveLegendURLAt(0);
		}

		public void AddLegendURL(LegendURLType newValue)
		{
			AppendDomElement("http://www.opengis.net/wms", "LegendURL", newValue);
		}

		public void InsertLegendURLAt(LegendURLType newValue, int index)
		{
			InsertDomElementAt("http://www.opengis.net/wms", "LegendURL", index, newValue);
		}

		public void ReplaceLegendURLAt(LegendURLType newValue, int index)
		{
			ReplaceDomElementAt("http://www.opengis.net/wms", "LegendURL", index, newValue);
		}
		#endregion // LegendURL accessor methods

		#region LegendURL collection
        public LegendURLCollection	MyLegendURLs = new LegendURLCollection( );

        public class LegendURLCollection: IEnumerable
        {
            StyleType parent;
            public StyleType Parent
			{
				set
				{
					parent = value;
				}
			}
			public LegendURLEnumerator GetEnumerator() 
			{
				return new LegendURLEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class LegendURLEnumerator: IEnumerator 
        {
			int nIndex;
			StyleType parent;
			public LegendURLEnumerator(StyleType par) 
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
				return(nIndex < parent.LegendURLCount );
			}
			public LegendURLType  Current 
			{
				get 
				{
					return(parent.GetLegendURLAt(nIndex));
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

        #endregion // LegendURL collection

		#region StyleSheetURL accessor methods
		public int GetStyleSheetURLMinCount()
		{
			return 0;
		}

		public int StyleSheetURLMinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetStyleSheetURLMaxCount()
		{
			return 1;
		}

		public int StyleSheetURLMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetStyleSheetURLCount()
		{
			return DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "StyleSheetURL");
		}

		public int StyleSheetURLCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "StyleSheetURL");
			}
		}

		public bool HasStyleSheetURL()
		{
			return HasDomChild(NodeType.Element, "http://www.opengis.net/wms", "StyleSheetURL");
		}

		public StyleSheetURLType GetStyleSheetURLAt(int index)
		{
			return new StyleSheetURLType(GetDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "StyleSheetURL", index));
		}

		public StyleSheetURLType GetStyleSheetURL()
		{
			return GetStyleSheetURLAt(0);
		}

		public StyleSheetURLType StyleSheetURL
		{
			get
			{
				return GetStyleSheetURLAt(0);
			}
		}

		public void RemoveStyleSheetURLAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "StyleSheetURL", index);
		}

		public void RemoveStyleSheetURL()
		{
			while (HasStyleSheetURL())
				RemoveStyleSheetURLAt(0);
		}

		public void AddStyleSheetURL(StyleSheetURLType newValue)
		{
			AppendDomElement("http://www.opengis.net/wms", "StyleSheetURL", newValue);
		}

		public void InsertStyleSheetURLAt(StyleSheetURLType newValue, int index)
		{
			InsertDomElementAt("http://www.opengis.net/wms", "StyleSheetURL", index, newValue);
		}

		public void ReplaceStyleSheetURLAt(StyleSheetURLType newValue, int index)
		{
			ReplaceDomElementAt("http://www.opengis.net/wms", "StyleSheetURL", index, newValue);
		}
		#endregion // StyleSheetURL accessor methods

		#region StyleSheetURL collection
        public StyleSheetURLCollection	MyStyleSheetURLs = new StyleSheetURLCollection( );

        public class StyleSheetURLCollection: IEnumerable
        {
            StyleType parent;
            public StyleType Parent
			{
				set
				{
					parent = value;
				}
			}
			public StyleSheetURLEnumerator GetEnumerator() 
			{
				return new StyleSheetURLEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class StyleSheetURLEnumerator: IEnumerator 
        {
			int nIndex;
			StyleType parent;
			public StyleSheetURLEnumerator(StyleType par) 
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
				return(nIndex < parent.StyleSheetURLCount );
			}
			public StyleSheetURLType  Current 
			{
				get 
				{
					return(parent.GetStyleSheetURLAt(nIndex));
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

        #endregion // StyleSheetURL collection

		#region StyleURL accessor methods
		public int GetStyleURLMinCount()
		{
			return 0;
		}

		public int StyleURLMinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetStyleURLMaxCount()
		{
			return 1;
		}

		public int StyleURLMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetStyleURLCount()
		{
			return DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "StyleURL");
		}

		public int StyleURLCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "StyleURL");
			}
		}

		public bool HasStyleURL()
		{
			return HasDomChild(NodeType.Element, "http://www.opengis.net/wms", "StyleURL");
		}

		public StyleURLType GetStyleURLAt(int index)
		{
			return new StyleURLType(GetDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "StyleURL", index));
		}

		public StyleURLType GetStyleURL()
		{
			return GetStyleURLAt(0);
		}

		public StyleURLType StyleURL
		{
			get
			{
				return GetStyleURLAt(0);
			}
		}

		public void RemoveStyleURLAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "StyleURL", index);
		}

		public void RemoveStyleURL()
		{
			while (HasStyleURL())
				RemoveStyleURLAt(0);
		}

		public void AddStyleURL(StyleURLType newValue)
		{
			AppendDomElement("http://www.opengis.net/wms", "StyleURL", newValue);
		}

		public void InsertStyleURLAt(StyleURLType newValue, int index)
		{
			InsertDomElementAt("http://www.opengis.net/wms", "StyleURL", index, newValue);
		}

		public void ReplaceStyleURLAt(StyleURLType newValue, int index)
		{
			ReplaceDomElementAt("http://www.opengis.net/wms", "StyleURL", index, newValue);
		}
		#endregion // StyleURL accessor methods

		#region StyleURL collection
        public StyleURLCollection	MyStyleURLs = new StyleURLCollection( );

        public class StyleURLCollection: IEnumerable
        {
            StyleType parent;
            public StyleType Parent
			{
				set
				{
					parent = value;
				}
			}
			public StyleURLEnumerator GetEnumerator() 
			{
				return new StyleURLEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class StyleURLEnumerator: IEnumerator 
        {
			int nIndex;
			StyleType parent;
			public StyleURLEnumerator(StyleType par) 
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
				return(nIndex < parent.StyleURLCount );
			}
			public StyleURLType  Current 
			{
				get 
				{
					return(parent.GetStyleURLAt(nIndex));
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

        #endregion // StyleURL collection

        private void SetCollectionParents()
        {
            MyNames.Parent = this; 
            MyTitles.Parent = this; 
            MyAbstract2s.Parent = this; 
            MyLegendURLs.Parent = this; 
            MyStyleSheetURLs.Parent = this; 
            MyStyleURLs.Parent = this; 
	}
}
}
