namespace UnityEngine.UIElements;

[Token(Token = "0x20004BF")]
public class UxmlStringAttributeDescription : TypedUxmlAttributeDescription<String>
{
	[CompilerGenerated]
	[Token(Token = "0x20004C0")]
	private sealed class <>c
	{
		[Token(Token = "0x4000FF6")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000FF7")]
		public static Func<String, String, String> <>9__3_0; //Field offset: 0x8
		[Token(Token = "0x4000FF8")]
		public static Func<String, String, String> <>9__4_0; //Field offset: 0x10

		[Address(RVA = "0x1B447B0", Offset = "0x1B439B0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60023D1")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60023D2")]
		public <>c() { }

		[Address(RVA = "0x2DAD20", Offset = "0x2D9F20", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60023D3")]
		internal string <GetValueFromBag>b__3_0(string s, string t) { }

		[Address(RVA = "0x2DAD20", Offset = "0x2D9F20", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60023D4")]
		internal string <TryGetValueFromBag>b__4_0(string s, string t) { }

	}


	[Address(RVA = "0x1B530F0", Offset = "0x1B522F0", Length = "0xA5")]
	[CallerCount(Count = 45)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TypedUxmlAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60023CE")]
	public UxmlStringAttributeDescription() { }

	[Address(RVA = "0x1B52DE0", Offset = "0x1B51FE0", Length = "0x178")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UxmlAttributeDescription), Member = "GetValueFromBag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), "System.Func`3<String, T, T>", "T"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60023CF")]
	public virtual string GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	[Address(RVA = "0x1B52F60", Offset = "0x1B52160", Length = "0x183")]
	[CalledBy(Type = typeof(EnumFieldHelpers), Member = "ExtractValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), typeof(Type&), typeof(Enum&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UxmlAttributeDescription), Member = "TryGetValueFromBag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), typeof(System.Func`3<System.String, System.Object, System.Object>), typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60023D0")]
	public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref string value) { }

}

