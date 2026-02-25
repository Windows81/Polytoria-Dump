namespace UnityEngine.TextCore.Text;

[ExcludeFromObjectFactory]
[Token(Token = "0x2000036")]
public abstract class TextAsset : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000155")]
	internal string m_Version; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000156")]
	internal int m_InstanceID; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000157")]
	internal int m_HashCode; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("material")]
	[SerializeField]
	[Token(Token = "0x4000158")]
	internal Material m_Material; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000159")]
	internal int m_MaterialHashCode; //Field offset: 0x30

	[Token(Token = "0x17000036")]
	public int hashCode
	{
		[Address(RVA = "0x1A5C3B0", Offset = "0x1A5B5B0", Length = "0x32")]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddFontAssetInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SpriteAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddSpriteAssetInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SpriteAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextResourceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[Calls(Type = typeof(TextUtilities), Member = "GetHashCodeCaseInSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[Token(Token = "0x6000150")]
		 get { } //Length: 50
		[Address(RVA = "0x309520", Offset = "0x308720", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000151")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000035")]
	public int instanceID
	{
		[Address(RVA = "0x1889B70", Offset = "0x1888D70", Length = "0x28")]
		[CallerCount(Count = 41)]
		[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
		[DeduplicatedMethod]
		[Token(Token = "0x600014F")]
		 get { } //Length: 40
	}

	[Token(Token = "0x17000037")]
	public Material material
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000152")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000153")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000038")]
	public int materialHashCode
	{
		[Address(RVA = "0x1A5C3F0", Offset = "0x1A5B5F0", Length = "0x92")]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddFontAssetInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[Calls(Type = typeof(TextUtilities), Member = "GetHashCodeCaseInSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000154")]
		 get { } //Length: 146
		[Address(RVA = "0x388900", Offset = "0x387B00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000155")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000034")]
	public internal string version
	{
		[Address(RVA = "0xB081E0", Offset = "0xB073E0", Length = "0x7")]
		[CallerCount(Count = 73)]
		[DeduplicatedMethod]
		[Token(Token = "0x600014D")]
		 get { } //Length: 7
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600014E")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x40DB10", Offset = "0x40CD10", Length = "0x7")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000156")]
	protected TextAsset() { }

	[Address(RVA = "0x1A5C3B0", Offset = "0x1A5B5B0", Length = "0x32")]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddFontAssetInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SpriteAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddSpriteAssetInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SpriteAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextResourceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(TextUtilities), Member = "GetHashCodeCaseInSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000150")]
	public int get_hashCode() { }

	[Address(RVA = "0x1889B70", Offset = "0x1888D70", Length = "0x28")]
	[CallerCount(Count = 41)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x600014F")]
	public int get_instanceID() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000152")]
	public Material get_material() { }

	[Address(RVA = "0x1A5C3F0", Offset = "0x1A5B5F0", Length = "0x92")]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddFontAssetInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(TextUtilities), Member = "GetHashCodeCaseInSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000154")]
	public int get_materialHashCode() { }

	[Address(RVA = "0xB081E0", Offset = "0xB073E0", Length = "0x7")]
	[CallerCount(Count = 73)]
	[DeduplicatedMethod]
	[Token(Token = "0x600014D")]
	public string get_version() { }

	[Address(RVA = "0x309520", Offset = "0x308720", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000151")]
	public void set_hashCode(int value) { }

	[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000153")]
	public void set_material(Material value) { }

	[Address(RVA = "0x388900", Offset = "0x387B00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000155")]
	public void set_materialHashCode(int value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600014E")]
	internal void set_version(string value) { }

}

