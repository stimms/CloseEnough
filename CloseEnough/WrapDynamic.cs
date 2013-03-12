using System;

namespace CloseEnough
{
	public static class WrapDynamic
	{
		public static dynamic CE(this object toWrap)
		{
			return new WrappedObject(toWrap);
		}
	}
}

