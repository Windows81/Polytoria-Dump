namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200059E")]
internal abstract class BaseShaderInfoStorage : IDisposable
{
	[Token(Token = "0x4001434")]
	protected static int s_TextureCounter; //Field offset: 0x0
	[Token(Token = "0x4001435")]
	internal static ProfilerMarker s_MarkerCopyTexture; //Field offset: 0x8
	[Token(Token = "0x4001436")]
	internal static ProfilerMarker s_MarkerGetTextureData; //Field offset: 0x10
	[Token(Token = "0x4001437")]
	internal static ProfilerMarker s_MarkerUpdateTexture; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001438")]
	private bool <disposed>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000A1E")]
	protected private bool disposed
	{
		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002832")]
		 get { } //Length: 5
		[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002833")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000A1D")]
	public abstract Texture2D texture
	{
		[Token(Token = "0x600282E")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x1B8F890", Offset = "0x1B8EA90", Length = "0xD3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Token(Token = "0x6002837")]
	private static BaseShaderInfoStorage() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002836")]
	protected BaseShaderInfoStorage() { }

	[Token(Token = "0x600282F")]
	public abstract bool AllocateRect(int width, int height, out RectInt uvs) { }

	[Address(RVA = "0x1B8F820", Offset = "0x1B8EA20", Length = "0x61")]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002834")]
	public override void Dispose() { }

	[Address(RVA = "0x1B8F810", Offset = "0x1B8EA10", Length = "0xB")]
	[CalledBy(Type = typeof(ShaderInfoStorage`1), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6002835")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002832")]
	protected bool get_disposed() { }

	[Token(Token = "0x600282E")]
	public abstract Texture2D get_texture() { }

	[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002833")]
	private void set_disposed(bool value) { }

	[Token(Token = "0x6002830")]
	public abstract void SetTexel(int x, int y, Color color) { }

	[Token(Token = "0x6002831")]
	public abstract void UpdateTexture() { }

}

