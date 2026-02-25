namespace UnityEngine.UIElements;

[Token(Token = "0x20004CB")]
public class UxmlLongAttributeDescription : TypedUxmlAttributeDescription<Int64>
{
	[CompilerGenerated]
	[Token(Token = "0x20004CC")]
	private sealed class <>c
	{
		[Token(Token = "0x4001004")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4001005")]
		public static Func<String, Int64, Int64> <>9__3_0; //Field offset: 0x8

		[Address(RVA = "0x1B44A50", Offset = "0x1B43C50", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60023F8")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60023F9")]
		public <>c() { }

		[Address(RVA = "0x1B43CF0", Offset = "0x1B42EF0", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(long), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int64&)}, ReturnType = typeof(bool))]
		[Token(Token = "0x60023FA")]
		internal long <GetValueFromBag>b__3_0(string s, long l) { }

	}


	[Address(RVA = "0x1B51D70", Offset = "0x1B50F70", Length = "0x8E")]
	[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TypedUxmlAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60023F5")]
	public UxmlLongAttributeDescription() { }

	[Address(RVA = "0x1B51BB0", Offset = "0x1B50DB0", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(long), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int64&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60023F7")]
	private static long ConvertValueToLong(string v, long defaultValue) { }

	[Address(RVA = "0x1B51BF0", Offset = "0x1B50DF0", Length = "0x178")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UxmlAttributeDescription), Member = "GetValueFromBag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), "System.Func`3<String, T, T>", "T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60023F6")]
	public virtual long GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

}

