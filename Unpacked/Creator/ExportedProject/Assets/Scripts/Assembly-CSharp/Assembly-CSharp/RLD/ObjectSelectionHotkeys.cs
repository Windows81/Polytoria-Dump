namespace RLD;

[Token(Token = "0x20002A3")]
public class ObjectSelectionHotkeys : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000A2D")]
	private Hotkeys _appendToSelection; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000A2E")]
	private Hotkeys _multiDeselect; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000A2F")]
	private Hotkeys _deleteSelected; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000A30")]
	private Hotkeys _focusCameraOnSelection; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000A31")]
	private Hotkeys _duplicateSelection; //Field offset: 0x48

	[Token(Token = "0x1700085B")]
	public Hotkeys AppendToSelection
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x600193D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700085D")]
	public Hotkeys DeleteSelected
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x600193F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700085F")]
	public Hotkeys DuplicateSelection
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001941")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700085E")]
	public Hotkeys FocusCameraOnSelection
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001940")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700085C")]
	public Hotkeys MultiDeselect
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x600193E")]
		 get { } //Length: 95
	}

	[Address(RVA = "0x3EA890", Offset = "0x3E9A90", Length = "0x1EF")]
	[CalledBy(Type = typeof(RTObjectSelection), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Hotkeys), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(HotkeysStaticData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Hotkeys), Member = "set_Key", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyCode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001942")]
	public ObjectSelectionHotkeys() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x600193D")]
	public Hotkeys get_AppendToSelection() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x600193F")]
	public Hotkeys get_DeleteSelected() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001941")]
	public Hotkeys get_DuplicateSelection() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001940")]
	public Hotkeys get_FocusCameraOnSelection() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x600193E")]
	public Hotkeys get_MultiDeselect() { }

}

