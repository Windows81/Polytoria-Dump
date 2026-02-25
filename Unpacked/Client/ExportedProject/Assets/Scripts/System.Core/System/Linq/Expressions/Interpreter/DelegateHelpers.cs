namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000230")]
internal static class DelegateHelpers
{
	[CompilerGenerated]
	[Token(Token = "0x2000231")]
	private sealed class <>c
	{
		[Token(Token = "0x40003BC")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40003BD")]
		public static Func<Type, Boolean> <>9__1_0; //Field offset: 0x8

		[Address(RVA = "0x15EB630", Offset = "0x15EA830", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000A44")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A45")]
		public <>c() { }

		[Address(RVA = "0x15EB500", Offset = "0x15EA700", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000A46")]
		internal bool <MakeDelegate>b__1_0(Type t) { }

	}


	[Address(RVA = "0x15D1540", Offset = "0x15D0740", Length = "0x358")]
	[CalledBy(Type = typeof(LightLambda), Member = "MakeRunDelegateCtor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(System.Func`2<System.Linq.Expressions.Interpreter.LightLambda, System.Delegate>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000A43")]
	internal static Type MakeDelegate(Type[] types) { }

}

