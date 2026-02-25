namespace UnityEngine.UIElements;

[Token(Token = "0x20004C7")]
public class UxmlUnsignedIntAttributeDescription : TypedUxmlAttributeDescription<UInt32>
{
	[CompilerGenerated]
	[Token(Token = "0x20004C8")]
	private sealed class <>c
	{
		[Token(Token = "0x4001000")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4001001")]
		public static Func<String, UInt32, UInt32> <>9__3_0; //Field offset: 0x8

		[Address(RVA = "0x1B44900", Offset = "0x1B43B00", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60023EC")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60023ED")]
		public <>c() { }

		[Address(RVA = "0x1B43ED0", Offset = "0x1B430D0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(uint), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt32&)}, ReturnType = typeof(bool))]
		[Token(Token = "0x60023EE")]
		internal uint <GetValueFromBag>b__3_0(string s, uint i) { }

	}


	[Address(RVA = "0x1B53F00", Offset = "0x1B53100", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TypedUxmlAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60023E9")]
	public UxmlUnsignedIntAttributeDescription() { }

	[Address(RVA = "0x1B53D40", Offset = "0x1B52F40", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60023EB")]
	private static uint ConvertValueToUInt(string v, uint defaultValue) { }

	[Address(RVA = "0x1B53D80", Offset = "0x1B52F80", Length = "0x176")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Func`3<System.Object, System.UInt32, System.UInt32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UxmlAttributeDescription), Member = "GetValueFromBag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), "System.Func`3<String, T, T>", "T"}, ReturnType = "T")]
	[Token(Token = "0x60023EA")]
	public virtual uint GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

}

