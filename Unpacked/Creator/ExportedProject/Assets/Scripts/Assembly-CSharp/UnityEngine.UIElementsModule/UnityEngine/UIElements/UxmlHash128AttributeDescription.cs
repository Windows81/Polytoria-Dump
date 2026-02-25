namespace UnityEngine.UIElements;

[Token(Token = "0x20004D2")]
public class UxmlHash128AttributeDescription : TypedUxmlAttributeDescription<Hash128>
{
	[CompilerGenerated]
	[Token(Token = "0x20004D3")]
	private sealed class <>c
	{
		[Token(Token = "0x400100B")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400100C")]
		public static Func<String, Hash128, Hash128> <>9__3_0; //Field offset: 0x8

		[Address(RVA = "0x1B44660", Offset = "0x1B43860", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002411")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002412")]
		public <>c() { }

		[Address(RVA = "0x1B43CC0", Offset = "0x1B42EC0", Length = "0x28")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Hash128), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Hash128))]
		[Token(Token = "0x6002413")]
		internal Hash128 <GetValueFromBag>b__3_0(string s, Hash128 i) { }

	}


	[Address(RVA = "0x1B514D0", Offset = "0x1B506D0", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TypedUxmlAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600240F")]
	public UxmlHash128AttributeDescription() { }

	[Address(RVA = "0x1B51320", Offset = "0x1B50520", Length = "0x1A8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Func`3<System.Object, UnityEngine.Hash128, UnityEngine.Hash128>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UxmlAttributeDescription), Member = "GetValueFromBag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), typeof(System.Func`3<System.String, UnityEngine.Hash128, UnityEngine.Hash128>), typeof(Hash128)}, ReturnType = typeof(Hash128))]
	[Token(Token = "0x6002410")]
	public virtual Hash128 GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

}

