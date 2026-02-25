namespace UnityEngine;

[Token(Token = "0x200000B")]
[UsedByNativeCode]
public struct CharacterInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400003B")]
	public int index; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Obsolete("CharacterInfo.uv is deprecated. Use uvBottomLeft, uvBottomRight, uvTopRight or uvTopLeft instead.")]
	[Token(Token = "0x400003C")]
	public Rect uv; //Field offset: 0x4
	[FieldOffset(Offset = "0x14")]
	[Obsolete("CharacterInfo.vert is deprecated. Use minX, maxX, minY, maxY instead.")]
	[Token(Token = "0x400003D")]
	public Rect vert; //Field offset: 0x14
	[FieldOffset(Offset = "0x24")]
	[NativeName("advance")]
	[Obsolete("CharacterInfo.width is deprecated. Use advance instead.")]
	[Token(Token = "0x400003E")]
	public float width; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400003F")]
	public int size; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000040")]
	public FontStyle style; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Obsolete("CharacterInfo.flipped is deprecated. Use uvBottomLeft, uvBottomRight, uvTopRight or uvTopLeft instead, which will be correct regardless of orientation.")]
	[Token(Token = "0x4000041")]
	public bool flipped; //Field offset: 0x30

	[Token(Token = "0x17000008")]
	public int advance
	{
		[Address(RVA = "0x1A717C0", Offset = "0x1A709C0", Length = "0x9A")]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "CalculateLengthOfDropdownText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Math), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(MidpointRounding)}, ReturnType = typeof(double))]
		[Token(Token = "0x6000029")]
		 get { } //Length: 154
	}

	[Address(RVA = "0x1A717C0", Offset = "0x1A709C0", Length = "0x9A")]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "CalculateLengthOfDropdownText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(MidpointRounding)}, ReturnType = typeof(double))]
	[Token(Token = "0x6000029")]
	public int get_advance() { }

}

