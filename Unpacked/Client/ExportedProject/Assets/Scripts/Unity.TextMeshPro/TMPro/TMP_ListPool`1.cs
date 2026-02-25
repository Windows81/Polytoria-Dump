namespace TMPro;

[Token(Token = "0x2000072")]
internal static class TMP_ListPool
{
	[CompilerGenerated]
	[Token(Token = "0x2000073")]
	private sealed class <>c
	{
		[Token(Token = "0x4000329")]
		public static readonly <>c<T> <>9; //Field offset: 0x0

		[Address(RVA = "0x7FC210", Offset = "0x7FB410", Length = "0xE9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600040B")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600040C")]
		public <>c() { }

		[Address(RVA = "0x7F9D20", Offset = "0x7F8F20", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600040D")]
		internal void <.cctor>b__3_0(List<T> l) { }

	}

	[Token(Token = "0x4000328")]
	private static readonly TMP_ObjectPool<List`1<T>> s_ListPool; //Field offset: 0x0

	[Address(RVA = "0xF7C7E0", Offset = "0xF7B9E0", Length = "0x294")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Stack`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600040A")]
	private static TMP_ListPool`1() { }

	[Address(RVA = "0xF7C400", Offset = "0xF7B600", Length = "0x121")]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GetCanvas", ReturnType = typeof(Canvas))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_MaterialManager), Member = "GetStencilID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TMP_MaterialManager), Member = "GetMaterialForRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaskableGraphic), typeof(Material)}, ReturnType = typeof(Material))]
	[CalledBy(Type = typeof(TMP_MaterialManager), Member = "FindRootSortOverrideCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(Transform))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000408")]
	public static List<T> Get() { }

	[Address(RVA = "0xF7C530", Offset = "0xF7B730", Length = "0x186")]
	[CalledBy(Type = typeof(TMP_MaterialManager), Member = "FindRootSortOverrideCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(Transform))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GetCanvas", ReturnType = typeof(Canvas))]
	[CalledBy(Type = typeof(TMP_Dropdown), Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_MaterialManager), Member = "GetStencilID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TMP_MaterialManager), Member = "GetMaterialForRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaskableGraphic), typeof(Material)}, ReturnType = typeof(Material))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Stack`1), Member = "Peek", ReturnType = "T")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000409")]
	public static void Release(List<T> toRelease) { }

}

