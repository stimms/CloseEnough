using System;
using Xunit;

namespace CloseEnough.Tests
{
	public class When_working_with_methods
	{
		[Fact]
		public void Method_is_invoked ()
		{
			Muffin muffin = new Muffin();
			muffin.IsConsumed = false;
			muffin.CE ().Consume();
			Assert.True(muffin.IsConsumed);
		}
	}
}

