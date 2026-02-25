namespace UnityEngine.UI;

[Token(Token = "0x200000C")]
public class ClipperRegistry
{
	[Token(Token = "0x400002D")]
	private static ClipperRegistry s_Instance; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400002E")]
	private readonly IndexedSet<IClipper> m_Clippers; //Field offset: 0x10

	[Token(Token = "0x17000012")]
	public static ClipperRegistry instance
	{
		[Address(RVA = "0x1A78700", Offset = "0x1A77900", Length = "0xF1")]
		[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "PerformUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ClipperRegistry), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IClipper)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ClipperRegistry), Member = "Unregister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IClipper)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ClipperRegistry), Member = "Disable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IClipper)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(IndexedSet`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600004C")]
		 get { } //Length: 241
	}

	[Address(RVA = "0x1A78680", Offset = "0x1A77880", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexedSet`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600004B")]
	protected ClipperRegistry() { }

	[Address(RVA = "0x1A78410", Offset = "0x1A77610", Length = "0x132")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(IndexedSet`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004D")]
	public void Cull() { }

	[Address(RVA = "0x1A78550", Offset = "0x1A77750", Length = "0x53")]
	[CalledBy(Type = typeof(RectMask2D), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ClipperRegistry), Member = "get_instance", ReturnType = typeof(ClipperRegistry))]
	[Calls(Type = typeof(IndexedSet`1), Member = "DisableItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000050")]
	public static void Disable(IClipper c) { }

	[Address(RVA = "0x1A78700", Offset = "0x1A77900", Length = "0xF1")]
	[CalledBy(Type = typeof(CanvasUpdateRegistry), Member = "PerformUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClipperRegistry), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IClipper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClipperRegistry), Member = "Unregister", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IClipper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ClipperRegistry), Member = "Disable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IClipper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexedSet`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600004C")]
	public static ClipperRegistry get_instance() { }

	[Address(RVA = "0x1A785B0", Offset = "0x1A777B0", Length = "0x61")]
	[CalledBy(Type = typeof(RectMask2D), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ClipperRegistry), Member = "get_instance", ReturnType = typeof(ClipperRegistry))]
	[Calls(Type = typeof(IndexedSet`1), Member = "AddUnique", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600004E")]
	public static void Register(IClipper c) { }

	[Address(RVA = "0x1A78620", Offset = "0x1A77820", Length = "0x53")]
	[CalledBy(Type = typeof(RectMask2D), Member = "OnDestroy", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ClipperRegistry), Member = "get_instance", ReturnType = typeof(ClipperRegistry))]
	[Calls(Type = typeof(IndexedSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600004F")]
	public static void Unregister(IClipper c) { }

}

