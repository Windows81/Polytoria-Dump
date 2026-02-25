namespace UnityEngine.UIElements;

[Token(Token = "0x200017F")]
internal class CursorManager : ICursorManager
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000751")]
	private bool <isCursorOverriden>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000200")]
	public private bool isCursorOverriden
	{
		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B68")]
		 get { } //Length: 5
		[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B69")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B6C")]
	public CursorManager() { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B68")]
	public bool get_isCursorOverriden() { }

	[Address(RVA = "0x1C31030", Offset = "0x1C30230", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Cursor), Member = "SetCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Vector2), typeof(CursorMode)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000B6B")]
	public override void ResetCursor() { }

	[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B69")]
	private void set_isCursorOverriden(bool value) { }

	[Address(RVA = "0x1C310A0", Offset = "0x1C302A0", Length = "0x123")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Cursor), Member = "SetCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Vector2), typeof(CursorMode)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000B6A")]
	public override void SetCursor(Cursor cursor) { }

}

