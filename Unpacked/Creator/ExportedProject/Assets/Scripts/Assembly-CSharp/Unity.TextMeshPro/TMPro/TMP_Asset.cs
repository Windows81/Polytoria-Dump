namespace TMPro;

[Token(Token = "0x200002B")]
public abstract class TMP_Asset : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000130")]
	internal string m_Version; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000131")]
	internal int m_InstanceID; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000132")]
	internal int m_HashCode; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000133")]
	internal FaceInfo m_FaceInfo; //Field offset: 0x28
	[FieldOffset(Offset = "0x88")]
	[FormerlySerializedAs("material")]
	[SerializeField]
	[Token(Token = "0x4000134")]
	internal Material m_Material; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000135")]
	internal int m_MaterialHashCode; //Field offset: 0x90

	[Token(Token = "0x17000036")]
	public FaceInfo faceInfo
	{
		[Address(RVA = "0x1889AC0", Offset = "0x1888CC0", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600014D")]
		 get { } //Length: 51
		[Address(RVA = "0x1889C70", Offset = "0x1888E70", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600014E")]
		 set { } //Length: 58
	}

	[Token(Token = "0x17000035")]
	public int hashCode
	{
		[Address(RVA = "0x1889B00", Offset = "0x1888D00", Length = "0x6D")]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddFontAssetInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_SpriteAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddSpriteAssetInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_SpriteAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TMP_SpriteAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddSpriteAssetInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TMP_SpriteAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_SpriteAsset)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TMP_ResourceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_TextUtilities), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[Token(Token = "0x600014B")]
		 get { } //Length: 109
		[Address(RVA = "0x309520", Offset = "0x308720", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600014C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000034")]
	public int instanceID
	{
		[Address(RVA = "0x1889B70", Offset = "0x1888D70", Length = "0x28")]
		[CallerCount(Count = 41)]
		[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
		[DeduplicatedMethod]
		[Token(Token = "0x600014A")]
		 get { } //Length: 40
	}

	[Token(Token = "0x17000037")]
	public Material material
	{
		[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600014F")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD530", Offset = "0x2DC730", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000150")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000038")]
	public int materialHashCode
	{
		[Address(RVA = "0x1889BA0", Offset = "0x1888DA0", Length = "0xCA")]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddFontAssetInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000151")]
		 get { } //Length: 202
		[Address(RVA = "0x2FDE30", Offset = "0x2FD030", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000152")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000033")]
	public internal string version
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000148")]
		 get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000149")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x40DB10", Offset = "0x40CD10", Length = "0x7")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000153")]
	protected TMP_Asset() { }

	[Address(RVA = "0x1889AC0", Offset = "0x1888CC0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600014D")]
	public FaceInfo get_faceInfo() { }

	[Address(RVA = "0x1889B00", Offset = "0x1888D00", Length = "0x6D")]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddFontAssetInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_SpriteAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddSpriteAssetInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_SpriteAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TMP_SpriteAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddSpriteAssetInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TMP_SpriteAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_SpriteAsset)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_ResourceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_TextUtilities), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Token(Token = "0x600014B")]
	public int get_hashCode() { }

	[Address(RVA = "0x1889B70", Offset = "0x1888D70", Length = "0x28")]
	[CallerCount(Count = 41)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x600014A")]
	public int get_instanceID() { }

	[Address(RVA = "0x2DD210", Offset = "0x2DC410", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600014F")]
	public Material get_material() { }

	[Address(RVA = "0x1889BA0", Offset = "0x1888DA0", Length = "0xCA")]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MaterialReferenceManager), Member = "AddFontAssetInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000151")]
	public int get_materialHashCode() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000148")]
	public string get_version() { }

	[Address(RVA = "0x1889C70", Offset = "0x1888E70", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600014E")]
	public void set_faceInfo(FaceInfo value) { }

	[Address(RVA = "0x309520", Offset = "0x308720", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600014C")]
	public void set_hashCode(int value) { }

	[Address(RVA = "0x2DD530", Offset = "0x2DC730", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000150")]
	public void set_material(Material value) { }

	[Address(RVA = "0x2FDE30", Offset = "0x2FD030", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000152")]
	public void set_materialHashCode(int value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000149")]
	internal void set_version(string value) { }

}

