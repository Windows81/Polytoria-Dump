namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003C8")]
public class UIFieldProxy : InstanceProxy
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001012")]
	private readonly UIField uiField; //Field offset: 0x18

	[Token(Token = "0x17000C6D")]
	public bool ClipDescendants
	{
		[Address(RVA = "0x4B55B0", Offset = "0x4B47B0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002922")]
		 get { } //Length: 30
		[Address(RVA = "0x4B56F0", Offset = "0x4B48F0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIField), Member = "set_ClipDescendants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002923")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C65")]
	public LuaEvent MouseDown
	{
		[Address(RVA = "0x4A4080", Offset = "0x4A3280", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002913")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000C64")]
	public LuaEvent MouseUp
	{
		[Address(RVA = "0x4A6330", Offset = "0x4A5530", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002912")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000C6B")]
	public Vector2 PivotPoint
	{
		[Address(RVA = "0x4B55D0", Offset = "0x4B47D0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIField), Member = "get_PivotPoint", ReturnType = typeof(Vector2))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600291E")]
		 get { } //Length: 29
		[Address(RVA = "0x4B5710", Offset = "0x4B4910", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIField), Member = "set_PivotPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600291F")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C66")]
	public Vector2 PositionOffset
	{
		[Address(RVA = "0x4B55F0", Offset = "0x4B47F0", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002914")]
		 get { } //Length: 47
		[Address(RVA = "0x4B5730", Offset = "0x4B4930", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002915")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C67")]
	public Vector2 PositionRelative
	{
		[Address(RVA = "0x4B5620", Offset = "0x4B4820", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002916")]
		 get { } //Length: 47
		[Address(RVA = "0x4B5750", Offset = "0x4B4950", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002917")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C68")]
	public float Rotation
	{
		[Address(RVA = "0x4B5650", Offset = "0x4B4850", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIField), Member = "get_Rotation", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002918")]
		 get { } //Length: 29
		[Address(RVA = "0x4B5770", Offset = "0x4B4970", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIField), Member = "set_Rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002919")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C69")]
	public Vector2 SizeOffset
	{
		[Address(RVA = "0x4B5670", Offset = "0x4B4870", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600291A")]
		 get { } //Length: 47
		[Address(RVA = "0x4B5790", Offset = "0x4B4990", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600291B")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C6A")]
	public Vector2 SizeRelative
	{
		[Address(RVA = "0x4B56A0", Offset = "0x4B48A0", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600291C")]
		 get { } //Length: 47
		[Address(RVA = "0x4B57B0", Offset = "0x4B49B0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600291D")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C6C")]
	public bool Visible
	{
		[Address(RVA = "0x4B56D0", Offset = "0x4B48D0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002920")]
		 get { } //Length: 30
		[Address(RVA = "0x4B57D0", Offset = "0x4B49D0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UIField), Member = "set_Visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002921")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x4A1050", Offset = "0x4A0250", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x6002911")]
	public UIFieldProxy(UIField target) { }

	[Address(RVA = "0x4B55B0", Offset = "0x4B47B0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002922")]
	public bool get_ClipDescendants() { }

	[Address(RVA = "0x4A4080", Offset = "0x4A3280", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002913")]
	public LuaEvent get_MouseDown() { }

	[Address(RVA = "0x4A6330", Offset = "0x4A5530", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002912")]
	public LuaEvent get_MouseUp() { }

	[Address(RVA = "0x4B55D0", Offset = "0x4B47D0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIField), Member = "get_PivotPoint", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600291E")]
	public Vector2 get_PivotPoint() { }

	[Address(RVA = "0x4B55F0", Offset = "0x4B47F0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002914")]
	public Vector2 get_PositionOffset() { }

	[Address(RVA = "0x4B5620", Offset = "0x4B4820", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002916")]
	public Vector2 get_PositionRelative() { }

	[Address(RVA = "0x4B5650", Offset = "0x4B4850", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIField), Member = "get_Rotation", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002918")]
	public float get_Rotation() { }

	[Address(RVA = "0x4B5670", Offset = "0x4B4870", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600291A")]
	public Vector2 get_SizeOffset() { }

	[Address(RVA = "0x4B56A0", Offset = "0x4B48A0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600291C")]
	public Vector2 get_SizeRelative() { }

	[Address(RVA = "0x4B56D0", Offset = "0x4B48D0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002920")]
	public bool get_Visible() { }

	[Address(RVA = "0x4B56F0", Offset = "0x4B48F0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIField), Member = "set_ClipDescendants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002923")]
	public void set_ClipDescendants(bool value) { }

	[Address(RVA = "0x4B5710", Offset = "0x4B4910", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIField), Member = "set_PivotPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600291F")]
	public void set_PivotPoint(Vector2 value) { }

	[Address(RVA = "0x4B5730", Offset = "0x4B4930", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002915")]
	public void set_PositionOffset(Vector2 value) { }

	[Address(RVA = "0x4B5750", Offset = "0x4B4950", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002917")]
	public void set_PositionRelative(Vector2 value) { }

	[Address(RVA = "0x4B5770", Offset = "0x4B4970", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIField), Member = "set_Rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002919")]
	public void set_Rotation(float value) { }

	[Address(RVA = "0x4B5790", Offset = "0x4B4990", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600291B")]
	public void set_SizeOffset(Vector2 value) { }

	[Address(RVA = "0x4B57B0", Offset = "0x4B49B0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600291D")]
	public void set_SizeRelative(Vector2 value) { }

	[Address(RVA = "0x4B57D0", Offset = "0x4B49D0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIField), Member = "set_Visible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002921")]
	public void set_Visible(bool value) { }

}

