using System.Collections.Generic;
using System.Reflection;
using MoonSharp.Interpreter.Interop.BasicDescriptors;

namespace MoonSharp.Interpreter.Interop
{
	public class GenericMethodMemberDescriptor : FunctionMemberDescriptorBase, IWireableDescriptor
	{
		private bool m_IsAction;

		private bool m_IsArrayCtor;

		public MethodBase MethodInfo { get; private set; }

		public InteropAccessMode AccessMode { get; private set; }

		public bool IsConstructor { get; private set; }

		public GenericMethodMemberDescriptor(MethodBase methodBase, InteropAccessMode accessMode = InteropAccessMode.Default)
		{
		}

		public static GenericMethodMemberDescriptor TryCreateIfVisible(MethodBase methodBase, InteropAccessMode accessMode, bool forceVisibility = false)
		{
			return null;
		}

		public static bool CheckMethodIsCompatible(MethodBase methodBase, bool throwException)
		{
			return false;
		}

		public override DynValue Execute(Script script, object obj, ScriptExecutionContext context, CallbackArguments args)
		{
			return null;
		}

		protected override object[] BuildArgumentList(Script script, object obj, ScriptExecutionContext context, CallbackArguments args, out List<int> outParams)
		{
			outParams = null;
			return null;
		}

		public void PrepareForWiring(Table t)
		{
		}
	}
}
