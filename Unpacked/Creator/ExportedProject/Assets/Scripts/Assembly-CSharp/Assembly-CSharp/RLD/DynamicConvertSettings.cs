namespace RLD;

[Token(Token = "0x2000276")]
public class DynamicConvertSettings : Settings
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009AC")]
	private Rect _prefabFolderDropRect; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40009AD")]
	private GameObjectType _convertableObjectTypes; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40009AE")]
	private string _prefabFolder; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x40009AF")]
	private bool _processPrefabSubfolders; //Field offset: 0x48

	[Token(Token = "0x1700082C")]
	public GameObjectType ConvertableObjectTypes
	{
		[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001899")]
		 get { } //Length: 4
		[Address(RVA = "0x3212B0", Offset = "0x3204B0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600189A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700082D")]
	public string PrefabFolder
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600189B")]
		 get { } //Length: 5
		[Address(RVA = "0x5AFEF0", Offset = "0x5AF0F0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600189C")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700082F")]
	public Rect PrefabFolderDropRect
	{
		[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600189F")]
		 get { } //Length: 11
	}

	[Token(Token = "0x1700082E")]
	public bool ProcessPrefabSubfolders
	{
		[Address(RVA = "0x347A30", Offset = "0x346C30", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600189D")]
		 get { } //Length: 5
		[Address(RVA = "0x347A50", Offset = "0x346C50", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600189E")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x5AFE40", Offset = "0x5AF040", Length = "0xB0")]
	[CalledBy(Type = typeof(RLDApp), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60018A0")]
	public DynamicConvertSettings() { }

	[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001899")]
	public GameObjectType get_ConvertableObjectTypes() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600189B")]
	public string get_PrefabFolder() { }

	[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600189F")]
	public Rect get_PrefabFolderDropRect() { }

	[Address(RVA = "0x347A30", Offset = "0x346C30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600189D")]
	public bool get_ProcessPrefabSubfolders() { }

	[Address(RVA = "0x3212B0", Offset = "0x3204B0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600189A")]
	public void set_ConvertableObjectTypes(GameObjectType value) { }

	[Address(RVA = "0x5AFEF0", Offset = "0x5AF0F0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600189C")]
	public void set_PrefabFolder(string value) { }

	[Address(RVA = "0x347A50", Offset = "0x346C50", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600189E")]
	public void set_ProcessPrefabSubfolders(bool value) { }

}

