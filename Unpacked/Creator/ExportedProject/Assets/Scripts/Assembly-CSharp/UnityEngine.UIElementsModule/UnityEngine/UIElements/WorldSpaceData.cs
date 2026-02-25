namespace UnityEngine.UIElements;

[Token(Token = "0x2000537")]
internal struct WorldSpaceData
{
	[Token(Token = "0x4001147")]
	public static readonly Bounds k_Empty3DBounds; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001148")]
	public Bounds localBounds3D; //Field offset: 0x0
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001149")]
	public Bounds localBoundsPicking3D; //Field offset: 0x18
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400114A")]
	public Bounds localBoundsWithoutNested3D; //Field offset: 0x30
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400114B")]
	public Rect boundingBoxWithoutNested; //Field offset: 0x48

	[Address(RVA = "0x1B7A450", Offset = "0x1B79650", Length = "0x1A5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60025C4")]
	private static WorldSpaceData() { }

}

