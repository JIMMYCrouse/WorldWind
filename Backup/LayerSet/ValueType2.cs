//
// ValueType2.cs.cs
//
// This file was generated by XMLSpy 2005 Enterprise Edition.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the XMLSpy Documentation for further details.
// http://www.altova.com/xmlspy
//


using Altova.Types;

namespace LayerSet
{

	public class ValueType2 : SchemaDecimal
	{

		public ValueType2() : base()
		{
		}

		public ValueType2(string newValue) : base(newValue)
		{
			Validate();
		}

		public ValueType2(SchemaDecimal newValue) : base(newValue)
		{
			Validate();
		}

		public void Validate()
		{

			if (CompareTo(GetMinInclusive()) < 0)
				throw new System.Exception("Out of range");

			if (CompareTo(GetMaxInclusive()) > 0)
				throw new System.Exception("Out of range");
		}
		public SchemaDecimal GetMinInclusive()
		{
			return new SchemaDecimal("-180");
		}
		public SchemaDecimal GetMaxInclusive()
		{
			return new SchemaDecimal("180");
		}
	}
}
