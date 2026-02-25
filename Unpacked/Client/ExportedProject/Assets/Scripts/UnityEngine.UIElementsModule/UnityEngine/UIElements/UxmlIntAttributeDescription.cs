namespace UnityEngine.UIElements;

[Token(Token = "0x20004C5")]
public class UxmlIntAttributeDescription : TypedUxmlAttributeDescription<Int32>
{
	[CompilerGenerated]
	[Token(Token = "0x20004C6")]
	private sealed class <>c
	{
		[Token(Token = "0x4000FFD")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000FFE")]
		public static Func<String, Int32, Int32> <>9__3_0; //Field offset: 0x8
		[Token(Token = "0x4000FFF")]
		public static Func<String, Int32, Int32> <>9__4_0; //Field offset: 0x10

		[Address(RVA = "0x1B449E0", Offset = "0x1B43BE0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60023E5")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60023E6")]
		public <>c() { }

		[Address(RVA = "0x1B43C80", Offset = "0x1B42E80", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x60023E7")]
		internal int <GetValueFromBag>b__3_0(string s, int i) { }

		[Address(RVA = "0x1B43C80", Offset = "0x1B42E80", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
		[DeduplicatedMethod]
		[Token(Token = "0x60023E8")]
		internal int <TryGetValueFromBag>b__4_0(string s, int i) { }

	}


	[Address(RVA = "0x1B51B20", Offset = "0x1B50D20", Length = "0x8D")]
	[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlObjectTraits`1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 26)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TypedUxmlAttributeDescription`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60023E1")]
	public UxmlIntAttributeDescription() { }

	[Address(RVA = "0x1B517D0", Offset = "0x1B509D0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60023E4")]
	private static int ConvertValueToInt(string v, int defaultValue) { }

	[Address(RVA = "0x1B51810", Offset = "0x1B50A10", Length = "0x176")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UxmlAttributeDescription), Member = "GetValueFromBag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), "System.Func`3<String, T, T>", "T"}, ReturnType = "T")]
	[Token(Token = "0x60023E2")]
	public virtual int GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	[Address(RVA = "0x1B51990", Offset = "0x1B50B90", Length = "0x181")]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UxmlTraits), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(IUxmlAttributes), typeof(CreationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UxmlAttributeDescription), Member = "TryGetValueFromBag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IUxmlAttributes), typeof(CreationContext), "System.Func`3<String, T, T>", "T", "T&"}, ReturnType = typeof(bool))]
	[Token(Token = "0x60023E3")]
	public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref int value) { }

}

