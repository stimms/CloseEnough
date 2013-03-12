using CloseEnough.Tests;
using System;
using Xunit;
using CloseEnough;

namespace CloseEnough.Tests
{
	public class When_working_with_properties
	{
		//[Fact]
		public void Matching_name_is_set ()
		{
			Muffin muffin = new Muffin();
			muffin.CE().Flavour = "orange";
			Assert.Equal(muffin.Flavour, "orange");
		}

		//[Fact]
		public void Matching_name_is_retrieved()
		{
			Muffin muffin = new Muffin();
			muffin.Flavour = "orange";
			Assert.Equal(muffin.CE ().Flavour, "orange");
		}
	}
}

