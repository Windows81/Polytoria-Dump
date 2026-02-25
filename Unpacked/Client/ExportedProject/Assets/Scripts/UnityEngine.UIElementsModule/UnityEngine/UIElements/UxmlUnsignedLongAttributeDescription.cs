namespace UnityEngine.UIElements;

[Token(Token = "0x20004C9")]
public class UxmlUnsignedLongAttributeDescription : TypedUxmlAttributeDescription<UInt64>
{
	[CompilerGenerated]
	[Token(Token = "0x20004CA")]
	private sealed class <>c
	{
		[Token(Token = "0x4001002")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4001003")]
		public static Func<String, UInt64, UInt64> <>9__3_0; //Field offset: 0x8

		[Address(RVA = "0x1B44890", Offset = "0x1B43A90", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60023F2")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60023F3")]
		public <>c() { }

		[Address(RVA = "0x1B43C40", Offset = "0x1B42E40", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ulong), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt64&)}, ReturnType = typeof(bool))]
		[Token(Token = "0x60023F4")]
		internal ulong <GetValueFromBag>b__3_0(string s, ulong l) { }

	}


	[Address(RVA = "0x1B54150", Offset = "0x1B53350", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TypedUxmlAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60023EF")]
	public UxmlUnsignedLongAttributeDescription() { }

	[Address(RVA = "0x1B53F90", Offset = "0x1B53190", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ulong), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt64&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60023F1")]
	private static ulong ConvertValueToUlong(string v, ulong defaultValue) { }

	[Address(RVA = "0x1B53FD0", Offset = "0x1B531D0", Length = "0x178")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UxmlAttributeDescription), Member = "GetValueFromBag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), "System.Func`3<String, T, T>", "T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60023F0")]
	public virtual ulong GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

}

