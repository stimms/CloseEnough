using System;
using System.Linq;
using System.Dynamic;

namespace CloseEnough
{
	public class WrappedObject: DynamicObject
	{
		private object _wrapped;
		private Type _wrappedType;
		public WrappedObject (object toWrap)
		{
			_wrapped = toWrap;
			_wrappedType = toWrap.GetType();
		}

		public override bool TrySetMember (SetMemberBinder binder, object value)
		{	
			if (_wrappedType.GetMembers ().Any (x => x.Name == binder.Name)) {
				var member = _wrappedType.GetMembers ().Where (x => x.Name == "set_" + binder.Name).First ();
				_wrapped.GetType().InvokeMember(member.Name, System.Reflection.BindingFlags.InvokeMethod, null, _wrapped,new object[] { value});
			}
			return true;
		}
		
		public override bool TryGetMember (GetMemberBinder binder, 
		                                  out object result)
		{
			if (_wrappedType.GetMembers ().Any (x => x.Name == binder.Name)) {
				var member = _wrappedType.GetMembers ().Where (x => x.Name == binder.Name).First ();
				if(member.MemberType == System.Reflection.MemberTypes.Property)
				{
					result = _wrappedType.InvokeMember(member.Name, System.Reflection.BindingFlags.GetProperty, null, _wrapped, null);
					return true;
				}
				result = null;
				return false;
			} else {
				result = null;
				return false;
			}

		}
	}
}

