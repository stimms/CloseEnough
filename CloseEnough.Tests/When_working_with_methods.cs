using System;
using NUnit.Framework;

namespace CloseEnough.Tests
{
	[TestFixture]
	public class When_working_with_methods
	{
		[Test]
		public void Method_is_invoked ()
		{
			Muffin muffin = new Muffin();
			muffin.IsConsumed = false;
			muffin.CE ().Consume();
			Assert.IsTrue(muffin.IsConsumed);
		}
	}
}

