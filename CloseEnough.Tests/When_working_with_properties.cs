using System;
using NUnit.Framework;

namespace CloseEnough.Tests
{
	[TestFixture]
	public class When_working_with_properties
	{
		//[Test]
		public void Matching_name_is_set ()
		{
			Muffin muffin = new Muffin();
			muffin.CE().Flavour = "orange";
			Assert.AreEqual(muffin.Flavour, "orange");
		}

		//[Test]
		public void Matching_name_is_retrieved()
		{
			Muffin muffin = new Muffin();
			muffin.Flavour = "orange";
			Assert.AreEqual(muffin.CE ().Flavour, "orange");
		}
	}
}

