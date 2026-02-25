namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200059F")]
internal class ShaderInfoStorage : BaseShaderInfoStorage
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001439")]
	private readonly int m_InitialSize; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400143A")]
	private readonly int m_MaxSize; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400143B")]
	private readonly TextureFormat m_Format; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400143C")]
	private readonly Func<Color, T> m_Convert; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400143D")]
	private UIRAtlasAllocator m_Allocator; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400143E")]
	private Texture2D m_Texture; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400143F")]
	private NativeArray<T> m_Texels; //Field offset: 0x0

	[Token(Token = "0x17000A1F")]
	public virtual Texture2D texture
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x600283A")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xF14F10", Offset = "0xF14110", Length = "0x104")]
	[CalledBy(Type = typeof(ShaderInfoStorageRGBAFloat), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002838")]
	public ShaderInfoStorage`1(TextureFormat format, Func<Color, T> convert, int initialSize = 64, int maxSize = 4096) { }

	[Address(RVA = "0xF13B80", Offset = "0xF12D80", Length = "0x150")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UIRAtlasAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UIRAtlasAllocator), Member = "TryAllocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RectInt&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ShaderInfoStorage`1), Member = "CreateOrExpandTexture", ReturnType = typeof(void))]
	[Calls(Type = typeof(DisposeHelper), Member = "NotifyDisposedUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDisposable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600283B")]
	public virtual bool AllocateRect(int width, int height, out RectInt uvs) { }

	[Address(RVA = "0xF14060", Offset = "0xF13260", Length = "0x104")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600283F")]
	private static void CpuBlit(NativeArray<T> src, int srcWidth, int srcHeight, NativeArray<T> dst, int dstWidth, int dstHeight) { }

	[Address(RVA = "0xF14170", Offset = "0xF13370", Length = "0x3F2")]
	[CalledBy(Type = typeof(ShaderInfoStorage`1), Member = "AllocateRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RectInt&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "set_filterMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FilterMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Texture2D), Member = "GetRawTextureData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UIRUtility), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600283E")]
	private void CreateOrExpandTexture() { }

	[Address(RVA = "0xF149F0", Offset = "0xF13BF0", Length = "0xC9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIRUtility), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UIRAtlasAllocator), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(BaseShaderInfoStorage), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002839")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x600283A")]
	public virtual Texture2D get_texture() { }

	[Address(RVA = "0xF14C80", Offset = "0xF13E80", Length = "0xFC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texture2D), Member = "GetRawTextureData", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "Unity.Collections.NativeArray`1<T>")]
	[Calls(Type = typeof(DisposeHelper), Member = "NotifyDisposedUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDisposable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600283C")]
	public virtual void SetTexel(int x, int y, Color color) { }

	[Address(RVA = "0xF14D80", Offset = "0xF13F80", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Texture2D), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DisposeHelper), Member = "NotifyDisposedUsed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDisposable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600283D")]
	public virtual void UpdateTexture() { }

}

