using System;

namespace CloseEnough.Tests
{
	public class Muffin
	{
		public Muffin ()
		{
		}

		public bool IsConsumed { get; set; }
		public void Consume()
		{
			IsConsumed = true;
		}

		public string Flavour{ get; set; }

	}
}

