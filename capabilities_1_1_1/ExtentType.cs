//
// ExtentType.cs.cs
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
	public class ExtentType : Altova.Xml.Node
	{
		#region Forward constructors
		public ExtentType() : base() { SetCollectionParents(); }
		public ExtentType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public ExtentType(XmlNode node) : base(node) { SetCollectionParents(); }
		public ExtentType(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

			for (int i = 0; i < DomChildCount(NodeType.Attribute, "", "name"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Attribute, "", "name", i);
				InternalAdjustPrefix(DOMNode, false);
			}

			for (int i = 0; i < DomChildCount(NodeType.Attribute, "", "default"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Attribute, "", "default", i);
				InternalAdjustPrefix(DOMNode, false);
			}

			for (int i = 0; i < DomChildCount(NodeType.Attribute, "", "nearestValue"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Attribute, "", "nearestValue", i);
				InternalAdjustPrefix(DOMNode, false);
			}
		}


		#region name accessor methods
		public int GetnameMinCount()
		{
			return 1;
		}

		public int nameMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetnameMaxCount()
		{
			return 1;
		}

		public int nameMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetnameCount()
		{
			return DomChildCount(NodeType.Attribute, "", "name");
		}

		public int nameCount
		{
			get
			{
				return DomChildCount(NodeType.Attribute, "", "name");
			}
		}

		public bool Hasname()
		{
			return HasDomChild(NodeType.Attribute, "", "name");
		}

		public SchemaString GetnameAt(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Attribute, "", "name", index)));
		}

		public SchemaString Getname()
		{
			return GetnameAt(0);
		}

		public SchemaString name
		{
			get
			{
				return GetnameAt(0);
			}
		}

		public void RemovenameAt(int index)
		{
			RemoveDomChildAt(NodeType.Attribute, "", "name", index);
		}

		public void Removename()
		{
			while (Hasname())
				RemovenameAt(0);
		}

		public void Addname(SchemaString newValue)
		{
			AppendDomChild(NodeType.Attribute, "", "name", newValue.ToString());
		}

		public void InsertnameAt(SchemaString newValue, int index)
		{
			InsertDomChildAt(NodeType.Attribute, "", "name", index, newValue.ToString());
		}

		public void ReplacenameAt(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Attribute, "", "name", index, newValue.ToString());
		}
		#endregion // name accessor methods

		#region name collection
        public nameCollection	Mynames = new nameCollection( );

        public class nameCollection: IEnumerable
        {
            ExtentType parent;
            public ExtentType Parent
			{
				set
				{
					parent = value;
				}
			}
			public nameEnumerator GetEnumerator() 
			{
				return new nameEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class nameEnumerator: IEnumerator 
        {
			int nIndex;
			ExtentType parent;
			public nameEnumerator(ExtentType par) 
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
				return(nIndex < parent.nameCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(parent.GetnameAt(nIndex));
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

        #endregion // name collection

		#region default2 accessor methods
		public int Getdefault2MinCount()
		{
			return 0;
		}

		public int default2MinCount
		{
			get
			{
				return 0;
			}
		}

		public int Getdefault2MaxCount()
		{
			return 1;
		}

		public int default2MaxCount
		{
			get
			{
				return 1;
			}
		}

		public int Getdefault2Count()
		{
			return DomChildCount(NodeType.Attribute, "", "default");
		}

		public int default2Count
		{
			get
			{
				return DomChildCount(NodeType.Attribute, "", "default");
			}
		}

		public bool Hasdefault2()
		{
			return HasDomChild(NodeType.Attribute, "", "default");
		}

		public SchemaString Getdefault2At(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Attribute, "", "default", index)));
		}

		public SchemaString Getdefault2()
		{
			return Getdefault2At(0);
		}

		public SchemaString default2
		{
			get
			{
				return Getdefault2At(0);
			}
		}

		public void Removedefault2At(int index)
		{
			RemoveDomChildAt(NodeType.Attribute, "", "default", index);
		}

		public void Removedefault2()
		{
			while (Hasdefault2())
				Removedefault2At(0);
		}

		public void Adddefault2(SchemaString newValue)
		{
			AppendDomChild(NodeType.Attribute, "", "default", newValue.ToString());
		}

		public void Insertdefault2At(SchemaString newValue, int index)
		{
			InsertDomChildAt(NodeType.Attribute, "", "default", index, newValue.ToString());
		}

		public void Replacedefault2At(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Attribute, "", "default", index, newValue.ToString());
		}
		#endregion // default2 accessor methods

		#region default2 collection
        public default2Collection	Mydefault2s = new default2Collection( );

        public class default2Collection: IEnumerable
        {
            ExtentType parent;
            public ExtentType Parent
			{
				set
				{
					parent = value;
				}
			}
			public default2Enumerator GetEnumerator() 
			{
				return new default2Enumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class default2Enumerator: IEnumerator 
        {
			int nIndex;
			ExtentType parent;
			public default2Enumerator(ExtentType par) 
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
				return(nIndex < parent.default2Count );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(parent.Getdefault2At(nIndex));
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

        #endregion // default2 collection

		#region nearestValue accessor methods
		public int GetnearestValueMinCount()
		{
			return 0;
		}

		public int nearestValueMinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetnearestValueMaxCount()
		{
			return 1;
		}

		public int nearestValueMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetnearestValueCount()
		{
			return DomChildCount(NodeType.Attribute, "", "nearestValue");
		}

		public int nearestValueCount
		{
			get
			{
				return DomChildCount(NodeType.Attribute, "", "nearestValue");
			}
		}

		public bool HasnearestValue()
		{
			return HasDomChild(NodeType.Attribute, "", "nearestValue");
		}

		public SchemaString GetnearestValueAt(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Attribute, "", "nearestValue", index)));
		}

		public SchemaString GetnearestValue()
		{
			return GetnearestValueAt(0);
		}

		public SchemaString nearestValue
		{
			get
			{
				return GetnearestValueAt(0);
			}
		}

		public void RemovenearestValueAt(int index)
		{
			RemoveDomChildAt(NodeType.Attribute, "", "nearestValue", index);
		}

		public void RemovenearestValue()
		{
			while (HasnearestValue())
				RemovenearestValueAt(0);
		}

		public void AddnearestValue(SchemaString newValue)
		{
			AppendDomChild(NodeType.Attribute, "", "nearestValue", newValue.ToString());
		}

		public void InsertnearestValueAt(SchemaString newValue, int index)
		{
			InsertDomChildAt(NodeType.Attribute, "", "nearestValue", index, newValue.ToString());
		}

		public void ReplacenearestValueAt(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Attribute, "", "nearestValue", index, newValue.ToString());
		}
		#endregion // nearestValue accessor methods

		#region nearestValue collection
        public nearestValueCollection	MynearestValues = new nearestValueCollection( );

        public class nearestValueCollection: IEnumerable
        {
            ExtentType parent;
            public ExtentType Parent
			{
				set
				{
					parent = value;
				}
			}
			public nearestValueEnumerator GetEnumerator() 
			{
				return new nearestValueEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class nearestValueEnumerator: IEnumerator 
        {
			int nIndex;
			ExtentType parent;
			public nearestValueEnumerator(ExtentType par) 
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
				return(nIndex < parent.nearestValueCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(parent.GetnearestValueAt(nIndex));
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

        #endregion // nearestValue collection

        private void SetCollectionParents()
        {
            Mynames.Parent = this; 
            Mydefault2s.Parent = this; 
            MynearestValues.Parent = this; 
	}
}
}
