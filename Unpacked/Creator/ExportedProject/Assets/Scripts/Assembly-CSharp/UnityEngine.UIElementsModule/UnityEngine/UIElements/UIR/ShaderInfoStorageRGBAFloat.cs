namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005A0")]
internal class ShaderInfoStorageRGBAFloat : ShaderInfoStorage<Color>
{
	[CompilerGenerated]
	[Token(Token = "0x20005A1")]
	private sealed class <>c
	{
		[Token(Token = "0x4001441")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1BA2160", Offset = "0x1BA1360", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002842")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002843")]
		public <>c() { }

		[Address(RVA = "0x1BA1FA0", Offset = "0x1BA11A0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6002844")]
		internal Color <.cctor>b__2_0(Color c) { }

	}

	[Token(Token = "0x4001440")]
	private static readonly Func<Color, Color> s_Convert; //Field offset: 0x0

	[Address(RVA = "0x1B9EEC0", Offset = "0x1B9E0C0", Length = "0xC8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002841")]
	private static ShaderInfoStorageRGBAFloat() { }

	[Address(RVA = "0x1B9EF90", Offset = "0x1B9E190", Length = "0x99")]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "ReallyCreateStorage", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ShaderInfoStorage`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat), "System.Func`2<Color, T>", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002840")]
	public ShaderInfoStorageRGBAFloat(int initialSize = 64, int maxSize = 4096) { }

}

